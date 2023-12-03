using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tyuiu.KolchakovDR.Sprint6.Task2.V12.Lib;

namespace Tyuiu.KolchakovDR.Sprint6.Task2.V12
{
    public partial class FormMain : Form
    {
        public FormMain()
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
                int step = ds.GetMassFunction(startValue, stopValue).Length;
                double[] valueArray = new double[step];
                valueArray = ds.GetMassFunction(startValue, stopValue);

                this.chartFunc_KDR.Titles.Add("График функции F(x)");
                this.chartFunc_KDR.ChartAreas[0].AxisX.Title = "Ось Х";
                this.chartFunc_KDR.ChartAreas[0].AxisY.Title = "Ось Y";

                for (int i = 0; i <= step - 1; i++)
                {
                    this.dataGridViewFunc_KDR.Rows.Add(Convert.ToString(startValue), Convert.ToString(valueArray[i]));
                    this.chartFunc_KDR.Series[0].Points.AddXY(startValue, valueArray[i]);
                    startValue++;
                }
            }
            catch
            {
                MessageBox.Show("Введены неверные данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        private void buttonDone_KDR_MouseEnter(object sender, EventArgs e)
        {
            buttonDone_KDR.BackColor = Color.Gray;
        }

        private void buttonDone_KDR_MouseLeave(object sender, EventArgs e)
        {
            buttonDone_KDR.BackColor = Color.LimeGreen;
        }

        private void buttonDone_KDR_MouseDown(object sender, MouseEventArgs e)
        {
            buttonDone_KDR.BackColor = Color.LightSkyBlue;
        }

        private void buttonHelp_KDR_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 2 выполнил студент группы ИИПб-23-2 Колчаков Даниль Рамильевич", "Сообщение", MessageBoxButtons.OK);
        }
    }
    
}
