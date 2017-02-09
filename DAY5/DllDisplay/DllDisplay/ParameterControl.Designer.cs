namespace DllDisplay
{
    partial class ParameterControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblParameterType = new System.Windows.Forms.Label();
            this.lblParameterName = new System.Windows.Forms.Label();
            this.txtParameterValue = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblParameterType
            // 
            this.lblParameterType.AutoSize = true;
            this.lblParameterType.Location = new System.Drawing.Point(76, 5);
            this.lblParameterType.Name = "lblParameterType";
            this.lblParameterType.Size = new System.Drawing.Size(35, 13);
            this.lblParameterType.TabIndex = 0;
            this.lblParameterType.Text = "label1";
            // 
            // lblParameterName
            // 
            this.lblParameterName.AutoSize = true;
            this.lblParameterName.Location = new System.Drawing.Point(3, 5);
            this.lblParameterName.Name = "lblParameterName";
            this.lblParameterName.Size = new System.Drawing.Size(35, 13);
            this.lblParameterName.TabIndex = 0;
            this.lblParameterName.Text = "label1";
            // 
            // txtParameterValue
            // 
            this.txtParameterValue.Location = new System.Drawing.Point(157, 3);
            this.txtParameterValue.Name = "txtParameterValue";
            this.txtParameterValue.Size = new System.Drawing.Size(100, 20);
            this.txtParameterValue.TabIndex = 1;
            // 
            // ParameterControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.txtParameterValue);
            this.Controls.Add(this.lblParameterName);
            this.Controls.Add(this.lblParameterType);
            this.Name = "ParameterControl";
            this.Size = new System.Drawing.Size(292, 26);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblParameterType;
        private System.Windows.Forms.Label lblParameterName;
        private System.Windows.Forms.TextBox txtParameterValue;
    }
}
