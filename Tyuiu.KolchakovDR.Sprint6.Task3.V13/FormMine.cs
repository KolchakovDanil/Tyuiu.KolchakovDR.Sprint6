using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tyuiu.KolchakovDR.Sprint6.Task3.V13.Lib;

namespace Tyuiu.KolchakovDR.Sprint6.Task3.V13
{
    public partial class FormMine : Form
    {
        public FormMine()
        {
            InitializeComponent();
        }
        DataService ds = new DataService();
        int[,] matrix = new int[5, 5] {
                {  -7,  34, -2, 25,   5 },
                { -16, -12, 30, -3,  17 },
                {   3, -15, 12,  5,  -5 },
                {  17,  22, -3, 32, -11 },
                {   9,  28,  1, -9,  -2 } 
        };
        private void FormMine_Load(object sender, EventArgs e)
        {
            int rows = matrix.GetUpperBound(0) + 1;
            int columns = matrix.Length / rows;

            dataGridViewInData_KDR.ColumnCount = columns;
            dataGridViewInData_KDR.RowCount = rows;
            dataGridViewResData_KDR.ColumnCount = columns;
            dataGridViewResData_KDR.RowCount = rows;
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    dataGridViewInData_KDR.Rows[i].Cells[j].Value = Convert.ToString(matrix[i, j]);
                }
            }  
        }
        private void buttonHelp_KDR_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 3 выполнил студент группы ИИПб-23-2 Колчаков Даниль Рамильевич", "Сообщение", MessageBoxButtons.OK);
        }
        private void buttonDone_KDR_Click(object sender, EventArgs e)
        {
            int[,] mtrx = ds.Calculate(matrix);
            int rows = mtrx.GetUpperBound(0) + 1;
            int columns = mtrx.Length / rows;

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    dataGridViewResData_KDR.Rows[i].Cells[j].Value = Convert.ToString(mtrx[i, j]);
                }
            }

        }
    }
}
