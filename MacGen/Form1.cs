using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MacGen
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog theDialog = new OpenFileDialog();
            theDialog.Title = "Open Excel File";
            theDialog.Filter = "XLSX files|*.xlsx";
            theDialog.InitialDirectory = System.IO.Path.GetDirectoryName(Application.ExecutablePath); ;
            if (theDialog.ShowDialog() == DialogResult.OK)
            {
                textBoxFilePath.Text = theDialog.FileName.ToString();
                if (textBoxDirectory.Text == "")
                    textBoxDirectory.Text = Path.GetDirectoryName(textBoxFilePath.Text).ToString();
            }

        }

        private void buttonDirectory_Click(object sender, EventArgs e)
        {
            using (var folderDialog = new FolderBrowserDialog())
            {
                if (folderDialog.ShowDialog() == DialogResult.OK)
                {
                    textBoxDirectory.Text = folderDialog.SelectedPath;
                }
            }
        }


        private void buttonGen_Click(object sender, EventArgs e)
        {

        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }
    }
}
