namespace AdvancedCollection
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
            this.btnArrayList = new System.Windows.Forms.Button();
            this.btnListGeneric = new System.Windows.Forms.Button();
            this.btnStack = new System.Windows.Forms.Button();
            this.btnHashTable = new System.Windows.Forms.Button();
            this.btnSortedList = new System.Windows.Forms.Button();
            this.btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnArrayList
            // 
            this.btnArrayList.Location = new System.Drawing.Point(28, 12);
            this.btnArrayList.Name = "btnArrayList";
            this.btnArrayList.Size = new System.Drawing.Size(75, 23);
            this.btnArrayList.TabIndex = 0;
            this.btnArrayList.Text = "ArrayList";
            this.btnArrayList.UseVisualStyleBackColor = true;
            this.btnArrayList.Click += new System.EventHandler(this.btnArrayList_Click);
            // 
            // btnListGeneric
            // 
            this.btnListGeneric.Location = new System.Drawing.Point(28, 57);
            this.btnListGeneric.Name = "btnListGeneric";
            this.btnListGeneric.Size = new System.Drawing.Size(75, 23);
            this.btnListGeneric.TabIndex = 1;
            this.btnListGeneric.Text = "List<int>";
            this.btnListGeneric.UseVisualStyleBackColor = true;
            this.btnListGeneric.Click += new System.EventHandler(this.btnListGeneric_Click);
            // 
            // btnStack
            // 
            this.btnStack.Location = new System.Drawing.Point(132, 57);
            this.btnStack.Name = "btnStack";
            this.btnStack.Size = new System.Drawing.Size(111, 23);
            this.btnStack.TabIndex = 3;
            this.btnStack.Text = "Stack and Queue";
            this.btnStack.UseVisualStyleBackColor = true;
            // 
            // btnHashTable
            // 
            this.btnHashTable.Location = new System.Drawing.Point(153, 12);
            this.btnHashTable.Name = "btnHashTable";
            this.btnHashTable.Size = new System.Drawing.Size(75, 23);
            this.btnHashTable.TabIndex = 2;
            this.btnHashTable.Text = "HashTable";
            this.btnHashTable.UseVisualStyleBackColor = true;
            this.btnHashTable.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnSortedList
            // 
            this.btnSortedList.Location = new System.Drawing.Point(28, 103);
            this.btnSortedList.Name = "btnSortedList";
            this.btnSortedList.Size = new System.Drawing.Size(75, 23);
            this.btnSortedList.TabIndex = 4;
            this.btnSortedList.Text = "SortedList";
            this.btnSortedList.UseVisualStyleBackColor = true;
            // 
            // btn
            // 
            this.btn.Location = new System.Drawing.Point(153, 103);
            this.btn.Name = "btn";
            this.btn.Size = new System.Drawing.Size(75, 23);
            this.btn.TabIndex = 5;
            this.btn.Text = "Dictionary";
            this.btn.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.btn);
            this.Controls.Add(this.btnSortedList);
            this.Controls.Add(this.btnStack);
            this.Controls.Add(this.btnHashTable);
            this.Controls.Add(this.btnListGeneric);
            this.Controls.Add(this.btnArrayList);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnArrayList;
        private System.Windows.Forms.Button btnListGeneric;
        private System.Windows.Forms.Button btnStack;
        private System.Windows.Forms.Button btnHashTable;
        private System.Windows.Forms.Button btnSortedList;
        private System.Windows.Forms.Button btn;
    }
}

