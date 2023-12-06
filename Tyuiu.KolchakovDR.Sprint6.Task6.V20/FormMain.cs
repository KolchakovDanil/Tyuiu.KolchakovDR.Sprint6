using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tyuiu.KolchakovDR.Sprint6.Task6.V20.Lib;
using System.IO;

namespace Tyuiu.KolchakovDR.Sprint6.Task6.V20
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }
        string openFilePath;
        DataService ds = new DataService();

        private void buttonLoadFile_KDR_Click(object sender, EventArgs e)
        {
            textBoxOut_KDR.Text = ds.CollectTextFromFile(openFilePath);
        }
        private void buttonOpenFile_KDR_Click(object sender, EventArgs e)
        {
            openFileDialogTask_KDR.ShowDialog();
            openFilePath = openFileDialogTask_KDR.FileName;


            textBoxIn_KDR.Text = File.ReadAllText(openFilePath);
            groupBoxInputData_KDR.Text = textBoxOut_KDR.Text + " " + openFileDialogTask_KDR.FileName;
            buttonLoadFile_KDR.Enabled = true;
        }

        private void buttonHelp_KDR_Click(object sender, EventArgs e)
        {
            FormAbout formAbout = new FormAbout();
            formAbout.ShowDialog();
        }
    }
}
