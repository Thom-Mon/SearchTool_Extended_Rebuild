using System;
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
        List<string> fileExtensions = new List<string> { };
        List<FileInfo> globalFileInfoList = new List<FileInfo> { };

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
        // click and then "Open in Explorer" or "Filtering by some items"
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
            //comboBox_filterExtension.Items.Clear();
            fileExtensions.Clear();

            showSearchResultsOnList();
        }

        private void IsEnterPressed(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                button_startSearch_Click(this, new EventArgs());
                e.SuppressKeyPress = true;
            }
        }

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

        private FileInfo[] getFilesInDirectory(string _directory)
        {
            DirectoryInfo directoryInfo = new DirectoryInfo(_directory);
            FileInfo[] files = { };

            try
            {
                // get all files in the subdirectories if checkbox is checked
                if (checkBox_searchSubdirectory.Checked)
                {
                    files = directoryInfo.GetFiles($"*{textBox_inputSearch.Text}*", SearchOption.AllDirectories);
                }
                else
                {
                    files = directoryInfo.GetFiles($"*{textBox_inputSearch.Text}*");
                }
            }
            catch
            {

            }
            //-----------------------------------------------------------------------------------
            // checking the unit multiplier to convert to MB, GB or KB
            //-----------------------------------------------------------------------------------
            unitMultiplier = 1;
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

            // If sizecheck is checked
            if (checkBox_sizeFilter.Checked) 
            {
                //if checkbox is checked but no values are given -> dont filter anything
                if(textBox_endSize.Text == "" && textBox_startSize.Text == "") 
                { 
                    return files; 
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
                Console.WriteLine(unitMultiplier);
                foreach (FileInfo fileInfo in files)
                {
                    if (fileInfo.Length / unitMultiplier >= startSize && fileInfo.Length / unitMultiplier <= endSize) 
                    {
                        fileInfoList.Add(fileInfo);
                    }
                }
                return fileInfoList.ToArray();
            }
            return files;
        }

        private void showSearchResultsOnList()
        {
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

         


            //label1.Text = globalFileInfoList.Count.ToString();

           // comboBox_filterExtension.Items.Add(fileExtensions);
            dataGridView_searchResults.DataSource = fileList;
            //-----------------------------------------------------------------------------------
            // Setting the displayindex cause somehow it is random sometimes
            //-----------------------------------------------------------------------------------
            dataGridView_searchResults.Columns["Filename"].DisplayIndex = 0;
            dataGridView_searchResults.Columns["Path"].DisplayIndex = 1;
            // COUNTERS
            label_fileCount.Text = fileList.Count.ToString();
        }

        private void showSearchResultsOnDatagrid_FromPreset()
        {
            FileInfo[] files = { };
            List<ShowFiles> fileList = new List<ShowFiles>();
           
            files = globalFileInfoList.ToArray();

            //den Switch vielleicht noch auslagern
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
            //-----------------------------------------------------------------------------------
            // Setting the displayindex cause somehow it is random sometimes
            //-----------------------------------------------------------------------------------
            dataGridView_searchResults.Columns["Filename"].DisplayIndex = 0;
            dataGridView_searchResults.Columns["Path"].DisplayIndex = 1;
            // COUNTERS
            label_fileCount.Text = fileList.Count.ToString();
        }

       
    }
}
