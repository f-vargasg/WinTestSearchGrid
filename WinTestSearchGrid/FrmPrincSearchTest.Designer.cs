namespace WinTestSearchGrid
{
    partial class FrmPrincTestSearch
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dgrData = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSearchBox = new System.Windows.Forms.TextBox();
            this.cmbSearchType = new System.Windows.Forms.ComboBox();
            this.butSearch = new System.Windows.Forms.Button();
            this.butClearFilters = new System.Windows.Forms.Button();
            this.txtImportExcelPath = new System.Windows.Forms.TextBox();
            this.butImportFile = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.lblRowCount = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.butOpenFile = new System.Windows.Forms.Button();
            this.butTestDataSet = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgrData)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgrData
            // 
            this.dgrData.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgrData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgrData.Location = new System.Drawing.Point(0, 65);
            this.dgrData.Name = "dgrData";
            this.dgrData.Size = new System.Drawing.Size(1202, 520);
            this.dgrData.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Serach by:";
            // 
            // txtSearchBox
            // 
            this.txtSearchBox.Location = new System.Drawing.Point(351, 18);
            this.txtSearchBox.Name = "txtSearchBox";
            this.txtSearchBox.Size = new System.Drawing.Size(268, 26);
            this.txtSearchBox.TabIndex = 2;
            // 
            // cmbSearchType
            // 
            this.cmbSearchType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSearchType.FormattingEnabled = true;
            this.cmbSearchType.Location = new System.Drawing.Point(102, 18);
            this.cmbSearchType.Name = "cmbSearchType";
            this.cmbSearchType.Size = new System.Drawing.Size(206, 28);
            this.cmbSearchType.TabIndex = 3;
            // 
            // butSearch
            // 
            this.butSearch.Location = new System.Drawing.Point(694, 21);
            this.butSearch.Name = "butSearch";
            this.butSearch.Size = new System.Drawing.Size(96, 25);
            this.butSearch.TabIndex = 4;
            this.butSearch.Text = "Search";
            this.butSearch.UseVisualStyleBackColor = true;
            this.butSearch.Click += new System.EventHandler(this.butSearch_Click);
            // 
            // butClearFilters
            // 
            this.butClearFilters.Location = new System.Drawing.Point(815, 22);
            this.butClearFilters.Name = "butClearFilters";
            this.butClearFilters.Size = new System.Drawing.Size(96, 25);
            this.butClearFilters.TabIndex = 5;
            this.butClearFilters.Text = "Show All";
            this.butClearFilters.UseVisualStyleBackColor = true;
            this.butClearFilters.Click += new System.EventHandler(this.butClearFilters_Click);
            // 
            // txtImportExcelPath
            // 
            this.txtImportExcelPath.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtImportExcelPath.Location = new System.Drawing.Point(7, 20);
            this.txtImportExcelPath.Name = "txtImportExcelPath";
            this.txtImportExcelPath.Size = new System.Drawing.Size(369, 26);
            this.txtImportExcelPath.TabIndex = 6;
            // 
            // butImportFile
            // 
            this.butImportFile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.butImportFile.Location = new System.Drawing.Point(493, 20);
            this.butImportFile.Name = "butImportFile";
            this.butImportFile.Size = new System.Drawing.Size(234, 26);
            this.butImportFile.TabIndex = 8;
            this.butImportFile.Text = "Import Records File";
            this.butImportFile.UseVisualStyleBackColor = true;
            this.butImportFile.Click += new System.EventHandler(this.butImportFile_Click);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(782, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(158, 20);
            this.label2.TabIndex = 9;
            this.label2.Text = "Total No. of Records:";
            // 
            // lblRowCount
            // 
            this.lblRowCount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblRowCount.AutoSize = true;
            this.lblRowCount.Location = new System.Drawing.Point(976, 20);
            this.lblRowCount.Name = "lblRowCount";
            this.lblRowCount.Size = new System.Drawing.Size(21, 20);
            this.lblRowCount.TabIndex = 10;
            this.lblRowCount.Text = "...";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.butOpenFile);
            this.panel1.Controls.Add(this.lblRowCount);
            this.panel1.Controls.Add(this.txtImportExcelPath);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.butImportFile);
            this.panel1.Location = new System.Drawing.Point(0, 591);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1202, 65);
            this.panel1.TabIndex = 11;
            // 
            // butOpenFile
            // 
            this.butOpenFile.Location = new System.Drawing.Point(382, 19);
            this.butOpenFile.Name = "butOpenFile";
            this.butOpenFile.Size = new System.Drawing.Size(61, 28);
            this.butOpenFile.TabIndex = 12;
            this.butOpenFile.Text = "...";
            this.butOpenFile.UseVisualStyleBackColor = true;
            this.butOpenFile.Click += new System.EventHandler(this.butOpenFile_Click);
            // 
            // butTestDataSet
            // 
            this.butTestDataSet.Location = new System.Drawing.Point(980, 22);
            this.butTestDataSet.Name = "butTestDataSet";
            this.butTestDataSet.Size = new System.Drawing.Size(168, 25);
            this.butTestDataSet.TabIndex = 12;
            this.butTestDataSet.Text = "Test Dataset";
            this.butTestDataSet.UseVisualStyleBackColor = true;
            this.butTestDataSet.Click += new System.EventHandler(this.buTestDataset_Click);
            // 
            // FrmPrincTestSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 692);
            this.Controls.Add(this.butTestDataSet);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.butClearFilters);
            this.Controls.Add(this.butSearch);
            this.Controls.Add(this.cmbSearchType);
            this.Controls.Add(this.txtSearchBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgrData);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FrmPrincTestSearch";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dinamic Search";
            ((System.ComponentModel.ISupportInitialize)(this.dgrData)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgrData;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSearchBox;
        private System.Windows.Forms.ComboBox cmbSearchType;
        private System.Windows.Forms.Button butSearch;
        private System.Windows.Forms.Button butClearFilters;
        private System.Windows.Forms.TextBox txtImportExcelPath;
        private System.Windows.Forms.Button butImportFile;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblRowCount;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button butOpenFile;
        private System.Windows.Forms.Button butTestDataSet;
    }
}

