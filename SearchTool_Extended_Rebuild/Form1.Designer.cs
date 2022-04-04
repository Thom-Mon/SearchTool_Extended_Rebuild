namespace SearchTool_Extended_Rebuild
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.folderBrowserDialog_searchFolder = new System.Windows.Forms.FolderBrowserDialog();
            this.label_selectedFolder = new System.Windows.Forms.Label();
            this.textBox_inputSearch = new System.Windows.Forms.TextBox();
            this.button_startSearch = new System.Windows.Forms.Button();
            this.label_fileCount = new System.Windows.Forms.Label();
            this.checkBox_searchSubdirectory = new System.Windows.Forms.CheckBox();
            this.checkBox_sizeFilter = new System.Windows.Forms.CheckBox();
            this.textBox_startSize = new System.Windows.Forms.TextBox();
            this.textBox_endSize = new System.Windows.Forms.TextBox();
            this.comboBox_sizeUnit = new System.Windows.Forms.ComboBox();
            this.dataGridView_searchResults = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.openInExplorerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.filterByThisExtensionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clearAllFiltersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label_filesFoundCounter = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label_InpautSearchFile = new System.Windows.Forms.Label();
            this.backgroundWorker_searchASYNC = new System.ComponentModel.BackgroundWorker();
            this.label_errorOutput = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_searchResults)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // folderBrowserDialog_searchFolder
            // 
            this.folderBrowserDialog_searchFolder.SelectedPath = "C:\\Users\\Flodi\\Desktop\\HS_";
            // 
            // label_selectedFolder
            // 
            this.label_selectedFolder.AutoSize = true;
            this.label_selectedFolder.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_selectedFolder.Location = new System.Drawing.Point(65, 9);
            this.label_selectedFolder.Name = "label_selectedFolder";
            this.label_selectedFolder.Size = new System.Drawing.Size(17, 16);
            this.label_selectedFolder.TabIndex = 1;
            this.label_selectedFolder.Text = "...";
            // 
            // textBox_inputSearch
            // 
            this.textBox_inputSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_inputSearch.Location = new System.Drawing.Point(12, 70);
            this.textBox_inputSearch.Name = "textBox_inputSearch";
            this.textBox_inputSearch.Size = new System.Drawing.Size(125, 26);
            this.textBox_inputSearch.TabIndex = 2;
            this.textBox_inputSearch.KeyDown += new System.Windows.Forms.KeyEventHandler(this.IsEnterPressed);
            // 
            // button_startSearch
            // 
            this.button_startSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_startSearch.Location = new System.Drawing.Point(145, 70);
            this.button_startSearch.Name = "button_startSearch";
            this.button_startSearch.Size = new System.Drawing.Size(77, 26);
            this.button_startSearch.TabIndex = 3;
            this.button_startSearch.Text = "Search...";
            this.button_startSearch.UseVisualStyleBackColor = true;
            this.button_startSearch.Click += new System.EventHandler(this.button_startSearch_Click);
            // 
            // label_fileCount
            // 
            this.label_fileCount.AutoSize = true;
            this.label_fileCount.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label_fileCount.Location = new System.Drawing.Point(76, 104);
            this.label_fileCount.Name = "label_fileCount";
            this.label_fileCount.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label_fileCount.Size = new System.Drawing.Size(13, 13);
            this.label_fileCount.TabIndex = 6;
            this.label_fileCount.Text = "0";
            this.label_fileCount.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // checkBox_searchSubdirectory
            // 
            this.checkBox_searchSubdirectory.AutoSize = true;
            this.checkBox_searchSubdirectory.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox_searchSubdirectory.Location = new System.Drawing.Point(228, 57);
            this.checkBox_searchSubdirectory.Name = "checkBox_searchSubdirectory";
            this.checkBox_searchSubdirectory.Size = new System.Drawing.Size(94, 19);
            this.checkBox_searchSubdirectory.TabIndex = 7;
            this.checkBox_searchSubdirectory.Text = "Subdirectory";
            this.checkBox_searchSubdirectory.UseVisualStyleBackColor = true;
            // 
            // checkBox_sizeFilter
            // 
            this.checkBox_sizeFilter.AutoSize = true;
            this.checkBox_sizeFilter.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox_sizeFilter.Location = new System.Drawing.Point(228, 82);
            this.checkBox_sizeFilter.Name = "checkBox_sizeFilter";
            this.checkBox_sizeFilter.Size = new System.Drawing.Size(77, 19);
            this.checkBox_sizeFilter.TabIndex = 8;
            this.checkBox_sizeFilter.Text = "SizeFilter";
            this.checkBox_sizeFilter.UseVisualStyleBackColor = true;
            this.checkBox_sizeFilter.CheckedChanged += new System.EventHandler(this.checkBox_sizeFilter_CheckedChanged);
            // 
            // textBox_startSize
            // 
            this.textBox_startSize.Location = new System.Drawing.Point(361, 82);
            this.textBox_startSize.Name = "textBox_startSize";
            this.textBox_startSize.Size = new System.Drawing.Size(53, 20);
            this.textBox_startSize.TabIndex = 9;
            this.textBox_startSize.Visible = false;
            this.textBox_startSize.KeyDown += new System.Windows.Forms.KeyEventHandler(this.IsEnterPressed);
            // 
            // textBox_endSize
            // 
            this.textBox_endSize.Location = new System.Drawing.Point(420, 81);
            this.textBox_endSize.Name = "textBox_endSize";
            this.textBox_endSize.Size = new System.Drawing.Size(52, 20);
            this.textBox_endSize.TabIndex = 10;
            this.textBox_endSize.Visible = false;
            this.textBox_endSize.KeyDown += new System.Windows.Forms.KeyEventHandler(this.IsEnterPressed);
            // 
            // comboBox_sizeUnit
            // 
            this.comboBox_sizeUnit.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox_sizeUnit.FormattingEnabled = true;
            this.comboBox_sizeUnit.Items.AddRange(new object[] {
            "Byte",
            "KB",
            "MB",
            "GB"});
            this.comboBox_sizeUnit.Location = new System.Drawing.Point(306, 81);
            this.comboBox_sizeUnit.Name = "comboBox_sizeUnit";
            this.comboBox_sizeUnit.Size = new System.Drawing.Size(49, 21);
            this.comboBox_sizeUnit.TabIndex = 11;
            this.comboBox_sizeUnit.Text = "KB";
            this.comboBox_sizeUnit.SelectedIndexChanged += new System.EventHandler(this.change_FileUnit);
            // 
            // dataGridView_searchResults
            // 
            this.dataGridView_searchResults.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView_searchResults.BackgroundColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.Moccasin;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.Desktop;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView_searchResults.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridView_searchResults.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.Padding = new System.Windows.Forms.Padding(5, 0, 5, 0);
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.SeaGreen;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView_searchResults.DefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridView_searchResults.EnableHeadersVisualStyles = false;
            this.dataGridView_searchResults.Location = new System.Drawing.Point(12, 120);
            this.dataGridView_searchResults.Name = "dataGridView_searchResults";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView_searchResults.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dataGridView_searchResults.RowHeadersWidth = 72;
            this.dataGridView_searchResults.Size = new System.Drawing.Size(766, 215);
            this.dataGridView_searchResults.TabIndex = 13;
            this.dataGridView_searchResults.MouseDown += new System.Windows.Forms.MouseEventHandler(this.DataGridRightClick_MouseDown);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(28, 28);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openInExplorerToolStripMenuItem,
            this.filterByThisExtensionToolStripMenuItem,
            this.clearAllFiltersToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(193, 70);
            // 
            // openInExplorerToolStripMenuItem
            // 
            this.openInExplorerToolStripMenuItem.Name = "openInExplorerToolStripMenuItem";
            this.openInExplorerToolStripMenuItem.Size = new System.Drawing.Size(192, 22);
            this.openInExplorerToolStripMenuItem.Text = "Open in Explorer";
            this.openInExplorerToolStripMenuItem.Click += new System.EventHandler(this.openInExplorerToolStripMenuItem_Click);
            // 
            // filterByThisExtensionToolStripMenuItem
            // 
            this.filterByThisExtensionToolStripMenuItem.Name = "filterByThisExtensionToolStripMenuItem";
            this.filterByThisExtensionToolStripMenuItem.Size = new System.Drawing.Size(192, 22);
            this.filterByThisExtensionToolStripMenuItem.Text = "Filter by this extension";
            this.filterByThisExtensionToolStripMenuItem.Click += new System.EventHandler(this.filterByThisExtensionToolStripMenuItem_Click);
            // 
            // clearAllFiltersToolStripMenuItem
            // 
            this.clearAllFiltersToolStripMenuItem.Name = "clearAllFiltersToolStripMenuItem";
            this.clearAllFiltersToolStripMenuItem.Size = new System.Drawing.Size(192, 22);
            this.clearAllFiltersToolStripMenuItem.Text = "Clear all Filters";
            this.clearAllFiltersToolStripMenuItem.Click += new System.EventHandler(this.clearAllFiltersToolStripMenuItem_Click);
            // 
            // label_filesFoundCounter
            // 
            this.label_filesFoundCounter.AutoSize = true;
            this.label_filesFoundCounter.Location = new System.Drawing.Point(9, 104);
            this.label_filesFoundCounter.Name = "label_filesFoundCounter";
            this.label_filesFoundCounter.Size = new System.Drawing.Size(61, 13);
            this.label_filesFoundCounter.TabIndex = 14;
            this.label_filesFoundCounter.Text = "Files found:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Image = global::SearchTool_Extended_Rebuild.Properties.Resources.Logo_Searchfunction;
            this.pictureBox1.Location = new System.Drawing.Point(12, 9);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(46, 41);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 15;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.button_selectFolder_Click);
            // 
            // label_InpautSearchFile
            // 
            this.label_InpautSearchFile.AutoSize = true;
            this.label_InpautSearchFile.Location = new System.Drawing.Point(9, 54);
            this.label_InpautSearchFile.Name = "label_InpautSearchFile";
            this.label_InpautSearchFile.Size = new System.Drawing.Size(74, 13);
            this.label_InpautSearchFile.TabIndex = 16;
            this.label_InpautSearchFile.Text = "Search String:";
            // 
            // label_errorOutput
            // 
            this.label_errorOutput.AutoSize = true;
            this.label_errorOutput.Location = new System.Drawing.Point(65, 37);
            this.label_errorOutput.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_errorOutput.Name = "label_errorOutput";
            this.label_errorOutput.Size = new System.Drawing.Size(16, 13);
            this.label_errorOutput.TabIndex = 17;
            this.label_errorOutput.Text = "...";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(794, 350);
            this.Controls.Add(this.label_errorOutput);
            this.Controls.Add(this.label_InpautSearchFile);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label_filesFoundCounter);
            this.Controls.Add(this.dataGridView_searchResults);
            this.Controls.Add(this.comboBox_sizeUnit);
            this.Controls.Add(this.textBox_endSize);
            this.Controls.Add(this.textBox_startSize);
            this.Controls.Add(this.checkBox_sizeFilter);
            this.Controls.Add(this.checkBox_searchSubdirectory);
            this.Controls.Add(this.label_fileCount);
            this.Controls.Add(this.button_startSearch);
            this.Controls.Add(this.textBox_inputSearch);
            this.Controls.Add(this.label_selectedFolder);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(806, 378);
            this.Name = "Form1";
            this.Text = "Search for files    -    Thg Illusions 2022";
            this.SizeChanged += new System.EventHandler(this.SizeChangedAction);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_searchResults)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog_searchFolder;
        private System.Windows.Forms.Label label_selectedFolder;
        private System.Windows.Forms.TextBox textBox_inputSearch;
        private System.Windows.Forms.Button button_startSearch;
        private System.Windows.Forms.Label label_fileCount;
        private System.Windows.Forms.CheckBox checkBox_searchSubdirectory;
        private System.Windows.Forms.CheckBox checkBox_sizeFilter;
        private System.Windows.Forms.TextBox textBox_startSize;
        private System.Windows.Forms.TextBox textBox_endSize;
        private System.Windows.Forms.ComboBox comboBox_sizeUnit;
        private System.Windows.Forms.DataGridView dataGridView_searchResults;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem openInExplorerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem filterByThisExtensionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clearAllFiltersToolStripMenuItem;
        private System.Windows.Forms.Label label_filesFoundCounter;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label_InpautSearchFile;
        private System.ComponentModel.BackgroundWorker backgroundWorker_searchASYNC;
        private System.Windows.Forms.Label label_errorOutput;
    }
}

