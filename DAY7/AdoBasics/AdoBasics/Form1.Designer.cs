namespace AdoBasics
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
            this.btnConnected = new System.Windows.Forms.Button();
            this.btnDeConnected = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnInsert = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnDatasetFromCode = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnGridSelDel = new System.Windows.Forms.Button();
            this.btnGridUpdate = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnConnected
            // 
            this.btnConnected.Location = new System.Drawing.Point(4, 13);
            this.btnConnected.Name = "btnConnected";
            this.btnConnected.Size = new System.Drawing.Size(75, 23);
            this.btnConnected.TabIndex = 0;
            this.btnConnected.Text = "Connected";
            this.btnConnected.UseVisualStyleBackColor = true;
            this.btnConnected.Click += new System.EventHandler(this.btnConnected_Click);
            // 
            // btnDeConnected
            // 
            this.btnDeConnected.Location = new System.Drawing.Point(85, 13);
            this.btnDeConnected.Name = "btnDeConnected";
            this.btnDeConnected.Size = new System.Drawing.Size(89, 23);
            this.btnDeConnected.TabIndex = 1;
            this.btnDeConnected.Text = "De Connected";
            this.btnDeConnected.UseVisualStyleBackColor = true;
            this.btnDeConnected.Click += new System.EventHandler(this.btnDeConnected_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 43);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(405, 257);
            this.dataGridView1.TabIndex = 2;
            // 
            // btnInsert
            // 
            this.btnInsert.Location = new System.Drawing.Point(180, 13);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(75, 24);
            this.btnInsert.TabIndex = 3;
            this.btnInsert.Text = "Insert";
            this.btnInsert.UseVisualStyleBackColor = true;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(261, 13);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 24);
            this.btnDelete.TabIndex = 4;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnDatasetFromCode
            // 
            this.btnDatasetFromCode.Location = new System.Drawing.Point(423, 12);
            this.btnDatasetFromCode.Name = "btnDatasetFromCode";
            this.btnDatasetFromCode.Size = new System.Drawing.Size(108, 24);
            this.btnDatasetFromCode.TabIndex = 5;
            this.btnDatasetFromCode.Text = "Dataset From Code";
            this.btnDatasetFromCode.UseVisualStyleBackColor = true;
            this.btnDatasetFromCode.Click += new System.EventHandler(this.btnDatasetFromCode_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(342, 12);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 24);
            this.btnUpdate.TabIndex = 6;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnGridSelDel
            // 
            this.btnGridSelDel.Location = new System.Drawing.Point(423, 54);
            this.btnGridSelDel.Name = "btnGridSelDel";
            this.btnGridSelDel.Size = new System.Drawing.Size(108, 23);
            this.btnGridSelDel.TabIndex = 7;
            this.btnGridSelDel.Text = "Delete Via Grid Sel";
            this.btnGridSelDel.UseVisualStyleBackColor = true;
            this.btnGridSelDel.Click += new System.EventHandler(this.btnGridSelDel_Click);
            // 
            // btnGridUpdate
            // 
            this.btnGridUpdate.Location = new System.Drawing.Point(423, 94);
            this.btnGridUpdate.Name = "btnGridUpdate";
            this.btnGridUpdate.Size = new System.Drawing.Size(108, 23);
            this.btnGridUpdate.TabIndex = 8;
            this.btnGridUpdate.Text = "Update via Grid";
            this.btnGridUpdate.UseVisualStyleBackColor = true;
            this.btnGridUpdate.Click += new System.EventHandler(this.btnGridUpdate_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(575, 391);
            this.Controls.Add(this.btnGridUpdate);
            this.Controls.Add(this.btnGridSelDel);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnDatasetFromCode);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnInsert);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnDeConnected);
            this.Controls.Add(this.btnConnected);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnConnected;
        private System.Windows.Forms.Button btnDeConnected;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnInsert;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnDatasetFromCode;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnGridSelDel;
        private System.Windows.Forms.Button btnGridUpdate;
    }
}

