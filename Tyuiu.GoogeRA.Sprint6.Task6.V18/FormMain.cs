using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tyuiu.GoogeRA.Sprint6.Task6.V18.Lib;
using System.IO;

namespace Tyuiu.GoogeRA.Sprint6.Task6.V18
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        DataService ds = new DataService();
        string openFilePath;
        
        private void buttonDone_GRA_Click(object sender, EventArgs e)
        {
            
            string str = "n";
            textBoxRes_GRA.Text = ds.CollectTextFromFile(str, openFilePath); 
        }

        private void textBoxInPut_GRA_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxOutPut_GRA_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonOpenFile_GRA_Click(object sender, EventArgs e)
        {
            openFileDialogTask_GRA.ShowDialog();
            openFilePath = openFileDialogTask_GRA.FileName;
            textBoxLoadFromFile_GRA.Text = File.ReadAllText(openFilePath);
            groupBoxInPut_GRA.Text = groupBoxInPut_GRA.Text + " " + openFileDialogTask_GRA.FileName;
            buttonDone_GRA.Enabled = true;
        }

        private void buttonHelp_GRA_Click(object sender, EventArgs e)
        {
            FormAbout fromAbout = new FormAbout();
            fromAbout.ShowDialog();
        }

        private void groupBoxInPut_GRA_Enter(object sender, EventArgs e)
        {

        }
    }
}
