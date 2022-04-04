﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SearchTool_Extended_Rebuild
{
    public partial class Form1 : Form
    {
        float unitMultiplier = 1;
        int currentMouseOverRow = 0;  
        string fileExtensionFilter = "";
        List<FileInfo> globalFileInfoList = new List<FileInfo> { };
        List<string> globalDirectories= new List<string> { };

        public Form1()
        {
            InitializeComponent();
            this.ActiveControl = textBox_inputSearch;
            showStartParameter();
        }

        public class ShowFiles
        {
            public string Filename { get; set; }
            public string Size { get; set; }
            public string Path { get; set; }
            public string CreatedAt { get; set; }
            public string LastAccessTime { get; set; }
            public string LastWritingTime { get; set; }
        }

        //-----------------------------------------------------------------------------------
        // Handles the Startparameter that might be given if the program is used to start within
        // the context-menue (has to be setup in the Registry first)
        //-----------------------------------------------------------------------------------
        public void showStartParameter()
        {
            string[] CommandLineArgs = Environment.GetCommandLineArgs();
            if (CommandLineArgs.Length > 1)
            {
                label_selectedFolder.Text = $"{CommandLineArgs[1].ToString()}";
                this.folderBrowserDialog_searchFolder.SelectedPath = CommandLineArgs[1].ToString();
            }
        }

        private void SizeChangedAction(object sender, EventArgs e)
        {
            int WidthOfForm = this.Size.Width;
            int HeightOfForm = this.Size.Height;
            dataGridView_searchResults.Size = new System.Drawing.Size(WidthOfForm - dataGridView_searchResults.Location.X - 30, 
                                                                      HeightOfForm - dataGridView_searchResults.Location.Y - 50);
        }

        //-----------------------------------------------------------------------------------
        // Context-Menue to make user click on a found file to open it in explorer on a right
        // click or filter the result by additional parameters like the extension
        //-----------------------------------------------------------------------------------
        private void DataGridRightClick_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Right) return;

            dataGridView_searchResults.ClearSelection();
            
            currentMouseOverRow = dataGridView_searchResults.HitTest(e.X, e.Y).RowIndex;

            if (currentMouseOverRow >= 0)
            {
                dataGridView_searchResults.Rows[currentMouseOverRow].Selected = true;
                contextMenuStrip1.Show(dataGridView_searchResults, new Point(e.X, e.Y));
            }
        }
        private void openInExplorerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string cellValue = dataGridView_searchResults.Rows[currentMouseOverRow].Cells[2].Value.ToString();
               
        if (File.Exists(cellValue))
            {
                Process.Start("explorer.exe", "/select, " + cellValue);
            }
        }
        private void filterByThisExtensionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string cellValue = dataGridView_searchResults.Rows[currentMouseOverRow].Cells[2].Value.ToString();
            fileExtensionFilter = Path.GetExtension(cellValue);

            showSearchResultsOnList();
        }
        private void clearAllFiltersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fileExtensionFilter = "";

            showSearchResultsOnDatagrid_FromPreset();
        }
        //-----------------------------------------------------------------------------------
        // END OF CONTEXTMENU FUNCTIONS
        //-----------------------------------------------------------------------------------

        private void change_FileUnit(object sender, EventArgs e)
        {
            showSearchResultsOnDatagrid_FromPreset();
        }

        private void button_selectFolder_Click(object sender, EventArgs e)
        {
            DialogResult result = folderBrowserDialog_searchFolder.ShowDialog();

            if (result == DialogResult.OK)
            {
                label_selectedFolder.Text = folderBrowserDialog_searchFolder.SelectedPath;
            }
        }

        private void button_startSearch_Click(object sender, EventArgs e)
        {
            showSearchResultsOnList();
        }

        //-----------------------------------------------------------------------------------
        // If enter is pressed on search-string perform search on filesystem
        //-----------------------------------------------------------------------------------
        private void IsEnterPressed(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                button_startSearch_Click(this, new EventArgs());
                e.SuppressKeyPress = true;
            }
        }

        //-----------------------------------------------------------------------------------
        // If enter is pressed on textbox in filter perform search on list of found files only
        //-----------------------------------------------------------------------------------
        private void IsEnterPressedOnFilter(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                showSearchResultsOnDatagrid_FromPreset();
                e.SuppressKeyPress = true;
            }
        }

        //-----------------------------------------------------------------------------------
        // Toogle visibility of textboxes to enter from-to on sizeFilter
        //-----------------------------------------------------------------------------------
        private void checkBox_sizeFilter_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_sizeFilter.Checked)
            {
                textBox_startSize.Visible = true;
                textBox_endSize.Visible = true;
            }
            else
            {
                textBox_startSize.Visible = false;
                textBox_endSize.Visible = false;
            }
        }
        //-----------------------------------------------------------------------------------
        // main-function:
        // -> Clears previous search-results
        // -> Gets all files if checked from all subdirectories, using the checked filters
        // -> 
        //-----------------------------------------------------------------------------------
        private FileInfo[] getFilesInDirectory(string _directory)
        {
            globalDirectories.Clear();
            List<FileInfo> files = new List<FileInfo>();
           
            // get all files in the subdirectories if checkbox is checked
            if (checkBox_searchSubdirectory.Checked)
            {
                DirectoryInfo directoryInfo = new DirectoryInfo(_directory);
                files.AddRange(directoryInfo.GetFiles($"*{textBox_inputSearch.Text}*"));

                getSubDirectories(_directory);

                try
                {
                    foreach (string directory in globalDirectories)
                    {
                        directoryInfo = new DirectoryInfo(directory);
                        files.AddRange(directoryInfo.GetFiles($"*{textBox_inputSearch.Text}*"));
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error (Directory) 1st: " + ex.Message);
                }
            }
            else
            {
                DirectoryInfo directoryInfo = new DirectoryInfo(_directory);
                files.AddRange(directoryInfo.GetFiles($"*{textBox_inputSearch.Text}*"));
            }
           
            //-----------------------------------------------------------------------------------
            // checking and setting the unit multiplier to convert to MB, GB or KB
            //-----------------------------------------------------------------------------------
            unitMultiplier = getUnitMultiplier();
            
            if (checkBox_sizeFilter.Checked) 
            {
                //if checkbox is checked but no values are given -> dont filter anything
                if(textBox_endSize.Text == "" && textBox_startSize.Text == "") 
                { 
                    return files.ToArray(); 
                }

                List<FileInfo> fileInfoList = new List<FileInfo>();

                double startSize = 0;
                double endSize = Double.PositiveInfinity;
                
                //-----------------------------------------------------------------------------------
                // checking if not set and if the given value can be parsed to double if so -> use it
                //-----------------------------------------------------------------------------------
                if (textBox_startSize.Text != "" && double.TryParse(textBox_startSize.Text, out _)) 
                {
                    startSize = Convert.ToDouble(textBox_startSize.Text);
                }
                if (textBox_endSize.Text != "" && double.TryParse(textBox_endSize.Text, out _)) 
                {
                    endSize = Convert.ToDouble(textBox_endSize.Text);
                }
                
                foreach (FileInfo fileInfo in files)
                {
                    if (fileInfo.Length / unitMultiplier >= startSize && fileInfo.Length / unitMultiplier <= endSize) 
                    {
                        fileInfoList.Add(fileInfo);
                    }
                }
                return fileInfoList.ToArray();
            }
            return files.ToArray();
        }

        //-----------------------------------------------------------------------------------
        // reads the value from the combobox and sets it to the global unitmultiplier
        //-----------------------------------------------------------------------------------
        private float getUnitMultiplier()
        {
            switch (comboBox_sizeUnit.Text)
            {
                case "GB":
                    unitMultiplier = 1024 * 1024 * 1024;
                    break;
                case "MB":
                    unitMultiplier = 1024 * 1024;
                    break;
                case "KB":
                    unitMultiplier = 1024;
                    break;
                case "Byte":
                    unitMultiplier = 1;
                    break;
                default:
                    unitMultiplier = 1;
                    break;
            }
            return unitMultiplier;
        }

        //-----------------------------------------------------------------------------------
        // Gets all Subdirectories if "Subdirectory" is checked to perform filesearch on them
        //-----------------------------------------------------------------------------------
        public void getSubDirectories(string DirectoryPath)
        {
            string[] directories = { };
            try
            {
                directories = Directory.GetDirectories(DirectoryPath);
            }
            catch(Exception ex)
            {
                label_errorOutput.Text = "Error: " + ex.Message;
            }

            foreach (string directory in directories)
            {
                globalDirectories.Add(directory);
                getSubDirectories(directory);
            }
        }

        //-----------------------------------------------------------------------------------
        // Draws the results of the search on the datagrid-view and therefore triggering the
        // search on the filesystem. As the file extension filter is set on the datagrid the 
        // filtering is performed in this function too.
        // -> sets the display index of the first and second element on the datagrid
        // -> filecount is set according to what is shown on datagrid
        //-----------------------------------------------------------------------------------
        private void showSearchResultsOnList()
        {
            Cursor.Current = Cursors.WaitCursor;
            FileInfo[] files = { };
            List<ShowFiles> fileList = new List<ShowFiles>();
            
            if(fileExtensionFilter=="")
            {
                globalFileInfoList.Clear();
                
                files = getFilesInDirectory(folderBrowserDialog_searchFolder.SelectedPath);

                foreach (FileInfo file in files)
                {
                    fileList.Add(new ShowFiles
                    {
                        Filename = file.Name,
                        Path = file.FullName,
                        Size = Math.Round((file.Length / unitMultiplier), 4).ToString() + " " + comboBox_sizeUnit.Text,
                        CreatedAt = file.CreationTime.ToString(),
                        LastWritingTime = file.LastWriteTime.ToString(),
                        LastAccessTime = file.LastAccessTime.ToString(),
                    });
                    globalFileInfoList.Add(file);
                }
            }
            else
            {
                files = globalFileInfoList.ToArray();

                foreach (FileInfo file in files)
                {
                    if (fileExtensionFilter == Path.GetExtension(file.FullName))
                    {
                        fileList.Add(new ShowFiles
                        {
                            Filename = file.Name,
                            Path = file.FullName,
                            Size = Math.Round((file.Length / unitMultiplier), 4).ToString() + " " + comboBox_sizeUnit.Text,
                            CreatedAt = file.CreationTime.ToString(),
                            LastWritingTime = file.LastWriteTime.ToString(),
                            LastAccessTime = file.LastAccessTime.ToString(),
                        });
                    }
                }
            }
            dataGridView_searchResults.DataSource = fileList;
            dataGridView_searchResults.Columns["Filename"].DisplayIndex = 0;
            dataGridView_searchResults.Columns["Path"].DisplayIndex = 1;
          
            // COUNTERS
            label_fileCount.Text = fileList.Count.ToString();
            Cursor.Current = Cursors.Default;
        }

        //-----------------------------------------------------------------------------------
        // Draws the results of the search on the datagrid-view. The drawing is based on the 
        // filelist created by clicking "search" or hitting the enter button on the searchstring 
        // textbox. This function is mainly performed if a filter is reset, like the sizefilter 
        // maximum for example.
        // This is implemented to perform a much faster filter if a search already has been performed.
        // -> does the same filtering as "showSearchResultsOnList"
        //-----------------------------------------------------------------------------------
        private void showSearchResultsOnDatagrid_FromPreset()
        {
            Cursor.Current = Cursors.WaitCursor;
            FileInfo[] files = { };
            List<ShowFiles> fileList = new List<ShowFiles>();
           
            files = globalFileInfoList.ToArray();
            if (checkBox_sizeFilter.Checked)
            {
                //if checkbox is checked but no values are given -> dont filter anything
                if (textBox_endSize.Text == "" && textBox_startSize.Text == "")
                {
                    files = globalFileInfoList.ToArray();
                }

                List<FileInfo> fileInfoList = new List<FileInfo>();

                double startSize = 0;
                double endSize = Double.PositiveInfinity;


                //-----------------------------------------------------------------------------------
                // checking if not set and if the given value can be parsed to double if so -> use it
                //-----------------------------------------------------------------------------------
                if (textBox_startSize.Text != "" && double.TryParse(textBox_startSize.Text, out _))
                {
                    startSize = Convert.ToDouble(textBox_startSize.Text);
                }
                if (textBox_endSize.Text != "" && double.TryParse(textBox_endSize.Text, out _))
                {
                    endSize = Convert.ToDouble(textBox_endSize.Text);
                }
                
                foreach (FileInfo fileInfo in files)
                {
                    if (fileInfo.Length / unitMultiplier >= startSize && fileInfo.Length / unitMultiplier <= endSize)
                    {
                        fileInfoList.Add(fileInfo);
                    }
                }
                files = fileInfoList.ToArray();
            }
            
            unitMultiplier = getUnitMultiplier();

            foreach (FileInfo file in files)
            {
                fileList.Add(new ShowFiles
                {
                    Filename = file.Name,
                    Path = file.FullName,
                    Size = Math.Round((file.Length / unitMultiplier), 4).ToString() + " " + comboBox_sizeUnit.Text,
                    CreatedAt = file.CreationTime.ToString(),
                    LastWritingTime = file.LastWriteTime.ToString(),
                    LastAccessTime = file.LastAccessTime.ToString(),
                });
            }
            dataGridView_searchResults.DataSource = fileList;
            dataGridView_searchResults.Columns["Filename"].DisplayIndex = 0;
            dataGridView_searchResults.Columns["Path"].DisplayIndex = 1;
            
            // COUNTERS
            label_fileCount.Text = fileList.Count.ToString();
            Cursor.Current = Cursors.Default;
        }

       
    }
}
