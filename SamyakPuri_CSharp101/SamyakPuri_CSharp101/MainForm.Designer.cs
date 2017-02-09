namespace SamyakPuri_CSharp101
{
    partial class MainForm
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
            this.btnSavingsAccount = new System.Windows.Forms.Button();
            this.btnFDAccount = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnSavingsAccount
            // 
            this.btnSavingsAccount.Location = new System.Drawing.Point(72, 78);
            this.btnSavingsAccount.Name = "btnSavingsAccount";
            this.btnSavingsAccount.Size = new System.Drawing.Size(120, 23);
            this.btnSavingsAccount.TabIndex = 0;
            this.btnSavingsAccount.Text = "Savings Account";
            this.btnSavingsAccount.UseVisualStyleBackColor = true;
            this.btnSavingsAccount.Click += new System.EventHandler(this.btnSavingsAccount_Click);
            // 
            // btnFDAccount
            // 
            this.btnFDAccount.Location = new System.Drawing.Point(72, 118);
            this.btnFDAccount.Name = "btnFDAccount";
            this.btnFDAccount.Size = new System.Drawing.Size(120, 23);
            this.btnFDAccount.TabIndex = 1;
            this.btnFDAccount.Text = "FD Account";
            this.btnFDAccount.UseVisualStyleBackColor = true;
            this.btnFDAccount.Click += new System.EventHandler(this.btnFDAccount_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(96, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Select Account";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnFDAccount);
            this.Controls.Add(this.btnSavingsAccount);
            this.Name = "MainForm";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSavingsAccount;
        private System.Windows.Forms.Button btnFDAccount;
        private System.Windows.Forms.Label label1;

    }
}

