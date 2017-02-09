namespace DllDisplay
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
            this.lblTypes = new System.Windows.Forms.Label();
            this.lstTypes = new System.Windows.Forms.ListBox();
            this.lstMethods = new System.Windows.Forms.ListBox();
            this.lblMethods = new System.Windows.Forms.Label();
            this.lstProperties = new System.Windows.Forms.ListBox();
            this.lblProperties = new System.Windows.Forms.Label();
            this.lstFields = new System.Windows.Forms.ListBox();
            this.lblFields = new System.Windows.Forms.Label();
            this.lstEvents = new System.Windows.Forms.ListBox();
            this.lblEvents = new System.Windows.Forms.Label();
            this.lstConstructors = new System.Windows.Forms.ListBox();
            this.lblConstructors = new System.Windows.Forms.Label();
            this.pnlParameterControls = new System.Windows.Forms.Panel();
            this.btnInvoke = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblPath
            // 
            this.lblPath.AutoSize = true;
            this.lblPath.Location = new System.Drawing.Point(13, 13);
            this.lblPath.Name = "lblPath";
            this.lblPath.Size = new System.Drawing.Size(29, 13);
            this.lblPath.TabIndex = 0;
            this.lblPath.Text = "Path";
            // 
            // txtPath
            // 
            this.txtPath.Location = new System.Drawing.Point(54, 10);
            this.txtPath.Name = "txtPath";
            this.txtPath.Size = new System.Drawing.Size(520, 20);
            this.txtPath.TabIndex = 2;
            // 
            // btnBrowse
            // 
            this.btnBrowse.Location = new System.Drawing.Point(580, 8);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(75, 23);
            this.btnBrowse.TabIndex = 3;
            this.btnBrowse.Text = "Browse";
            this.btnBrowse.UseVisualStyleBackColor = true;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // btnLoad
            // 
            this.btnLoad.Location = new System.Drawing.Point(661, 8);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(75, 23);
            this.btnLoad.TabIndex = 4;
            this.btnLoad.Text = "Load";
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // lblTypes
            // 
            this.lblTypes.AutoSize = true;
            this.lblTypes.Location = new System.Drawing.Point(12, 50);
            this.lblTypes.Name = "lblTypes";
            this.lblTypes.Size = new System.Drawing.Size(36, 13);
            this.lblTypes.TabIndex = 5;
            this.lblTypes.Text = "Types";
            // 
            // lstTypes
            // 
            this.lstTypes.FormattingEnabled = true;
            this.lstTypes.HorizontalScrollbar = true;
            this.lstTypes.Location = new System.Drawing.Point(12, 66);
            this.lstTypes.Name = "lstTypes";
            this.lstTypes.Size = new System.Drawing.Size(106, 186);
            this.lstTypes.TabIndex = 6;
            this.lstTypes.SelectedIndexChanged += new System.EventHandler(this.lstTypes_SelectedIndexChanged);
            // 
            // lstMethods
            // 
            this.lstMethods.FormattingEnabled = true;
            this.lstMethods.HorizontalScrollbar = true;
            this.lstMethods.Location = new System.Drawing.Point(138, 66);
            this.lstMethods.Name = "lstMethods";
            this.lstMethods.Size = new System.Drawing.Size(106, 186);
            this.lstMethods.TabIndex = 8;
            this.lstMethods.SelectedIndexChanged += new System.EventHandler(this.lstMethods_SelectedIndexChanged);
            // 
            // lblMethods
            // 
            this.lblMethods.AutoSize = true;
            this.lblMethods.Location = new System.Drawing.Point(138, 50);
            this.lblMethods.Name = "lblMethods";
            this.lblMethods.Size = new System.Drawing.Size(48, 13);
            this.lblMethods.TabIndex = 7;
            this.lblMethods.Text = "Methods";
            // 
            // lstProperties
            // 
            this.lstProperties.FormattingEnabled = true;
            this.lstProperties.HorizontalScrollbar = true;
            this.lstProperties.Location = new System.Drawing.Point(263, 66);
            this.lstProperties.Name = "lstProperties";
            this.lstProperties.Size = new System.Drawing.Size(106, 186);
            this.lstProperties.TabIndex = 10;
            // 
            // lblProperties
            // 
            this.lblProperties.AutoSize = true;
            this.lblProperties.Location = new System.Drawing.Point(263, 50);
            this.lblProperties.Name = "lblProperties";
            this.lblProperties.Size = new System.Drawing.Size(54, 13);
            this.lblProperties.TabIndex = 9;
            this.lblProperties.Text = "Properties";
            // 
            // lstFields
            // 
            this.lstFields.FormattingEnabled = true;
            this.lstFields.HorizontalScrollbar = true;
            this.lstFields.Location = new System.Drawing.Point(392, 66);
            this.lstFields.Name = "lstFields";
            this.lstFields.Size = new System.Drawing.Size(106, 186);
            this.lstFields.TabIndex = 12;
            // 
            // lblFields
            // 
            this.lblFields.AutoSize = true;
            this.lblFields.Location = new System.Drawing.Point(392, 50);
            this.lblFields.Name = "lblFields";
            this.lblFields.Size = new System.Drawing.Size(34, 13);
            this.lblFields.TabIndex = 11;
            this.lblFields.Text = "Fields";
            // 
            // lstEvents
            // 
            this.lstEvents.FormattingEnabled = true;
            this.lstEvents.HorizontalScrollbar = true;
            this.lstEvents.Location = new System.Drawing.Point(517, 66);
            this.lstEvents.Name = "lstEvents";
            this.lstEvents.Size = new System.Drawing.Size(106, 186);
            this.lstEvents.TabIndex = 14;
            // 
            // lblEvents
            // 
            this.lblEvents.AutoSize = true;
            this.lblEvents.Location = new System.Drawing.Point(514, 50);
            this.lblEvents.Name = "lblEvents";
            this.lblEvents.Size = new System.Drawing.Size(40, 13);
            this.lblEvents.TabIndex = 13;
            this.lblEvents.Text = "Events";
            // 
            // lstConstructors
            // 
            this.lstConstructors.FormattingEnabled = true;
            this.lstConstructors.HorizontalScrollbar = true;
            this.lstConstructors.Location = new System.Drawing.Point(640, 66);
            this.lstConstructors.Name = "lstConstructors";
            this.lstConstructors.Size = new System.Drawing.Size(106, 186);
            this.lstConstructors.TabIndex = 16;
            // 
            // lblConstructors
            // 
            this.lblConstructors.AutoSize = true;
            this.lblConstructors.Location = new System.Drawing.Point(637, 50);
            this.lblConstructors.Name = "lblConstructors";
            this.lblConstructors.Size = new System.Drawing.Size(66, 13);
            this.lblConstructors.TabIndex = 17;
            this.lblConstructors.Text = "Constructors";
            // 
            // pnlParameterControls
            // 
            this.pnlParameterControls.Location = new System.Drawing.Point(12, 274);
            this.pnlParameterControls.Name = "pnlParameterControls";
            this.pnlParameterControls.Size = new System.Drawing.Size(357, 117);
            this.pnlParameterControls.TabIndex = 19;
            // 
            // btnInvoke
            // 
            this.btnInvoke.Location = new System.Drawing.Point(392, 318);
            this.btnInvoke.Name = "btnInvoke";
            this.btnInvoke.Size = new System.Drawing.Size(75, 23);
            this.btnInvoke.TabIndex = 20;
            this.btnInvoke.Text = "Invoke";
            this.btnInvoke.UseVisualStyleBackColor = true;
            this.btnInvoke.Click += new System.EventHandler(this.btnInvoke_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(754, 408);
            this.Controls.Add(this.btnInvoke);
            this.Controls.Add(this.pnlParameterControls);
            this.Controls.Add(this.lblConstructors);
            this.Controls.Add(this.lstConstructors);
            this.Controls.Add(this.lstEvents);
            this.Controls.Add(this.lblEvents);
            this.Controls.Add(this.lstFields);
            this.Controls.Add(this.lblFields);
            this.Controls.Add(this.lstProperties);
            this.Controls.Add(this.lblProperties);
            this.Controls.Add(this.lstMethods);
            this.Controls.Add(this.lblMethods);
            this.Controls.Add(this.lstTypes);
            this.Controls.Add(this.lblTypes);
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
        private System.Windows.Forms.Label lblTypes;
        private System.Windows.Forms.ListBox lstTypes;
        private System.Windows.Forms.ListBox lstMethods;
        private System.Windows.Forms.Label lblMethods;
        private System.Windows.Forms.ListBox lstProperties;
        private System.Windows.Forms.Label lblProperties;
        private System.Windows.Forms.ListBox lstFields;
        private System.Windows.Forms.Label lblFields;
        private System.Windows.Forms.ListBox lstEvents;
        private System.Windows.Forms.Label lblEvents;
        private System.Windows.Forms.ListBox lstConstructors;
        private System.Windows.Forms.Label lblConstructors;
        private System.Windows.Forms.Panel pnlParameterControls;
        private System.Windows.Forms.Button btnInvoke;
    }
}

