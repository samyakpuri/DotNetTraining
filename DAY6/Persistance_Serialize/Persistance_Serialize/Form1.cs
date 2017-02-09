using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace Persistance_Serialize
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSerial_Click(object sender, EventArgs e)
        {
            Person person = new Person(200000);
            person.Id = Convert.ToInt32(txtId.Text);
            person.Name = txtName.Text;
            person.Age = Convert.ToInt16(txtAge.Text);

            using(FileStream fs = new FileStream("Pesrson",FileMode.Create))
            {
                BinaryFormatter formatter = new BinaryFormatter();
                formatter.Serialize(fs, person);
            }
        }

        private void btnDeserial_Click(object sender, EventArgs e)
        {
            object obj;
            using (FileStream fs = new FileStream("Pesrson", FileMode.Open))
            {
                BinaryFormatter formatter = new BinaryFormatter();
                obj = formatter.Deserialize(fs) as Person;
            }
            txtDeserial.Text = obj.ToString();
        }

        private void btnXmlS_Click(object sender, EventArgs e)
        {
            Person person = new Person(23.555);
            person.Id = Convert.ToInt32(txtId.Text);
            person.Name = txtName.Text;
            person.Age = Convert.ToInt16(txtAge.Text);

            using (FileStream fs = new FileStream("Pesrson", FileMode.Create))
            {
                XmlSerializer formatter = new XmlSerializer(typeof(Person));
                formatter.Serialize(fs, person);
            }
        }

        private void btnXmlD_Click(object sender, EventArgs e)
        {
            object obj;
            using (FileStream fs = new FileStream("Pesrson", FileMode.Open))
            {
                XmlSerializer formatter = new XmlSerializer(typeof(Person));
                obj = formatter.Deserialize(fs) as Person;
            }
            txtDeserial.Text = obj.ToString();
        }

        private void btnCustomS_Click(object sender, EventArgs e)
        {
            Person person = new Person(200000);
            person.Id = Convert.ToInt32(txtId.Text);
            person.Name = txtName.Text;
            person.Age = Convert.ToInt16(txtAge.Text);

            using (FileStream fs = new FileStream("Pesrson", FileMode.Create))
            {
                BinaryFormatter formatter = new BinaryFormatter();
                formatter.Serialize(fs, person);
            }
        }

        private void btnCustomD_Click(object sender, EventArgs e)
        {
             object obj;
            using (FileStream fs = new FileStream("Pesrson", FileMode.Open))
            {
                BinaryFormatter formatter = new BinaryFormatter();
                obj = formatter.Deserialize(fs) as Person;
            }
            txtDeserial.Text = obj.ToString();
        }
}

}
