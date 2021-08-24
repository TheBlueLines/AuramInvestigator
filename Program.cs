using System;
using System.IO;
using System.Windows.Forms;

namespace Auram_Investigator
{
    static class Program
    {
        [STAThread]
        static void Main(string[] args)
        {
            string file = string.Empty;
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            if (args.Length == 0)
            {
                OpenFileDialog open = new();
                open.Title = "Open Auram File";
                open.DefaultExt = "auram";
                open.Filter = "Auram files (*.auram)|*.auram|All files (*.*)|*.*";
                if (open.ShowDialog() == DialogResult.OK)
                {
                    if (File.Exists(open.FileName))
                    {
                        file = open.FileName;
                    }
                    else
                    {
                        MessageBox.Show("The file does not exist");
                    }
                }
            }
            else
            {
                if (File.Exists(args[0]))
                {
                    file = args[0];
                }
                else
                {
                    MessageBox.Show("The file does not exist");
                }
            }
            Application.Run(new Form1(file));
        }
    }
}
