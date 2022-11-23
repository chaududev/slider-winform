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

namespace SliderProject
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            napdsdia();
        }
        void napdsdia()
        {
            string[] drives = Environment.GetLogicalDrives();
            cbbDia.DataSource = drives;
        }
       
        private void listViewItem_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            var selectedItem = listViewItem.SelectedItems[0];
            var imagePath = selectedItem.SubItems[1].Text;
            var f = new ShowImage(imagePath);
            var rs = f.ShowDialog();
           
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
          //  listViewItem.Items[0].SubItems;
            List<string> paths = new List<string>();
            for(int i = 0; i < listViewItem.Items.Count; i++)
            {
                paths.Add(listViewItem.Items[i].SubItems[1].Text);
            }
            //string[] imagepath = listViewItem.Items;
            var f = new ShowSlider(paths);
            f.Visible = true;
            //var rs = f.ShowDialog();

        }

        public void initTree()
        {

            treeView2.Nodes.Clear();
            string drive = cbbDia.SelectedItem as String;

                DriveInfo di = new DriveInfo(drive);
                int driveImage;

                switch (di.DriveType)    //set the drive's icon
                {
                    case DriveType.CDRom:
                        driveImage = 3;
                        break;
                    case DriveType.Network:
                        driveImage = 6;
                        break;
                    case DriveType.NoRootDirectory:
                        driveImage = 8;
                        break;
                    case DriveType.Unknown:
                        driveImage = 8;
                        break;
                    default:
                        driveImage = 2;
                        break;
                }

                TreeNode node = new TreeNode(drive.Substring(0, 1), driveImage, driveImage);
                node.Tag = drive;

                if (di.IsReady == true)
                    node.Nodes.Add("...");

                treeView2.Nodes.Add(node);
                     treeView2.Nodes[0].Expand();

        }

        private void treeView2_BeforeExpand(object sender, TreeViewCancelEventArgs e)
        {
            //s  treeView2.ExpandAll();
         
            if (e.Node.Nodes.Count > 0)
            {
                if (e.Node.Nodes[0].Text == "..." && e.Node.Nodes[0].Tag == null)
                {
                    e.Node.Nodes.Clear();

                    //get the list of sub direcotires
                    string[] dirs = Directory.GetDirectories(e.Node.Tag.ToString());

                    foreach (string dir in dirs)
                    {
                        DirectoryInfo di = new DirectoryInfo(dir);
                        TreeNode node = new TreeNode(di.Name, 0, 1);

                        try
                        {
                            //keep the directory's full path in the tag for use later
                            node.Tag = dir;

                            //if the directory has sub directories add the place holder
                            if (di.GetDirectories().Count() > 0)
                                node.Nodes.Add(null, "...", 0, 0);
                        }
                        catch (UnauthorizedAccessException)
                        {
                            //display a locked folder icon
                            node.ImageIndex = 12;
                            node.SelectedImageIndex = 12;
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message, "DirectoryLister",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        finally
                        {
                            e.Node.Nodes.Add(node);
                        }
                    }
                }
            }
        }

        private void treeView2_BeforeSelect(object sender, TreeViewCancelEventArgs e)
        {
            var exts = new String[] { ".png", ".jpg", ".jpeg", ".gif" };
            //  txtThuMuc.Text = dialog.SelectedPath;
            string[] dirs = Directory.GetDirectories(e.Node.Tag.ToString());
            DirectoryInfo directory = new DirectoryInfo(e.Node.Tag.ToString());
            listViewItem.Items.Clear();
            var listFile = directory.GetFiles();
            foreach (var file in listFile)
            {
                if (exts.Contains(file.Extension.ToLower()))
                {
                    ListViewItem item = new ListViewItem(file.Name);
                    item.SubItems.Add(file.FullName);
                    item.SubItems.Add(file.Length.ToString());
                    listViewItem.Items.Add(item);
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var f = new SetUp();
            var rs = f.ShowDialog();
        }

        private void cbbDia_SelectedIndexChanged(object sender, EventArgs e)
        {
            initTree();

        }
    }
}
