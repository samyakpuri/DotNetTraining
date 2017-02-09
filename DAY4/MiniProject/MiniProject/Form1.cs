using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MiniProject
{
    public partial class Form1 : Form
    {
        Dictionary<ushort,Student> _studentData = new Dictionary<ushort,Student>();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string name,@class;
            ushort id;
            byte age;
            Student student;

            name = txtName.Text.Clone() as string;
            id = Convert.ToUInt16(txtId.Text);
            @class = txtClass.Text.Clone() as string;
            age = Convert.ToByte(txtAge.Text);
            student = new Student(name, id, age, @class);

            try
            {
                _studentData.Add(id, student);
            }
            catch
            {
                MessageBox.Show("Dupplicate Entry");
            }

            @class = null;
            name = null;            
            student = null;

            txtName.Text = txtName.Text.Remove(txtName.Text.Length - 1);
            txtId.Text = txtId.Text.Remove(txtId.Text.Length - 1);
            txtClass.Text = txtClass.Text.Remove(txtClass.Text.Length - 1);
            txtAge.Text = txtAge.Text.Remove(txtAge.Text.Length - 1);
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            ushort id = Convert.ToUInt16(txtSearchId.Text);
            if(_studentData.ContainsKey(id))
            {
                MessageBox.Show(_studentData[id].ToString());
            }
            else
                MessageBox.Show("Student Not Found");
        }

        private void txtId_KeyDown(object sender, KeyEventArgs e)
        {
            if (!((e.KeyValue >= 49 && e.KeyValue <= 58) || e.KeyValue == 8 || (e.KeyValue >= 97 && e.KeyValue <=105)))
            {
                e.SuppressKeyPress = true;
            }
        }

        private void txtAge_KeyDown(object sender, KeyEventArgs e)
        {
            if (!((e.KeyValue >= 49 && e.KeyValue <= 58) || e.KeyValue == 8 || (e.KeyValue >= 97 && e.KeyValue <= 105)))
            {
                e.SuppressKeyPress = true;
            }
        }
    }
}
