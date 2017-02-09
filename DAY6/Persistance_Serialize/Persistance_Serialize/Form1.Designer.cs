namespace Persistance_Serialize
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
            this.btnSerial = new System.Windows.Forms.Button();
            this.btnDeserial = new System.Windows.Forms.Button();
            this.txtId = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtAge = new System.Windows.Forms.TextBox();
            this.txtDeserial = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnXmlD = new System.Windows.Forms.Button();
            this.btnXmlS = new System.Windows.Forms.Button();
            this.btnCustomD = new System.Windows.Forms.Button();
            this.btnCustomS = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnSerial
            // 
            this.btnSerial.Location = new System.Drawing.Point(80, 12);
            this.btnSerial.Name = "btnSerial";
            this.btnSerial.Size = new System.Drawing.Size(75, 23);
            this.btnSerial.TabIndex = 0;
            this.btnSerial.Text = "Serialize";
            this.btnSerial.UseVisualStyleBackColor = true;
            this.btnSerial.Click += new System.EventHandler(this.btnSerial_Click);
            // 
            // btnDeserial
            // 
            this.btnDeserial.Location = new System.Drawing.Point(208, 12);
            this.btnDeserial.Name = "btnDeserial";
            this.btnDeserial.Size = new System.Drawing.Size(75, 23);
            this.btnDeserial.TabIndex = 1;
            this.btnDeserial.Text = "Deserialize";
            this.btnDeserial.UseVisualStyleBackColor = true;
            this.btnDeserial.Click += new System.EventHandler(this.btnDeserial_Click);
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(66, 41);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(100, 20);
            this.txtId.TabIndex = 2;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(66, 67);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(100, 20);
            this.txtName.TabIndex = 3;
            // 
            // txtAge
            // 
            this.txtAge.Location = new System.Drawing.Point(66, 93);
            this.txtAge.Name = "txtAge";
            this.txtAge.Size = new System.Drawing.Size(100, 20);
            this.txtAge.TabIndex = 4;
            // 
            // txtDeserial
            // 
            this.txtDeserial.Location = new System.Drawing.Point(181, 41);
            this.txtDeserial.Multiline = true;
            this.txtDeserial.Name = "txtDeserial";
            this.txtDeserial.ReadOnly = true;
            this.txtDeserial.Size = new System.Drawing.Size(123, 98);
            this.txtDeserial.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(16, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Id";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(26, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Age";
            // 
            // btnXmlD
            // 
            this.btnXmlD.Location = new System.Drawing.Point(187, 162);
            this.btnXmlD.Name = "btnXmlD";
            this.btnXmlD.Size = new System.Drawing.Size(96, 23);
            this.btnXmlD.TabIndex = 11;
            this.btnXmlD.Text = "XML Deserialize";
            this.btnXmlD.UseVisualStyleBackColor = true;
            this.btnXmlD.Click += new System.EventHandler(this.btnXmlD_Click);
            // 
            // btnXmlS
            // 
            this.btnXmlS.Location = new System.Drawing.Point(51, 162);
            this.btnXmlS.Name = "btnXmlS";
            this.btnXmlS.Size = new System.Drawing.Size(86, 23);
            this.btnXmlS.TabIndex = 10;
            this.btnXmlS.Text = "XMLSerialize";
            this.btnXmlS.UseVisualStyleBackColor = true;
            this.btnXmlS.Click += new System.EventHandler(this.btnXmlS_Click);
            // 
            // btnCustomD
            // 
            this.btnCustomD.Location = new System.Drawing.Point(169, 191);
            this.btnCustomD.Name = "btnCustomD";
            this.btnCustomD.Size = new System.Drawing.Size(135, 23);
            this.btnCustomD.TabIndex = 13;
            this.btnCustomD.Text = "Custom Deserialize";
            this.btnCustomD.UseVisualStyleBackColor = true;
            this.btnCustomD.Click += new System.EventHandler(this.btnCustomD_Click);
            // 
            // btnCustomS
            // 
            this.btnCustomS.Location = new System.Drawing.Point(25, 191);
            this.btnCustomS.Name = "btnCustomS";
            this.btnCustomS.Size = new System.Drawing.Size(124, 23);
            this.btnCustomS.TabIndex = 12;
            this.btnCustomS.Text = "Custom Serialize";
            this.btnCustomS.UseVisualStyleBackColor = true;
            this.btnCustomS.Click += new System.EventHandler(this.btnCustomS_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(335, 246);
            this.Controls.Add(this.btnCustomD);
            this.Controls.Add(this.btnCustomS);
            this.Controls.Add(this.btnXmlD);
            this.Controls.Add(this.btnXmlS);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtDeserial);
            this.Controls.Add(this.txtAge);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.btnDeserial);
            this.Controls.Add(this.btnSerial);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSerial;
        private System.Windows.Forms.Button btnDeserial;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtAge;
        private System.Windows.Forms.TextBox txtDeserial;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnXmlD;
        private System.Windows.Forms.Button btnXmlS;
        private System.Windows.Forms.Button btnCustomD;
        private System.Windows.Forms.Button btnCustomS;
    }
}

