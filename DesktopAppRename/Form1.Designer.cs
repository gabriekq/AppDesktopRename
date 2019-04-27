namespace DesktopAppRename
{
    partial class Form1
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
            this.ChooseFolder = new System.Windows.Forms.Button();
            this.helloWorldLabel = new System.Windows.Forms.Label();
            this.dataGridFiles = new System.Windows.Forms.DataGridView();
            this.FileName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NewFileName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Rename = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridFiles)).BeginInit();
            this.SuspendLayout();
            // 
            // ChooseFolder
            // 
            this.ChooseFolder.Location = new System.Drawing.Point(775, 504);
            this.ChooseFolder.Margin = new System.Windows.Forms.Padding(2);
            this.ChooseFolder.Name = "ChooseFolder";
            this.ChooseFolder.Size = new System.Drawing.Size(116, 44);
            this.ChooseFolder.TabIndex = 2;
            this.ChooseFolder.Text = "Choose Folder";
            this.ChooseFolder.UseVisualStyleBackColor = true;
            this.ChooseFolder.Click += new System.EventHandler(this.button1_Click);
            // 
            // helloWorldLabel
            // 
            this.helloWorldLabel.AutoSize = true;
            this.helloWorldLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.helloWorldLabel.Location = new System.Drawing.Point(343, 9);
            this.helloWorldLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.helloWorldLabel.Name = "helloWorldLabel";
            this.helloWorldLabel.Size = new System.Drawing.Size(147, 26);
            this.helloWorldLabel.TabIndex = 3;
            this.helloWorldLabel.Text = "Rename Files";
            // 
            // dataGridFiles
            // 
            this.dataGridFiles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridFiles.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.FileName,
            this.NewFileName});
            this.dataGridFiles.Location = new System.Drawing.Point(12, 59);
            this.dataGridFiles.Name = "dataGridFiles";
            this.dataGridFiles.Size = new System.Drawing.Size(524, 488);
            this.dataGridFiles.TabIndex = 4;
            // 
            // FileName
            // 
            this.FileName.HeaderText = "FileName";
            this.FileName.Name = "FileName";
            this.FileName.ReadOnly = true;
            this.FileName.Width = 220;
            // 
            // NewFileName
            // 
            this.NewFileName.HeaderText = "NewFileName";
            this.NewFileName.Name = "NewFileName";
            this.NewFileName.Width = 220;
            // 
            // Rename
            // 
            this.Rename.Location = new System.Drawing.Point(659, 504);
            this.Rename.Name = "Rename";
            this.Rename.Size = new System.Drawing.Size(111, 44);
            this.Rename.TabIndex = 5;
            this.Rename.Text = "Rename";
            this.Rename.UseVisualStyleBackColor = true;
            this.Rename.Click += new System.EventHandler(this.Rename_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(902, 559);
            this.Controls.Add(this.Rename);
            this.Controls.Add(this.dataGridFiles);
            this.Controls.Add(this.helloWorldLabel);
            this.Controls.Add(this.ChooseFolder);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridFiles)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button ChooseFolder;
        private System.Windows.Forms.Label helloWorldLabel;
        private System.Windows.Forms.DataGridView dataGridFiles;
        private System.Windows.Forms.DataGridViewTextBoxColumn FileName;
        private System.Windows.Forms.DataGridViewTextBoxColumn NewFileName;
        private System.Windows.Forms.Button Rename;
    }
}

