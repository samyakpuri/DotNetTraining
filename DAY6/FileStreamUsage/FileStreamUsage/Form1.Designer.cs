namespace FileStreamUsage
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
            this.lblPath = new System.Windows.Forms.Label();
            this.txtPath = new System.Windows.Forms.TextBox();
            this.btnBrowse = new System.Windows.Forms.Button();
            this.btnLoad = new System.Windows.Forms.Button();
            this.txtFile = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnDirectoryBrowse = new System.Windows.Forms.Button();
            this.txtDirectoryPath = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lstFile = new System.Windows.Forms.ListBox();
            this.btnMisc = new System.Windows.Forms.Button();
            this.lblFileInfo = new System.Windows.Forms.Label();
            this.btnRen = new System.Windows.Forms.Button();
            this.btnCopy = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblPath
            // 
            this.lblPath.AutoSize = true;
            this.lblPath.Location = new System.Drawing.Point(25, 25);
            this.lblPath.Name = "lblPath";
            this.lblPath.Size = new System.Drawing.Size(29, 13);
            this.lblPath.TabIndex = 0;
            this.lblPath.Text = "Path";
            // 
            // txtPath
            // 
            this.txtPath.Location = new System.Drawing.Point(60, 22);
            this.txtPath.Name = "txtPath";
            this.txtPath.Size = new System.Drawing.Size(470, 20);
            this.txtPath.TabIndex = 1;
            // 
            // btnBrowse
            // 
            this.btnBrowse.Location = new System.Drawing.Point(536, 19);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(75, 23);
            this.btnBrowse.TabIndex = 2;
            this.btnBrowse.Text = "Browse";
            this.btnBrowse.UseMnemonic = false;
            this.btnBrowse.UseVisualStyleBackColor = true;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // btnLoad
            // 
            this.btnLoad.Location = new System.Drawing.Point(617, 20);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(75, 23);
            this.btnLoad.TabIndex = 3;
            this.btnLoad.Text = "Load";
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // txtFile
            // 
            this.txtFile.Location = new System.Drawing.Point(60, 58);
            this.txtFile.Multiline = true;
            this.txtFile.Name = "txtFile";
            this.txtFile.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtFile.Size = new System.Drawing.Size(212, 384);
            this.txtFile.TabIndex = 4;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(197, 448);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 5;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnDirectoryBrowse
            // 
            this.btnDirectoryBrowse.Location = new System.Drawing.Point(536, 55);
            this.btnDirectoryBrowse.Name = "btnDirectoryBrowse";
            this.btnDirectoryBrowse.Size = new System.Drawing.Size(75, 23);
            this.btnDirectoryBrowse.TabIndex = 8;
            this.btnDirectoryBrowse.Text = "Browse";
            this.btnDirectoryBrowse.UseVisualStyleBackColor = true;
            this.btnDirectoryBrowse.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtDirectoryPath
            // 
            this.txtDirectoryPath.Location = new System.Drawing.Point(366, 58);
            this.txtDirectoryPath.Name = "txtDirectoryPath";
            this.txtDirectoryPath.Size = new System.Drawing.Size(164, 20);
            this.txtDirectoryPath.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(291, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Path Directory";
            // 
            // lstFile
            // 
            this.lstFile.FormattingEnabled = true;
            this.lstFile.HorizontalScrollbar = true;
            this.lstFile.Location = new System.Drawing.Point(294, 84);
            this.lstFile.Name = "lstFile";
            this.lstFile.Size = new System.Drawing.Size(236, 212);
            this.lstFile.TabIndex = 9;
            this.lstFile.SelectedIndexChanged += new System.EventHandler(this.lstFile_SelectedIndexChanged);
            // 
            // btnMisc
            // 
            this.btnMisc.Location = new System.Drawing.Point(536, 190);
            this.btnMisc.Name = "btnMisc";
            this.btnMisc.Size = new System.Drawing.Size(95, 23);
            this.btnMisc.TabIndex = 10;
            this.btnMisc.Text = "Load Files";
            this.btnMisc.UseVisualStyleBackColor = true;
            this.btnMisc.Click += new System.EventHandler(this.btnMisc_Click);
            // 
            // lblFileInfo
            // 
            this.lblFileInfo.AutoSize = true;
            this.lblFileInfo.Location = new System.Drawing.Point(291, 308);
            this.lblFileInfo.Name = "lblFileInfo";
            this.lblFileInfo.Size = new System.Drawing.Size(44, 13);
            this.lblFileInfo.TabIndex = 11;
            this.lblFileInfo.Text = "File Info";
            // 
            // btnRen
            // 
            this.btnRen.Location = new System.Drawing.Point(536, 219);
            this.btnRen.Name = "btnRen";
            this.btnRen.Size = new System.Drawing.Size(95, 23);
            this.btnRen.TabIndex = 12;
            this.btnRen.Text = "RenameTo2";
            this.btnRen.UseVisualStyleBackColor = true;
            this.btnRen.Click += new System.EventHandler(this.btnRen_Click);
            // 
            // btnCopy
            // 
            this.btnCopy.Location = new System.Drawing.Point(536, 248);
            this.btnCopy.Name = "btnCopy";
            this.btnCopy.Size = new System.Drawing.Size(95, 23);
            this.btnCopy.TabIndex = 13;
            this.btnCopy.Text = "CopyTo2";
            this.btnCopy.UseVisualStyleBackColor = true;
            this.btnCopy.Click += new System.EventHandler(this.btnCopy_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(699, 483);
            this.Controls.Add(this.btnCopy);
            this.Controls.Add(this.btnRen);
            this.Controls.Add(this.lblFileInfo);
            this.Controls.Add(this.btnMisc);
            this.Controls.Add(this.lstFile);
            this.Controls.Add(this.btnDirectoryBrowse);
            this.Controls.Add(this.txtDirectoryPath);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtFile);
            this.Controls.Add(this.btnLoad);
            this.Controls.Add(this.btnBrowse);
            this.Controls.Add(this.txtPath);
            this.Controls.Add(this.lblPath);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPath;
        private System.Windows.Forms.TextBox txtPath;
        private System.Windows.Forms.Button btnBrowse;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.TextBox txtFile;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnDirectoryBrowse;
        private System.Windows.Forms.TextBox txtDirectoryPath;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lstFile;
        private System.Windows.Forms.Button btnMisc;
        private System.Windows.Forms.Label lblFileInfo;
        private System.Windows.Forms.Button btnRen;
        private System.Windows.Forms.Button btnCopy;
    }
}

