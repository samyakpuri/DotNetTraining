namespace SamyakPuri_CSharp101
{
    partial class SavingsForm
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
            this.btnSavingsDeposit = new System.Windows.Forms.Button();
            this.btnSavingsWithdraw = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnOpenMain = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtAmount
            // 
            this.txtAmount.Location = new System.Drawing.Point(80, 70);
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.Size = new System.Drawing.Size(130, 20);
            this.txtAmount.TabIndex = 9;
            // 
            // btnSavingsDeposit
            // 
            this.btnSavingsDeposit.Location = new System.Drawing.Point(164, 111);
            this.btnSavingsDeposit.Name = "btnSavingsDeposit";
            this.btnSavingsDeposit.Size = new System.Drawing.Size(75, 23);
            this.btnSavingsDeposit.TabIndex = 8;
            this.btnSavingsDeposit.Text = "Deposit";
            this.btnSavingsDeposit.UseVisualStyleBackColor = true;
            this.btnSavingsDeposit.Click += new System.EventHandler(this.btnSavingsDeposit_Click);
            // 
            // btnSavingsWithdraw
            // 
            this.btnSavingsWithdraw.Location = new System.Drawing.Point(34, 111);
            this.btnSavingsWithdraw.Name = "btnSavingsWithdraw";
            this.btnSavingsWithdraw.Size = new System.Drawing.Size(75, 23);
            this.btnSavingsWithdraw.TabIndex = 7;
            this.btnSavingsWithdraw.Text = "Withdraw";
            this.btnSavingsWithdraw.UseVisualStyleBackColor = true;
            this.btnSavingsWithdraw.Click += new System.EventHandler(this.btnSavingsWithdraw_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Amount";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(97, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Savings Account";
            // 
            // btnOpenMain
            // 
            this.btnOpenMain.Location = new System.Drawing.Point(100, 175);
            this.btnOpenMain.Name = "btnOpenMain";
            this.btnOpenMain.Size = new System.Drawing.Size(75, 23);
            this.btnOpenMain.TabIndex = 12;
            this.btnOpenMain.Text = "Main Page";
            this.btnOpenMain.UseVisualStyleBackColor = true;
            this.btnOpenMain.Click += new System.EventHandler(this.btnOpenMain_Click);
            // 
            // SavingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.btnOpenMain);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtAmount);
            this.Controls.Add(this.btnSavingsDeposit);
            this.Controls.Add(this.btnSavingsWithdraw);
            this.Name = "SavingsForm";
            this.Text = "SavingsForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtAmount;
        private System.Windows.Forms.Button btnSavingsDeposit;
        private System.Windows.Forms.Button btnSavingsWithdraw;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnOpenMain;

    }
}