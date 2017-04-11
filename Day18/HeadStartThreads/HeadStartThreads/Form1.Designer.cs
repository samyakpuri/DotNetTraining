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
            this.btnTask = new System.Windows.Forms.Button();
            this.btnParallel = new System.Windows.Forms.Button();
            this.btnCancelTask = new System.Windows.Forms.Button();
            this.btnDynamicObject = new System.Windows.Forms.Button();
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
            // btnTask
            // 
            this.btnTask.Location = new System.Drawing.Point(90, 123);
            this.btnTask.Name = "btnTask";
            this.btnTask.Size = new System.Drawing.Size(75, 23);
            this.btnTask.TabIndex = 2;
            this.btnTask.Text = "Task";
            this.btnTask.UseVisualStyleBackColor = true;
            this.btnTask.Click += new System.EventHandler(this.btnTask_Click);
            // 
            // btnParallel
            // 
            this.btnParallel.Location = new System.Drawing.Point(40, 161);
            this.btnParallel.Name = "btnParallel";
            this.btnParallel.Size = new System.Drawing.Size(75, 23);
            this.btnParallel.TabIndex = 3;
            this.btnParallel.Text = "Parallel";
            this.btnParallel.UseVisualStyleBackColor = true;
            this.btnParallel.Click += new System.EventHandler(this.btnParallel_Click);
            // 
            // btnCancelTask
            // 
            this.btnCancelTask.Location = new System.Drawing.Point(137, 161);
            this.btnCancelTask.Name = "btnCancelTask";
            this.btnCancelTask.Size = new System.Drawing.Size(88, 23);
            this.btnCancelTask.TabIndex = 4;
            this.btnCancelTask.Text = "Cancel Task";
            this.btnCancelTask.UseVisualStyleBackColor = true;
            this.btnCancelTask.Click += new System.EventHandler(this.btnCancelTask_Click);
            // 
            // btnDynamicObject
            // 
            this.btnDynamicObject.Location = new System.Drawing.Point(90, 190);
            this.btnDynamicObject.Name = "btnDynamicObject";
            this.btnDynamicObject.Size = new System.Drawing.Size(88, 23);
            this.btnDynamicObject.TabIndex = 5;
            this.btnDynamicObject.Text = "Dynamic Object";
            this.btnDynamicObject.UseVisualStyleBackColor = true;
            this.btnDynamicObject.Click += new System.EventHandler(this.btnDynamicObject_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.btnDynamicObject);
            this.Controls.Add(this.btnCancelTask);
            this.Controls.Add(this.btnParallel);
            this.Controls.Add(this.btnTask);
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
        private System.Windows.Forms.Button btnTask;
        private System.Windows.Forms.Button btnParallel;
        private System.Windows.Forms.Button btnCancelTask;
        private System.Windows.Forms.Button btnDynamicObject;
    }
}

