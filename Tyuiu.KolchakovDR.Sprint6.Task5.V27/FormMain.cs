using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tyuiu.KolchakovDR.Sprint6.Task5.V27.Lib;

namespace Tyuiu.KolchakovDR.Sprint6.Task5.V27
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }
        DataService ds = new DataService();
        
        string path = @"C:\DataSprint6\InPutFileTask5V27.txt";

        private void buttonDone_KDR_Click(object sender, EventArgs e)
        {
            dataGridViewValid_KDR.ColumnCount = 2;
            dataGridViewValid_KDR.Columns[0].Width = 50;
            dataGridViewValid_KDR.Columns[1].Width = 60;

            this.chartFunc_KDR.ChartAreas[0].AxisX.Title = "Ось X";
            this.chartFunc_KDR.ChartAreas[0].AxisY.Title = "Ось Y";

            chartFunc_KDR.Series[0].Points.Clear();
            dataGridViewValid_KDR.Rows.Clear();

            double[] numsMass = new double[ds.len];

            numsMass = ds.LoadFromDataFile(path);

            for (int i = 0; i < numsMass.Length; i++)
            {
                dataGridViewValid_KDR.Rows.Add(Convert.ToString(i), Convert.ToString(numsMass[i]));
                chartFunc_KDR.Series[0].Points.AddXY(i, numsMass[i]);
            }
        }

        private void buttonHelp_KDR_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 5 выполнил студент группы ИИПб-23-2 Колчаков Даниль Рамильевич", "Сообщение", MessageBoxButtons.OK);

        }

        private void buttonOpen_KDR_Click(object sender, EventArgs e)
        {
            try
            {
                System.Diagnostics.Process txt = new System.Diagnostics.Process();
                txt.StartInfo.FileName = "notepad.exe";
                txt.StartInfo.Arguments = path;
                txt.Start();
            }
            catch
            {
                MessageBox.Show("Сбой открытия файла", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
