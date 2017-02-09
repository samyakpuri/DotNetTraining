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

namespace explorer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        TreeNode root = new TreeNode("Desktop");
        TreeNode doc = new TreeNode("My Documents");
        TreeNode comp = new TreeNode("My Computer ");
        TreeNode drivenode;
        TreeNode filenode;
        DirectoryInfo dir;
        string path = "";

        private void PopulateTreeView()
        {
            DriveInfo[] drives = DriveInfo.GetDrives();
            foreach (DriveInfo drive in drives)
            {
               // DriveInfo driveInfo = new DriveInfo(drive);
                drivenode = new TreeNode(drive.Name);
                dir = drive.RootDirectory;
                comp.Nodes.Add(drivenode);
                switch (drive.DriveType)
                {
                    case DriveType.CDRom:
                        drivenode.ImageIndex = 8;
                        break;
                    case DriveType.Fixed:
                        drivenode.ImageIndex = 1;
                        break;
                    case DriveType.Removable:
                        drivenode.ImageIndex = 2;
                        break;
                    case DriveType.NoRootDirectory:
                        drivenode.ImageIndex = 5;
                        break;
                    case DriveType.Network:
                        drivenode.ImageIndex = 9;
                        break;
                    case DriveType.Unknown:
                        drivenode.ImageIndex = 7;
                        break;
                }
                GetFilesAndDir(drivenode, dir);
                //tvwExplorer.Nodes.Add(drive);
            }
        }

        //private void GetDirectories(DirectoryInfo[] subDirs,TreeNode nodeToAddTo)
        //{
        //    TreeNode aNode;
        //    DirectoryInfo[] subSubDirs;
        //    foreach (DirectoryInfo subDir in subDirs)
        //    {
        //        aNode = new TreeNode(subDir.Name, 0, 0);
        //        aNode.Tag = subDir;
        //        aNode.ImageKey = "folder";
        //        subSubDirs = subDir.GetDirectories();
        //        if (subSubDirs.Length != 0)
        //        {
        //            GetDirectories(subSubDirs, aNode);
        //        }
        //        nodeToAddTo.Nodes.Add(aNode);
        //    }
        //}

        private void tvwExplorer_AfterSelect(object sender, TreeViewEventArgs e)
        {
            try
            {
                lvwExplorer.Items.Clear();
                TreeNode selectednode = e.Node;
                tvwExplorer.SelectedNode.ImageIndex = e.Node.ImageIndex;
                selectednode.Expand();
                txtPath.Text = selectednode.FullPath;
                if (selectednode.Nodes.Count > 0)
                {
                    foreach (TreeNode n in selectednode.Nodes)
                    {
                        ListViewItem lst = new ListViewItem(n.Text, n.ImageIndex);
                        lst.Name = n.FullPath.Substring(13);
                        MessageBox.Show("List Node : " + lst.Name);
                        lvwExplorer.Items.Add(lst);
                    }
                }
                else
                {
                    lvwExplorer.Items.Add(selectednode.FullPath, selectednode.Text, selectednode.ImageIndex);
                }
            }
            catch (Exception e1)
            {
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lvwExplorer.LabelEdit = true;
            lvwExplorer.FullRowSelect = true;
            lvwExplorer.Sorting = SortOrder.Ascending;
            tvwExplorer.Nodes.Add(root);
            doc.ImageIndex = 5;
            comp.ImageIndex = 4;
            tvwExplorer.Nodes.Add(doc);
            tvwExplorer.Nodes.Add(comp);
            PopulateTreeView();
        }

        private void GetFilesAndDir(TreeNode node, DirectoryInfo dirname)
        {
            try
            {
                foreach (FileInfo fi in dirname.GetFiles())
                {
                    filenode = new TreeNode(fi.Name);
                    filenode.Name = fi.FullName;
                    GetFileExtension(filenode.Name);
                    node.Nodes.Add(filenode);
                }
                try
                {
                    foreach (DirectoryInfo di in dirname.GetDirectories())
                    {
                        TreeNode dirnode = new TreeNode(di.Name);
                        dirnode.ImageIndex = 2;
                        dirnode.Name = di.FullName;
                        node.Nodes.Add(dirnode);
                       // GetFilesAndDir(dirnode, di); //Recursive Functioning
                    }
                }
                catch (Exception e1)
                {
                }
            }
            catch (Exception e1)
            {
            }
        }
        
        private void GetFileExtension(string fileName)
        {
            switch (Path.GetExtension(fileName))
            {
                case ".txt":
                case ".rtf":
                    filenode.ImageIndex = 11;
                    break;
                case ".doc":
                case ".docx":
                    filenode.ImageIndex = 10;
                    break;
                case ".html":
                case ".htm":
                    filenode.ImageIndex = 14;
                    break;
                case ".rar":
                case ".zip":
                    filenode.ImageIndex = 12;
                    break;
                case ".java":
                    filenode.ImageIndex = 13;
                    break;
                default:
                    filenode.ImageIndex = 7;
                    break;
            }
        }

        private void lvwExplorer_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            for (int i = 0; i < lvwExplorer.Items.Count; i++)
            {
                if (lvwExplorer.Items[i].Selected == true)
                {
                    path = lvwExplorer.Items[i].Name;
                    txtPath.Text = path;
                    lvwExplorer.Items.Clear();
                    LoadFilesAndDir(path);
                }
            }
        }
        
        private void LoadFilesAndDir(string address)
        {
            DirectoryInfo directory = new DirectoryInfo(address);
            try
            {
                foreach (FileInfo file in directory.GetFiles())
                {
                    lvwExplorer.Items.Add(file.Name, filenode.ImageIndex);
                }
                try
                {
                    foreach (DirectoryInfo listd in directory.GetDirectories())
                    {
                        lvwExplorer.Items.Add(listd.FullName, listd.Name, 2);
                    }
                }
                catch (Exception e1)
                {
                }
            }
            catch (Exception e1)
            {
            }
        }
    }
}
