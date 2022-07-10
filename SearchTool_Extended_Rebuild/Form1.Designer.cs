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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
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
            this.filterByDateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.createdBeforeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.createdAfterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clearAllFiltersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.copyToClipboardToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label_filesFoundCounter = new System.Windows.Forms.Label();
            this.label_InpautSearchFile = new System.Windows.Forms.Label();
            this.backgroundWorker_searchASYNC = new System.ComponentModel.BackgroundWorker();
            this.label_errorOutput = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.checkBox_dateFilter = new System.Windows.Forms.CheckBox();
            this.dateTimePicker_filterStart = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker_filterEnd = new System.Windows.Forms.DateTimePicker();
            this.groupBox_dateOptions = new System.Windows.Forms.GroupBox();
            this.label_dateEnd = new System.Windows.Forms.Label();
            this.label_dateStart = new System.Windows.Forms.Label();
            this.label_debug = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_searchResults)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox_dateOptions.SuspendLayout();
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
            this.checkBox_searchSubdirectory.Location = new System.Drawing.Point(237, 70);
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
            this.checkBox_sizeFilter.Location = new System.Drawing.Point(237, 95);
            this.checkBox_sizeFilter.Name = "checkBox_sizeFilter";
            this.checkBox_sizeFilter.Size = new System.Drawing.Size(77, 19);
            this.checkBox_sizeFilter.TabIndex = 8;
            this.checkBox_sizeFilter.Text = "SizeFilter";
            this.checkBox_sizeFilter.UseVisualStyleBackColor = true;
            this.checkBox_sizeFilter.CheckedChanged += new System.EventHandler(this.checkBox_sizeFilter_CheckedChanged);
            // 
            // textBox_startSize
            // 
            this.textBox_startSize.Location = new System.Drawing.Point(370, 95);
            this.textBox_startSize.Name = "textBox_startSize";
            this.textBox_startSize.Size = new System.Drawing.Size(53, 20);
            this.textBox_startSize.TabIndex = 9;
            this.textBox_startSize.Visible = false;
            this.textBox_startSize.KeyDown += new System.Windows.Forms.KeyEventHandler(this.IsEnterPressedOnFilter);
            // 
            // textBox_endSize
            // 
            this.textBox_endSize.Location = new System.Drawing.Point(429, 95);
            this.textBox_endSize.Name = "textBox_endSize";
            this.textBox_endSize.Size = new System.Drawing.Size(52, 20);
            this.textBox_endSize.TabIndex = 10;
            this.textBox_endSize.Visible = false;
            this.textBox_endSize.KeyDown += new System.Windows.Forms.KeyEventHandler(this.IsEnterPressedOnFilter);
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
            this.comboBox_sizeUnit.Location = new System.Drawing.Point(315, 94);
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
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Moccasin;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.Desktop;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView_searchResults.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView_searchResults.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(5, 0, 5, 0);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.SeaGreen;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView_searchResults.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView_searchResults.EnableHeadersVisualStyles = false;
            this.dataGridView_searchResults.Location = new System.Drawing.Point(12, 120);
            this.dataGridView_searchResults.Name = "dataGridView_searchResults";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView_searchResults.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView_searchResults.RowHeadersWidth = 72;
            this.dataGridView_searchResults.Size = new System.Drawing.Size(825, 217);
            this.dataGridView_searchResults.TabIndex = 13;
            this.dataGridView_searchResults.MouseDown += new System.Windows.Forms.MouseEventHandler(this.DataGridRightClick_MouseDown);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(28, 28);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openInExplorerToolStripMenuItem,
            this.filterByThisExtensionToolStripMenuItem,
            this.filterByDateToolStripMenuItem,
            this.clearAllFiltersToolStripMenuItem,
            this.copyToClipboardToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(238, 174);
            // 
            // openInExplorerToolStripMenuItem
            // 
            this.openInExplorerToolStripMenuItem.Image = global::SearchTool_Extended_Rebuild.Properties.Resources.Directory_Logo;
            this.openInExplorerToolStripMenuItem.Name = "openInExplorerToolStripMenuItem";
            this.openInExplorerToolStripMenuItem.Size = new System.Drawing.Size(237, 34);
            this.openInExplorerToolStripMenuItem.Text = "Open in Explorer";
            this.openInExplorerToolStripMenuItem.Click += new System.EventHandler(this.openInExplorerToolStripMenuItem_Click);
            // 
            // filterByThisExtensionToolStripMenuItem
            // 
            this.filterByThisExtensionToolStripMenuItem.Image = global::SearchTool_Extended_Rebuild.Properties.Resources.File_Logo;
            this.filterByThisExtensionToolStripMenuItem.Name = "filterByThisExtensionToolStripMenuItem";
            this.filterByThisExtensionToolStripMenuItem.Size = new System.Drawing.Size(237, 34);
            this.filterByThisExtensionToolStripMenuItem.Text = "Filter by this extension";
            this.filterByThisExtensionToolStripMenuItem.Click += new System.EventHandler(this.filterByThisExtensionToolStripMenuItem_Click);
            // 
            // filterByDateToolStripMenuItem
            // 
            this.filterByDateToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.createdBeforeToolStripMenuItem,
            this.createdAfterToolStripMenuItem});
            this.filterByDateToolStripMenuItem.Image = global::SearchTool_Extended_Rebuild.Properties.Resources.Clock_Logo;
            this.filterByDateToolStripMenuItem.Name = "filterByDateToolStripMenuItem";
            this.filterByDateToolStripMenuItem.Size = new System.Drawing.Size(237, 34);
            this.filterByDateToolStripMenuItem.Text = "Filter by date";
            // 
            // createdBeforeToolStripMenuItem
            // 
            this.createdBeforeToolStripMenuItem.Name = "createdBeforeToolStripMenuItem";
            this.createdBeforeToolStripMenuItem.Size = new System.Drawing.Size(178, 24);
            this.createdBeforeToolStripMenuItem.Text = "Created before";
            this.createdBeforeToolStripMenuItem.Click += new System.EventHandler(this.createdBeforeToolStripMenuItem_Click);
            // 
            // createdAfterToolStripMenuItem
            // 
            this.createdAfterToolStripMenuItem.Name = "createdAfterToolStripMenuItem";
            this.createdAfterToolStripMenuItem.Size = new System.Drawing.Size(178, 24);
            this.createdAfterToolStripMenuItem.Text = "Created After";
            this.createdAfterToolStripMenuItem.Click += new System.EventHandler(this.createdAfterToolStripMenuItem_Click);
            // 
            // clearAllFiltersToolStripMenuItem
            // 
            this.clearAllFiltersToolStripMenuItem.Image = global::SearchTool_Extended_Rebuild.Properties.Resources.ClearAll_Logo;
            this.clearAllFiltersToolStripMenuItem.Name = "clearAllFiltersToolStripMenuItem";
            this.clearAllFiltersToolStripMenuItem.Size = new System.Drawing.Size(237, 34);
            this.clearAllFiltersToolStripMenuItem.Text = "Clear all Filters";
            this.clearAllFiltersToolStripMenuItem.Click += new System.EventHandler(this.clearAllFiltersToolStripMenuItem_Click);
            // 
            // copyToClipboardToolStripMenuItem
            // 
            this.copyToClipboardToolStripMenuItem.Name = "copyToClipboardToolStripMenuItem";
            this.copyToClipboardToolStripMenuItem.Size = new System.Drawing.Size(237, 34);
            this.copyToClipboardToolStripMenuItem.Text = "Copy to Clipboard";
            this.copyToClipboardToolStripMenuItem.Click += new System.EventHandler(this.copyToClipboardToolStripMenuItem_Click);
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
            // label_InpautSearchFile
            // 
            this.label_InpautSearchFile.AutoSize = true;
            this.label_InpautSearchFile.Location = new System.Drawing.Point(9, 54);
            this.label_InpautSearchFile.Name = "label_InpautSearchFile";
            this.label_InpautSearchFile.Size = new System.Drawing.Size(74, 13);
            this.label_InpautSearchFile.TabIndex = 16;
            this.label_InpautSearchFile.Text = "Search String:";
            // 
            // backgroundWorker_searchASYNC
            // 
            this.backgroundWorker_searchASYNC.WorkerReportsProgress = true;
            this.backgroundWorker_searchASYNC.WorkerSupportsCancellation = true;
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
            // checkBox_dateFilter
            // 
            this.checkBox_dateFilter.AutoSize = true;
            this.checkBox_dateFilter.Location = new System.Drawing.Point(487, 97);
            this.checkBox_dateFilter.Name = "checkBox_dateFilter";
            this.checkBox_dateFilter.Size = new System.Drawing.Size(71, 17);
            this.checkBox_dateFilter.TabIndex = 18;
            this.checkBox_dateFilter.Text = "DateFilter";
            this.checkBox_dateFilter.UseVisualStyleBackColor = true;
            this.checkBox_dateFilter.CheckedChanged += new System.EventHandler(this.checkBox_dateFilter_CheckedChanged);
            // 
            // dateTimePicker_filterStart
            // 
            this.dateTimePicker_filterStart.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker_filterStart.Location = new System.Drawing.Point(45, 16);
            this.dateTimePicker_filterStart.MinDate = new System.DateTime(1970, 3, 8, 0, 0, 0, 0);
            this.dateTimePicker_filterStart.Name = "dateTimePicker_filterStart";
            this.dateTimePicker_filterStart.Size = new System.Drawing.Size(94, 20);
            this.dateTimePicker_filterStart.TabIndex = 19;
            this.dateTimePicker_filterStart.KeyDown += new System.Windows.Forms.KeyEventHandler(this.IsEnterPressedOnFilter);
            // 
            // dateTimePicker_filterEnd
            // 
            this.dateTimePicker_filterEnd.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker_filterEnd.Location = new System.Drawing.Point(45, 42);
            this.dateTimePicker_filterEnd.MinDate = new System.DateTime(1970, 3, 8, 0, 0, 0, 0);
            this.dateTimePicker_filterEnd.Name = "dateTimePicker_filterEnd";
            this.dateTimePicker_filterEnd.Size = new System.Drawing.Size(94, 20);
            this.dateTimePicker_filterEnd.TabIndex = 20;
            this.dateTimePicker_filterEnd.KeyDown += new System.Windows.Forms.KeyEventHandler(this.IsEnterPressedOnFilter);
            // 
            // groupBox_dateOptions
            // 
            this.groupBox_dateOptions.Controls.Add(this.label_dateEnd);
            this.groupBox_dateOptions.Controls.Add(this.dateTimePicker_filterStart);
            this.groupBox_dateOptions.Controls.Add(this.label_dateStart);
            this.groupBox_dateOptions.Controls.Add(this.dateTimePicker_filterEnd);
            this.groupBox_dateOptions.Location = new System.Drawing.Point(552, 5);
            this.groupBox_dateOptions.Name = "groupBox_dateOptions";
            this.groupBox_dateOptions.Size = new System.Drawing.Size(291, 115);
            this.groupBox_dateOptions.TabIndex = 21;
            this.groupBox_dateOptions.TabStop = false;
            this.groupBox_dateOptions.Text = "Date-Options";
            this.groupBox_dateOptions.Visible = false;
            // 
            // label_dateEnd
            // 
            this.label_dateEnd.AutoSize = true;
            this.label_dateEnd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_dateEnd.Location = new System.Drawing.Point(6, 46);
            this.label_dateEnd.Name = "label_dateEnd";
            this.label_dateEnd.Size = new System.Drawing.Size(35, 16);
            this.label_dateEnd.TabIndex = 23;
            this.label_dateEnd.Text = "End:";
            // 
            // label_dateStart
            // 
            this.label_dateStart.AutoSize = true;
            this.label_dateStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_dateStart.Location = new System.Drawing.Point(6, 20);
            this.label_dateStart.Name = "label_dateStart";
            this.label_dateStart.Size = new System.Drawing.Size(38, 16);
            this.label_dateStart.TabIndex = 22;
            this.label_dateStart.Text = "Start:";
            // 
            // label_debug
            // 
            this.label_debug.AutoSize = true;
            this.label_debug.Location = new System.Drawing.Point(315, 9);
            this.label_debug.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_debug.Name = "label_debug";
            this.label_debug.Size = new System.Drawing.Size(35, 13);
            this.label_debug.TabIndex = 22;
            this.label_debug.Text = "label1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(847, 347);
            this.Controls.Add(this.label_debug);
            this.Controls.Add(this.checkBox_dateFilter);
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
            this.Controls.Add(this.groupBox_dateOptions);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(795, 343);
            this.Name = "Form1";
            this.Text = "Search for files    -    Thg Illusions 2022";
            this.SizeChanged += new System.EventHandler(this.SizeChangedAction);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_searchResults)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox_dateOptions.ResumeLayout(false);
            this.groupBox_dateOptions.PerformLayout();
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
        private System.Windows.Forms.ToolStripMenuItem filterByDateToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem createdBeforeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem createdAfterToolStripMenuItem;
        private System.Windows.Forms.CheckBox checkBox_dateFilter;
        private System.Windows.Forms.DateTimePicker dateTimePicker_filterStart;
        private System.Windows.Forms.DateTimePicker dateTimePicker_filterEnd;
        private System.Windows.Forms.GroupBox groupBox_dateOptions;
        private System.Windows.Forms.Label label_dateEnd;
        private System.Windows.Forms.Label label_dateStart;
        private System.Windows.Forms.Label label_debug;
        private System.Windows.Forms.ToolStripMenuItem copyToClipboardToolStripMenuItem;
    }
}

