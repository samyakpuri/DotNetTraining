namespace explorer
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.splBackground = new System.Windows.Forms.SplitContainer();
            this.tvwExplorer = new System.Windows.Forms.TreeView();
            this.lvwExplorer = new System.Windows.Forms.ListView();
            this.imlIcons = new System.Windows.Forms.ImageList(this.components);
            this.txtPath = new System.Windows.Forms.TextBox();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnFwd = new System.Windows.Forms.Button();
            this.btnGo = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.splBackground)).BeginInit();
            this.splBackground.Panel1.SuspendLayout();
            this.splBackground.Panel2.SuspendLayout();
            this.splBackground.SuspendLayout();
            this.SuspendLayout();
            // 
            // splBackground
            // 
            this.splBackground.Location = new System.Drawing.Point(1, 25);
            this.splBackground.Name = "splBackground";
            // 
            // splBackground.Panel1
            // 
            this.splBackground.Panel1.Controls.Add(this.tvwExplorer);
            // 
            // splBackground.Panel2
            // 
            this.splBackground.Panel2.Controls.Add(this.lvwExplorer);
            this.splBackground.Size = new System.Drawing.Size(637, 415);
            this.splBackground.SplitterDistance = 212;
            this.splBackground.TabIndex = 0;
            // 
            // tvwExplorer
            // 
            this.tvwExplorer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tvwExplorer.Location = new System.Drawing.Point(0, 0);
            this.tvwExplorer.Name = "tvwExplorer";
            this.tvwExplorer.Size = new System.Drawing.Size(212, 415);
            this.tvwExplorer.TabIndex = 0;
            this.tvwExplorer.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.tvwExplorer_AfterSelect_1);
            // 
            // lvwExplorer
            // 
            this.lvwExplorer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvwExplorer.Location = new System.Drawing.Point(0, 0);
            this.lvwExplorer.Name = "lvwExplorer";
            this.lvwExplorer.Size = new System.Drawing.Size(421, 415);
            this.lvwExplorer.SmallImageList = this.imlIcons;
            this.lvwExplorer.TabIndex = 0;
            this.lvwExplorer.UseCompatibleStateImageBehavior = false;
            this.lvwExplorer.View = System.Windows.Forms.View.Details;
            this.lvwExplorer.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.lvwExplorer_MouseDoubleClick);
            // 
            // imlIcons
            // 
            this.imlIcons.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imlIcons.ImageStream")));
            this.imlIcons.TransparentColor = System.Drawing.Color.Transparent;
            this.imlIcons.Images.SetKeyName(0, "desktop.png");
            this.imlIcons.Images.SetKeyName(1, "drive.jpg");
            this.imlIcons.Images.SetKeyName(2, "usb.png");
            this.imlIcons.Images.SetKeyName(3, "mycomputer.png");
            this.imlIcons.Images.SetKeyName(4, "mydocuments.png");
            this.imlIcons.Images.SetKeyName(5, "folder.png");
            this.imlIcons.Images.SetKeyName(6, "document.png");
            this.imlIcons.Images.SetKeyName(7, "unknown.png");
            this.imlIcons.Images.SetKeyName(8, "cdrom.png");
            this.imlIcons.Images.SetKeyName(9, "network.png");
            this.imlIcons.Images.SetKeyName(10, "doc.png");
            this.imlIcons.Images.SetKeyName(11, "txt_rtf.png");
            this.imlIcons.Images.SetKeyName(12, "Zip_Rar.png");
            this.imlIcons.Images.SetKeyName(13, "java.png");
            this.imlIcons.Images.SetKeyName(14, "html.png");
            // 
            // txtPath
            // 
            this.txtPath.Location = new System.Drawing.Point(110, 1);
            this.txtPath.Name = "txtPath";
            this.txtPath.Size = new System.Drawing.Size(480, 20);
            this.txtPath.TabIndex = 1;
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(1, 1);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(43, 23);
            this.btnBack.TabIndex = 2;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            // 
            // btnFwd
            // 
            this.btnFwd.Location = new System.Drawing.Point(50, 1);
            this.btnFwd.Name = "btnFwd";
            this.btnFwd.Size = new System.Drawing.Size(54, 23);
            this.btnFwd.TabIndex = 3;
            this.btnFwd.Text = "Forward";
            this.btnFwd.UseVisualStyleBackColor = true;
            // 
            // btnGo
            // 
            this.btnGo.Location = new System.Drawing.Point(596, -1);
            this.btnGo.Name = "btnGo";
            this.btnGo.Size = new System.Drawing.Size(42, 23);
            this.btnGo.TabIndex = 4;
            this.btnGo.Text = "GO";
            this.btnGo.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(638, 440);
            this.Controls.Add(this.btnGo);
            this.Controls.Add(this.btnFwd);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.txtPath);
            this.Controls.Add(this.splBackground);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.splBackground.Panel1.ResumeLayout(false);
            this.splBackground.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splBackground)).EndInit();
            this.splBackground.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.SplitContainer splBackground;
        private System.Windows.Forms.ImageList imlIcons;
        private System.Windows.Forms.TreeView tvwExplorer;
        private System.Windows.Forms.ListView lvwExplorer;
        private System.Windows.Forms.TextBox txtPath;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnFwd;
        private System.Windows.Forms.Button btnGo;
    }
}

