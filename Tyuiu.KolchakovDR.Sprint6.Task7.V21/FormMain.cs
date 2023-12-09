using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tyuiu.KolchakovDR.Sprint6.Task7.V21.Lib;
using System.IO;

namespace Tyuiu.KolchakovDR.Sprint6.Task7.V21
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
            openFileDialogTask_KDR.Filter = "Значения, разделённые запятыми(*.csv)|*csv|Все файлы(*.*)|*.*";
            saveFileDialogTask_KDR.Filter = "Значения, разделённые запятыми(*.csv)|*csv|Все файлы(*.*)|*.*";
        }
        static int rows;
        static int columns;
        static string openFilePath;
        DataService ds = new DataService();
        public static int[,] LoadFromFileData(string filePath)
        {
            string fileData = File.ReadAllText(filePath);
            fileData = fileData.Replace('\n', '\r');
            string[] lines = fileData.Split(new char[] { '\r' }, StringSplitOptions.RemoveEmptyEntries);

            rows = lines.Length;
            columns = lines[0].Split(';').Length;

            int[,] arrayValues = new int[rows, columns];

            for (int r = 0; r < rows; r++)
            {
                string[] line_r = lines[r].Split(';');
                for (int c = 0; c < columns; c++)
                {
                    arrayValues[r, c] = Convert.ToInt32(line_r[c]);
                }
            }
            return arrayValues;
        }

        private void buttonHelp_KDR_Click(object sender, EventArgs e)
        {
            FormAbout formAbout = new FormAbout();
            formAbout.ShowDialog();
        }
        private void buttonLoadFile_KDR_Click(object sender, EventArgs e)
        {
            int[,] arrayValues = new int[rows, columns];
            arrayValues = ds.GetMatrix(openFilePath);

            for (int r = 0; r < rows; r++)
            {
                for (int c = 0; c < columns; c++)
                {
                    dataGridViewOut_KDR.Rows[r].Cells[c].Value = arrayValues[r, c];
                }
            }

            buttonSaveFile_KDR.Enabled = true;
        }
        private void buttonOpenFile_KDR_Click(object sender, EventArgs e)
        {
            openFileDialogTask_KDR.ShowDialog();
            openFilePath = openFileDialogTask_KDR.FileName;
            int[,] arrayValues = new int[rows, columns];

            arrayValues = LoadFromFileData(openFilePath);

            dataGridViewIn_KDR.ColumnCount = columns;
            dataGridViewIn_KDR.RowCount = rows;
            dataGridViewOut_KDR.ColumnCount = columns;
            dataGridViewOut_KDR.RowCount = rows;

            for (int i = 0; i < columns; i++)
            {
                dataGridViewIn_KDR.Columns[i].Width = 25;
                dataGridViewOut_KDR.Columns[i].Width = 25;
            }

            for (int r = 0; r < rows; r++)
            {
                for (int c = 0; c < columns; c++)
                {
                    dataGridViewIn_KDR.Rows[r].Cells[c].Value = arrayValues[r, c];
                }
            }
            arrayValues = ds.GetMatrix(openFilePath);
            buttonLoadFile_KDR.Enabled = true;
        }
        private void FormMain_Load(object sender, EventArgs e)
        {
            dataGridViewIn_KDR.ColumnCount = 50;
            dataGridViewOut_KDR.ColumnCount = 50;

            dataGridViewIn_KDR.RowCount = 50;
            dataGridViewOut_KDR.RowCount = 50;

            panelLeft_KDR.Width = this.Width / 2;

            for (int i = 0; i < 50; i++)
            {
                dataGridViewIn_KDR.Columns[i].Width = 25;
                dataGridViewOut_KDR.Columns[i].Width = 25;
            }
        }

        private void buttonSaveFile_KDR_Click(object sender, EventArgs e)
        {
            saveFileDialogTask_KDR.FileName = "OutPutFileTask7.csv";
            saveFileDialogTask_KDR.InitialDirectory = Directory.GetCurrentDirectory();
            saveFileDialogTask_KDR.ShowDialog();

            string path = saveFileDialogTask_KDR.FileName;
            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            if (fileExists)
            {
                File.Delete(path);
            }
            int rows = dataGridViewOut_KDR.RowCount;
            int columns = dataGridViewOut_KDR.ColumnCount;
            string str = "";

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    if (j != columns - 1)
                    {
                        str = str + dataGridViewOut_KDR.Rows[i].Cells[j].Value + ";";
                    }
                    else
                    {
                        str = str + dataGridViewOut_KDR.Rows[i].Cells[j].Value;
                    }
                }
                File.AppendAllText(path, str + Environment.NewLine);
                str = "";
            }
        }

        private void buttonOpenFile_KDR_MouseEnter(object sender, EventArgs e)
        {
            toolTip_KDR.ToolTipTitle = "Открыть файл";
        }

        private void buttonLoadFile_KDR_MouseEnter(object sender, EventArgs e)
        {
            toolTip_KDR.ToolTipTitle = "Выполнить";
        }

        private void buttonSaveFile_KDR_MouseEnter(object sender, EventArgs e)
        {
            toolTip_KDR.ToolTipTitle = "Сохранить";
        }

        private void buttonHelp_KDR_MouseEnter(object sender, EventArgs e)
        {
            toolTip_KDR.ToolTipTitle = "Справка";
        }

    }
}
