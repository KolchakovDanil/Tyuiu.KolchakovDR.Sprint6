using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tyuiu.KolchakovDR.Sprint6.Task1.V16.Lib;

namespace Tyuiu.KolchakovDR.Sprint6.Task1.V16
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
                string strLine;
                int step = ds.GetMassFunction(startValue, stopValue).Length;
                double[] valueArray = new double[step];

                valueArray = ds.GetMassFunction(startValue, stopValue);
                textBoxRes_KDR.Text = "";
                textBoxRes_KDR.AppendText("+----------+----------+" + Environment.NewLine);
                textBoxRes_KDR.AppendText("|    X     |    f(x)  |" + Environment.NewLine);
                textBoxRes_KDR.AppendText("+----------+----------+" + Environment.NewLine);

                for (int i = 0; i <= step - 1; i++)
                {
                    strLine = String.Format("|{0,5:d}     | {1, 6:f2}   |", startValue, valueArray[i]);
                    textBoxRes_KDR.AppendText(strLine + Environment.NewLine);
                    startValue++;
                }

                textBoxRes_KDR.AppendText("+----------+----------+" + Environment.NewLine);
            }
            catch
            {
                MessageBox.Show("Введены неверные данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void textBoxVarStart_KDR_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar <= 47 || e.KeyChar >= 58) && (e.KeyChar != ',') && (e.KeyChar != 8) && (e.KeyChar == '_'))
            {
                e.Handled = true;
            }
        }

        private void buttonHelp_KDR_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 1 выполнил студент группы ИИПб-23-2 Колчаков Даниль Рамильевич", "Сообщение", MessageBoxButtons.OK);
        }
    }    
}
    

