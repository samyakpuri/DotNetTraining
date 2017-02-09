using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FileStreamUsage
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            FileDialog fileDialog = new OpenFileDialog();
            if(fileDialog.ShowDialog() == DialogResult.OK)
            {
                txtPath.Text = fileDialog.FileName;
            }
        }

        #region FullFileRead
        //private void btnLoad_Click(object sender, EventArgs e)
        //{
        //    using (FileStream fileStream = new FileStream(txtPath.Text, FileMode.Open))
        //    {
        //        byte[] bytes = new byte[1024];
        //        fileStream.Read(bytes, 0, bytes.Count());
        //        ASCIIEncoding encoder = new ASCIIEncoding();
        //        String file = encoder.GetString(bytes);
        //        txtFile.Text = file;
        //    }
        //} 
        #endregion

        #region ReadByte
        //private void btnLoad_Click(object sender, EventArgs e)
        //{
        //    using (FileStream fileStream = new FileStream(txtPath.Text, FileMode.Open))
        //    {
        //        int b;
        //        while((b = fileStream.ReadByte()) !=-1)
        //            txtFile.Text += Convert.ToChar(b);
        //    }
        //} 
        #endregion

        #region ReadByteViaRead
        //private void btnLoad_Click(object sender, EventArgs e)
        //{
        //    using (FileStream fileStream = new FileStream(txtPath.Text, FileMode.Open))
        //    {
        //        byte[] bytes = new byte[1024];
        //        while (fileStream.Read(bytes, 0, bytes.Count()) != 0)
        //        {
        //            ASCIIEncoding encoder = new ASCIIEncoding();
        //            String file = encoder.GetString(bytes);
        //            txtFile.Text += file;
        //        }
        //    }
        //} 
        #endregion

        #region ReadAsync
        private async void btnLoad_Click(object sender, EventArgs e)
        {
            using (FileStream fileStream = new FileStream(txtPath.Text,FileMode.Open))
            {
                byte[] bytes = new byte[1024];
                while (await fileStream.ReadAsync(bytes, 0, bytes.Count()) != 0)
                {
                    ASCIIEncoding encoder = new ASCIIEncoding();
                    string text = encoder.GetString(bytes);
                    txtFile.Text += text;
                }
            }
        } 
        #endregion


        
        private void btnSave_Click(object sender, EventArgs e)
        {
            using (FileStream fileStream = new FileStream(txtPath.Text, FileMode.Truncate))
            {
                ASCIIEncoding encoder = new ASCIIEncoding();
                byte[] bytes = encoder.GetBytes(txtFile.Text);
                fileStream.Write(bytes, 0, bytes.Count());
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderDialog = new FolderBrowserDialog();
            if(folderDialog.ShowDialog() == DialogResult.OK)
            {
                txtDirectoryPath.Text = folderDialog.SelectedPath;
            }
        }

        private void btnMisc_Click(object sender, EventArgs e)
        {

            LoadFiles();
            
        }

        private void LoadFiles()
        {
            lstFile.Items.Clear();
            String[] directories = Directory.GetDirectories(txtDirectoryPath.Text);
            foreach (String directory in directories)
            {
                lstFile.Items.Add(directory);
            }
            lstFile.Items.Add("---------");
            String[] files = Directory.GetFiles(txtDirectoryPath.Text);
            foreach (String file in files)
            {
                lstFile.Items.Add(file);
            }
        }

        private void lstFile_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstFile.SelectedIndex == -1) return;

            FileInfo file = new FileInfo(lstFile.SelectedItem.ToString());
            lblFileInfo.Text = String.Format("LastAccessTime: {0} -- LastWriteTime: {1}", file.LastAccessTime, file.LastWriteTime);

        }

        private void btnRen_Click(object sender, EventArgs e)
        {
            if (lstFile.SelectedIndex == -1) return;
            string fileName = lstFile.SelectedItem.ToString();
            String path = Path.GetDirectoryName(fileName);
            String fileExt = Path.GetExtension(fileName);
            String fileName2 = Path.GetFileNameWithoutExtension(fileName);
            FileInfo file = new FileInfo(fileName);
            String newPath = Path.Combine(path, fileName2 + "2" + fileExt);
            file.MoveTo(newPath);
            LoadFiles();
         }

        private void btnCopy_Click(object sender, EventArgs e)
        {
            if (lstFile.SelectedIndex == -1) return;
            string fileName = lstFile.SelectedItem.ToString();
            String path = Path.GetDirectoryName(fileName);
            String fileExt = Path.GetExtension(fileName);
            String fileName2 = Path.GetFileNameWithoutExtension(fileName);
            FileInfo file = new FileInfo(fileName);
            String newPath = Path.Combine(path, fileName2 + "2" + fileExt);
            file.CopyTo(newPath);
            LoadFiles();
        }

        #region StreamReaderWriter
        //private void btnLoad_Click(object sender, EventArgs e)
        //{
        //    using (StreamReader reader = new StreamReader(txtPath.Text))
        //    {
        //        txtFile.Text = reader.ReadToEnd();
        //    }
        //}

        //private void btnSave_Click(object sender, EventArgs e)
        //{
        //    using (StreamWriter writer = new StreamWriter(txtPath.Text))
        //    {
        //        writer.Write(txtFile.Text);
        //    }
        //} 
        #endregion
    }
}
