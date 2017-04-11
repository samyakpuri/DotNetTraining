namespace HeadStartThreads
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
            this.btnLongSynchronusTask = new System.Windows.Forms.Button();
            this.lblTime = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnLongSynchronusTask
            // 
            this.btnLongSynchronusTask.Location = new System.Drawing.Point(56, 94);
            this.btnLongSynchronusTask.Name = "btnLongSynchronusTask";
            this.btnLongSynchronusTask.Size = new System.Drawing.Size(159, 23);
            this.btnLongSynchronusTask.TabIndex = 0;
            this.btnLongSynchronusTask.Text = "Long Synchronus Task";
            this.btnLongSynchronusTask.UseVisualStyleBackColor = true;
            this.btnLongSynchronusTask.Click += new System.EventHandler(this.btnLongSynchronusTask_Click);
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Location = new System.Drawing.Point(67, 52);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(35, 13);
            this.lblTime.TabIndex = 1;
            this.lblTime.Text = "label1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.lblTime);
            this.Controls.Add(this.btnLongSynchronusTask);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnLongSynchronusTask;
        private System.Windows.Forms.Label lblTime;
    }
}

