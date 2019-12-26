using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Clonepad
{
    public partial class Clonepad : Form
    {
        private Operations operations;
        public Clonepad()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            operations = new Operations();
        }

        private void fileExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void fileSave_Click(object sender, EventArgs e)
        {
            SaveFileDialog svd = new SaveFileDialog();
            svd.Filter = "Text file|*.txt";
            svd.Title = "Save file";
            svd.ShowDialog();
            if(svd.FileName != "")
            {
                StreamWriter writer = new StreamWriter(svd.OpenFile());
                switch (svd.FilterIndex)
                {
                    case 1:
                        writer.Write(textBox.Text);
                        break;
                }
                writer.Dispose();
                writer.Close();
            }
        }

        private void fileOpen_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Text file|*txt";
            ofd.Title = "Open file";
            ofd.ShowDialog();
            if(ofd.FileName != "")
            {
                StreamReader sr = new StreamReader(ofd.OpenFile());
                string text = sr.ReadToEnd();
                textBox.Text = text;
                sr.Dispose();
                sr.Close();
            }
        }

        private void helpAbout_click(object sender, EventArgs e)
        {
            About about = new About();
            about.Show();
        }

        private void editCopy_Click(object sender, EventArgs e)
        {
            operations.copy(textBox.SelectedText);
        }

        private void editPaste_Click(object sender, EventArgs e)
        {
            textBox.Text += operations.paste();
        }
    }
}
