namespace MiniProject
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
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtId = new System.Windows.Forms.TextBox();
            this.txtAge = new System.Windows.Forms.TextBox();
            this.txtClass = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtSearchId = new System.Windows.Forms.TextBox();
            this.labelId = new System.Windows.Forms.Label();
            this.labelAge = new System.Windows.Forms.Label();
            this.labelClass = new System.Windows.Forms.Label();
            this.labelName = new System.Windows.Forms.Label();
            this.labelSearchId = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(81, 25);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(100, 20);
            this.txtName.TabIndex = 0;
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(81, 51);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(100, 20);
            this.txtId.TabIndex = 1;
            this.txtId.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtId_KeyDown);
            // 
            // txtAge
            // 
            this.txtAge.Location = new System.Drawing.Point(81, 77);
            this.txtAge.Name = "txtAge";
            this.txtAge.Size = new System.Drawing.Size(100, 20);
            this.txtAge.TabIndex = 2;
            this.txtAge.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtAge_KeyDown);
            // 
            // txtClass
            // 
            this.txtClass.Location = new System.Drawing.Point(81, 103);
            this.txtClass.Name = "txtClass";
            this.txtClass.Size = new System.Drawing.Size(100, 20);
            this.txtClass.TabIndex = 3;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(90, 129);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 4;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(274, 51);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 7;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtSearchId
            // 
            this.txtSearchId.Location = new System.Drawing.Point(265, 25);
            this.txtSearchId.Name = "txtSearchId";
            this.txtSearchId.Size = new System.Drawing.Size(100, 20);
            this.txtSearchId.TabIndex = 5;
            // 
            // labelId
            // 
            this.labelId.AutoSize = true;
            this.labelId.Location = new System.Drawing.Point(40, 54);
            this.labelId.Name = "labelId";
            this.labelId.Size = new System.Drawing.Size(18, 13);
            this.labelId.TabIndex = 9;
            this.labelId.Text = "ID";
            // 
            // labelAge
            // 
            this.labelAge.AutoSize = true;
            this.labelAge.Location = new System.Drawing.Point(40, 80);
            this.labelAge.Name = "labelAge";
            this.labelAge.Size = new System.Drawing.Size(26, 13);
            this.labelAge.TabIndex = 10;
            this.labelAge.Text = "Age";
            // 
            // labelClass
            // 
            this.labelClass.AutoSize = true;
            this.labelClass.Location = new System.Drawing.Point(40, 106);
            this.labelClass.Name = "labelClass";
            this.labelClass.Size = new System.Drawing.Size(32, 13);
            this.labelClass.TabIndex = 11;
            this.labelClass.Text = "Class";
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(40, 28);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(35, 13);
            this.labelName.TabIndex = 12;
            this.labelName.Text = "Name";
            // 
            // labelSearchId
            // 
            this.labelSearchId.AutoSize = true;
            this.labelSearchId.Location = new System.Drawing.Point(224, 28);
            this.labelSearchId.Name = "labelSearchId";
            this.labelSearchId.Size = new System.Drawing.Size(16, 13);
            this.labelSearchId.TabIndex = 13;
            this.labelSearchId.Text = "Id";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(463, 284);
            this.Controls.Add(this.labelSearchId);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.labelClass);
            this.Controls.Add(this.labelAge);
            this.Controls.Add(this.labelId);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtSearchId);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtClass);
            this.Controls.Add(this.txtAge);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.txtName);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.TextBox txtAge;
        private System.Windows.Forms.TextBox txtClass;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtSearchId;
        private System.Windows.Forms.Label labelId;
        private System.Windows.Forms.Label labelAge;
        private System.Windows.Forms.Label labelClass;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label labelSearchId;
    }
}

