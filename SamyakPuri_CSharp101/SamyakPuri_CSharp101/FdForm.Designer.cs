namespace SamyakPuri_CSharp101
{
    partial class FdForm
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
            this.txtAmount = new System.Windows.Forms.TextBox();
            this.btnFDDeposit = new System.Windows.Forms.Button();
            this.btnFDWithdraw = new System.Windows.Forms.Button();
            this.btnOpenMain = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtAmount
            // 
            this.txtAmount.Location = new System.Drawing.Point(81, 65);
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.Size = new System.Drawing.Size(130, 20);
            this.txtAmount.TabIndex = 6;
            // 
            // btnFDDeposit
            // 
            this.btnFDDeposit.Location = new System.Drawing.Point(170, 106);
            this.btnFDDeposit.Name = "btnFDDeposit";
            this.btnFDDeposit.Size = new System.Drawing.Size(75, 23);
            this.btnFDDeposit.TabIndex = 5;
            this.btnFDDeposit.Text = "Deposit";
            this.btnFDDeposit.UseVisualStyleBackColor = true;
            // 
            // btnFDWithdraw
            // 
            this.btnFDWithdraw.Location = new System.Drawing.Point(39, 106);
            this.btnFDWithdraw.Name = "btnFDWithdraw";
            this.btnFDWithdraw.Size = new System.Drawing.Size(75, 23);
            this.btnFDWithdraw.TabIndex = 4;
            this.btnFDWithdraw.Text = "Withdraw";
            this.btnFDWithdraw.UseVisualStyleBackColor = true;
            this.btnFDWithdraw.Click += new System.EventHandler(this.btnFDWithdraw_Click);
            // 
            // btnOpenMain
            // 
            this.btnOpenMain.Location = new System.Drawing.Point(100, 162);
            this.btnOpenMain.Name = "btnOpenMain";
            this.btnOpenMain.Size = new System.Drawing.Size(75, 23);
            this.btnOpenMain.TabIndex = 13;
            this.btnOpenMain.Text = "Main Page";
            this.btnOpenMain.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(111, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 13);
            this.label2.TabIndex = 15;
            this.label2.Text = "FD Account";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "Amount";
            // 
            // FdForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnOpenMain);
            this.Controls.Add(this.txtAmount);
            this.Controls.Add(this.btnFDDeposit);
            this.Controls.Add(this.btnFDWithdraw);
            this.Name = "FdForm";
            this.Text = "FdForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtAmount;
        private System.Windows.Forms.Button btnFDDeposit;
        private System.Windows.Forms.Button btnFDWithdraw;
        private System.Windows.Forms.Button btnOpenMain;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}