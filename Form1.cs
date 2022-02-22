using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using Auram;

namespace Auram_Investigator
{
    public partial class Form1 : Form
    {
        class TreeBuilder
        {
            public int index, depth;
            public string text;
            public Dictionary<string, TreeBuilder> childs;
            public void addToTreeVeiw(TreeNode root, TreeBuilder tb)
            {
                foreach (string key in tb.childs.Keys)
                {
                    TreeNode t = root.Nodes.Add(tb.childs[key].text);
                    addToTreeVeiw(t, tb.childs[key]);
                }
            }
        }
        private string current = string.Empty;
        private string path = string.Empty;
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn(int nLeftRect, int nTopRect, int nRightRect, int nBottomRect, int nWidthEllipse, int nHeightEllipse);
        private bool mouseIsDown;
        private Point firstPoint;
        private Dictionary<string, string> data = new();
        public Form1(string file)
        {
            current = file;
            InitializeComponent();
            Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
            Exit.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, Exit.Width, Exit.Height, 5, 5));
            LoadBase();
        }
        private void LoadBase()
        {
            try
            {
                Database.Load(current);
                data = Database.data;
            }
            catch
            {
                MessageBox.Show("Failed to load database");
            }
            var list = new List<string>();
            foreach (string key in data.Keys)
            {
                if (key.StartsWith("Database/"))
                {
                    list.Add(key[9..]);
                }
                else
                {
                    list.Add(key);
                }
            }
            Viewer.Nodes.Clear();
            TreeBuilder Troot = new TreeBuilder();
            TreeBuilder son;
            Troot.depth = 0;
            Troot.index = 0;
            Troot.text = "Database";
            Troot.childs = new Dictionary<string, TreeBuilder>();
            foreach (string str in list)
            {
                string[] seperated = str.Split('/');
                son = Troot;
                int index = 0;
                for (int depth = 0; depth < seperated.Length; depth++)
                {
                    if (son.childs.ContainsKey(seperated[depth]))
                    {
                        son = son.childs[seperated[depth]];
                    }
                    else
                    {
                        son.childs.Add(seperated[depth], new TreeBuilder());
                        son = son.childs[seperated[depth]];
                        son.index = ++index;
                        son.depth = depth + 1;
                        son.text = seperated[depth];
                        son.childs = new Dictionary<string, TreeBuilder>();
                    }
                }
            }
            Viewer.Nodes.Add("Database");
            Troot.addToTreeVeiw(Viewer.Nodes[0], Troot);
        }
        private void Titlebar_MouseDown(object sender, MouseEventArgs e)
        {
            firstPoint = e.Location;
            mouseIsDown = true;
        }
        private void Titlebar_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseIsDown)
            {
                int xDiff = firstPoint.X - e.Location.X;
                int yDiff = firstPoint.Y - e.Location.Y;
                int x = Location.X - xDiff;
                int y = Location.Y - yDiff;
                Location = new Point(x, y);
            }
        }
        private void Titlebar_MouseUp(object sender, MouseEventArgs e)
        {
            mouseIsDown = false;
        }
        private void Exit_MouseEnter(object sender, EventArgs e)
        {
            Exit.BackColor = Color.Red;
        }
        private void Exit_MouseLeave(object sender, EventArgs e)
        {
            Exit.BackColor = BackColor;
        }
        private void Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void Viewer_AfterSelect(object sender, TreeViewEventArgs e)
        {
            try
            {
                path = Viewer.SelectedNode.FullPath.Replace(Path.DirectorySeparatorChar, '/');
                if (path.StartsWith("Database/"))
                {
                    path = path[9..];
                }
                TXT.Text = path + " » " + data[path];
            }
            catch
            {
                TXT.Text = "TTMC Corporation » Auram Investigator v0.1";
            }
        }
        private void OpenFile()
        {
            OpenFileDialog open = new();
            open.Title = "Open Auram File";
            open.DefaultExt = "auram";
            open.Filter = "Auram files (*.auram)|*.auram|All files (*.*)|*.*";
            if (open.ShowDialog() == DialogResult.OK)
            {
                current = open.FileName;
                LoadBase();
            }
        }
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (ModifierKeys == Keys.Control)
            {
                if (e.KeyCode == Keys.S)
                {
                    Database.Save(current);
                }
                if (e.KeyCode == Keys.O)
                {
                    OpenFile();
                }
                if (e.KeyCode == Keys.N)
                {
                    Database.Clear();
                    Viewer.Nodes.Clear();
                }
                if (e.KeyCode == Keys.W)
                {
                    Close();
                }
            }
            else if (ModifierKeys == Keys.F5)
            {
                Database.Clear();
                Viewer.Nodes.Clear();
                LoadBase();
            }
            else if (ModifierKeys == Keys.Delete)
            {
                Database.Remove(path);
                Viewer.Nodes.RemoveByKey(path);
            }
        }
    }
}
