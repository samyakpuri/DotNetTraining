namespace CSharpBasics
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
            this.btnForLoop = new System.Windows.Forms.Button();
            this.btnValueVsRef = new System.Windows.Forms.Button();
            this.Pattern = new System.Windows.Forms.Button();
            this.Fibonacci = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnForLoop
            // 
            this.btnForLoop.Location = new System.Drawing.Point(90, 92);
            this.btnForLoop.Name = "btnForLoop";
            this.btnForLoop.Size = new System.Drawing.Size(75, 23);
            this.btnForLoop.TabIndex = 0;
            this.btnForLoop.Text = "For Loop";
            this.btnForLoop.UseVisualStyleBackColor = true;
            this.btnForLoop.Click += new System.EventHandler(this.btnForLoop_Click);
            // 
            // btnValueVsRef
            // 
            this.btnValueVsRef.Location = new System.Drawing.Point(79, 121);
            this.btnValueVsRef.Name = "btnValueVsRef";
            this.btnValueVsRef.Size = new System.Drawing.Size(121, 23);
            this.btnValueVsRef.TabIndex = 1;
            this.btnValueVsRef.Text = "Value vs Ref";
            this.btnValueVsRef.UseVisualStyleBackColor = true;
            this.btnValueVsRef.Click += new System.EventHandler(this.btnValueVsRef_Click);
            // 
            // Pattern
            // 
            this.Pattern.Location = new System.Drawing.Point(79, 159);
            this.Pattern.Name = "Pattern";
            this.Pattern.Size = new System.Drawing.Size(121, 23);
            this.Pattern.TabIndex = 2;
            this.Pattern.Text = "Pattern";
            this.Pattern.UseVisualStyleBackColor = true;
            this.Pattern.Click += new System.EventHandler(this.Pattern_Click);
            // 
            // Fibonacci
            // 
            this.Fibonacci.Location = new System.Drawing.Point(79, 188);
            this.Fibonacci.Name = "Fibonacci";
            this.Fibonacci.Size = new System.Drawing.Size(121, 23);
            this.Fibonacci.TabIndex = 3;
            this.Fibonacci.Text = "Fibonacci";
            this.Fibonacci.UseVisualStyleBackColor = true;
            this.Fibonacci.Click += new System.EventHandler(this.Fibonacci_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.Fibonacci);
            this.Controls.Add(this.Pattern);
            this.Controls.Add(this.btnValueVsRef);
            this.Controls.Add(this.btnForLoop);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnForLoop;
        private System.Windows.Forms.Button btnValueVsRef;
        private System.Windows.Forms.Button Pattern;
        private System.Windows.Forms.Button Fibonacci;
    }
}

