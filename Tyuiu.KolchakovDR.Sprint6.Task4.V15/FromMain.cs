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
using Tyuiu.KolchakovDR.Sprint6.Task4.V15.Lib;

namespace Tyuiu.KolchakovDR.Sprint6.Task4.V15
{
    public partial class FromMain : Form
    {
        public FromMain()
        {
            InitializeComponent();
        }
        DataService ds = new DataService();
        private void buttonDone_KDR_Click(object sender, EventArgs e)
        {
            try
            {
                int startValue = Convert.ToInt32(textBoxVarStart_KDR.Text);
                int stopValue = Convert.ToInt32(textBoxVarStop_KDR.Text);

                int len = ds.GetMassFunction(startValue, stopValue).Length;

                double[] arrResult = new double[len];

                arrResult = ds.GetMassFunction(startValue, stopValue);

                this.chartFunc_KDR.ChartAreas[0].AxisX.Title = "Ось X";
                this.chartFunc_KDR.ChartAreas[0].AxisY.Title = "Ось Y";

                textBoxRes_KDR.Text = "";
                chartFunc_KDR.Series[0].Points.Clear();

                for (int i = 0; i < len; i++)
                {
                    this.chartFunc_KDR.Series[0].Points.AddXY(startValue, arrResult[i]);
                    textBoxRes_KDR.AppendText(arrResult[i] + Environment.NewLine);
                    startValue++;
                }
            }
            catch
            {
                MessageBox.Show("Введены неверные данные", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonHelp_KDR_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 4 выполнил студент группы ИИПб-23-2 Колчаков Даниль Рамильевич", "Сообщение", MessageBoxButtons.OK);
        }

        private void buttonSave_KDR_Click(object sender, EventArgs e)
        {
            try
            {
                string path = $@"{Directory.GetCurrentDirectory()}\OutPutFileTask4V15.txt";
                File.WriteAllText(path, textBoxRes_KDR.Text);

                DialogResult dialogResult = MessageBox.Show("Файл " + path + " сохранен успешно!\n Открыть его в блокноте?", "Сообщение", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

                if (dialogResult == DialogResult.Yes)
                {
                    System.Diagnostics.Process txt = new System.Diagnostics.Process();
                    txt.StartInfo.FileName = "notepad.exe";
                    txt.StartInfo.Arguments = path;
                    txt.Start();
                }
            }
            catch
            {
                MessageBox.Show("Сбой сохранения файла", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
    
}
