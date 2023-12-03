
namespace Tyuiu.KolchakovDR.Sprint6.Task2.V12
{
    partial class FormMain
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend4 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.groupBoxTask_KDR = new System.Windows.Forms.GroupBox();
            this.labelTask_KDR = new System.Windows.Forms.Label();
            this.pictureBoxFormula_KDR = new System.Windows.Forms.PictureBox();
            this.groupBoxInputData_KDR = new System.Windows.Forms.GroupBox();
            this.textBoxVarStop_KDR = new System.Windows.Forms.TextBox();
            this.labelStop_KDR = new System.Windows.Forms.Label();
            this.labelStart_KDR = new System.Windows.Forms.Label();
            this.textBoxVarStart_KDR = new System.Windows.Forms.TextBox();
            this.groupBoxOutputData_KDR = new System.Windows.Forms.GroupBox();
            this.dataGridViewFunc_KDR = new System.Windows.Forms.DataGridView();
            this.labelRes_KDR = new System.Windows.Forms.Label();
            this.buttonHelp_KDR = new System.Windows.Forms.Button();
            this.buttonDone_KDR = new System.Windows.Forms.Button();
            this.X = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Y = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.chartFunc_KDR = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.groupBoxTask_KDR.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFormula_KDR)).BeginInit();
            this.groupBoxInputData_KDR.SuspendLayout();
            this.groupBoxOutputData_KDR.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFunc_KDR)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartFunc_KDR)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxTask_KDR
            // 
            this.groupBoxTask_KDR.Controls.Add(this.labelTask_KDR);
            this.groupBoxTask_KDR.Controls.Add(this.pictureBoxFormula_KDR);
            this.groupBoxTask_KDR.Location = new System.Drawing.Point(12, 26);
            this.groupBoxTask_KDR.Name = "groupBoxTask_KDR";
            this.groupBoxTask_KDR.Size = new System.Drawing.Size(471, 242);
            this.groupBoxTask_KDR.TabIndex = 10;
            this.groupBoxTask_KDR.TabStop = false;
            this.groupBoxTask_KDR.Text = "Условие";
            // 
            // labelTask_KDR
            // 
            this.labelTask_KDR.AutoSize = true;
            this.labelTask_KDR.Location = new System.Drawing.Point(23, 28);
            this.labelTask_KDR.Name = "labelTask_KDR";
            this.labelTask_KDR.Size = new System.Drawing.Size(272, 26);
            this.labelTask_KDR.TabIndex = 2;
            this.labelTask_KDR.Text = "Протабулировать функцию на заданном диапазоне.\r\nРезультат вывести в таблицу.\r\n";
            // 
            // pictureBoxFormula_KDR
            // 
            this.pictureBoxFormula_KDR.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxFormula_KDR.Image")));
            this.pictureBoxFormula_KDR.Location = new System.Drawing.Point(26, 78);
            this.pictureBoxFormula_KDR.Name = "pictureBoxFormula_KDR";
            this.pictureBoxFormula_KDR.Size = new System.Drawing.Size(190, 40);
            this.pictureBoxFormula_KDR.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBoxFormula_KDR.TabIndex = 0;
            this.pictureBoxFormula_KDR.TabStop = false;
            // 
            // groupBoxInputData_KDR
            // 
            this.groupBoxInputData_KDR.Controls.Add(this.textBoxVarStop_KDR);
            this.groupBoxInputData_KDR.Controls.Add(this.labelStop_KDR);
            this.groupBoxInputData_KDR.Controls.Add(this.labelStart_KDR);
            this.groupBoxInputData_KDR.Controls.Add(this.textBoxVarStart_KDR);
            this.groupBoxInputData_KDR.Location = new System.Drawing.Point(12, 274);
            this.groupBoxInputData_KDR.Name = "groupBoxInputData_KDR";
            this.groupBoxInputData_KDR.Size = new System.Drawing.Size(471, 106);
            this.groupBoxInputData_KDR.TabIndex = 11;
            this.groupBoxInputData_KDR.TabStop = false;
            this.groupBoxInputData_KDR.Text = "Ввод данных";
            // 
            // textBoxVarStop_KDR
            // 
            this.textBoxVarStop_KDR.Location = new System.Drawing.Point(218, 47);
            this.textBoxVarStop_KDR.Name = "textBoxVarStop_KDR";
            this.textBoxVarStop_KDR.Size = new System.Drawing.Size(100, 20);
            this.textBoxVarStop_KDR.TabIndex = 3;
            // 
            // labelStop_KDR
            // 
            this.labelStop_KDR.AutoSize = true;
            this.labelStop_KDR.Location = new System.Drawing.Point(215, 31);
            this.labelStop_KDR.Name = "labelStop_KDR";
            this.labelStop_KDR.Size = new System.Drawing.Size(69, 13);
            this.labelStop_KDR.TabIndex = 2;
            this.labelStop_KDR.Text = "Конец шага:";
            // 
            // labelStart_KDR
            // 
            this.labelStart_KDR.AutoSize = true;
            this.labelStart_KDR.Location = new System.Drawing.Point(23, 31);
            this.labelStart_KDR.Name = "labelStart_KDR";
            this.labelStart_KDR.Size = new System.Drawing.Size(67, 13);
            this.labelStart_KDR.TabIndex = 1;
            this.labelStart_KDR.Text = "Старт шага:";
            // 
            // textBoxVarStart_KDR
            // 
            this.textBoxVarStart_KDR.Location = new System.Drawing.Point(26, 47);
            this.textBoxVarStart_KDR.Name = "textBoxVarStart_KDR";
            this.textBoxVarStart_KDR.Size = new System.Drawing.Size(100, 20);
            this.textBoxVarStart_KDR.TabIndex = 0;
            // 
            // groupBoxOutputData_KDR
            // 
            this.groupBoxOutputData_KDR.Controls.Add(this.chartFunc_KDR);
            this.groupBoxOutputData_KDR.Controls.Add(this.dataGridViewFunc_KDR);
            this.groupBoxOutputData_KDR.Controls.Add(this.labelRes_KDR);
            this.groupBoxOutputData_KDR.Location = new System.Drawing.Point(489, 26);
            this.groupBoxOutputData_KDR.Name = "groupBoxOutputData_KDR";
            this.groupBoxOutputData_KDR.Size = new System.Drawing.Size(605, 399);
            this.groupBoxOutputData_KDR.TabIndex = 12;
            this.groupBoxOutputData_KDR.TabStop = false;
            this.groupBoxOutputData_KDR.Text = "Вывод данных";
            // 
            // dataGridViewFunc_KDR
            // 
            this.dataGridViewFunc_KDR.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewFunc_KDR.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.X,
            this.Y});
            this.dataGridViewFunc_KDR.Location = new System.Drawing.Point(9, 44);
            this.dataGridViewFunc_KDR.Name = "dataGridViewFunc_KDR";
            this.dataGridViewFunc_KDR.RowHeadersVisible = false;
            this.dataGridViewFunc_KDR.Size = new System.Drawing.Size(111, 349);
            this.dataGridViewFunc_KDR.TabIndex = 5;
            // 
            // labelRes_KDR
            // 
            this.labelRes_KDR.AutoSize = true;
            this.labelRes_KDR.Location = new System.Drawing.Point(6, 28);
            this.labelRes_KDR.Name = "labelRes_KDR";
            this.labelRes_KDR.Size = new System.Drawing.Size(62, 13);
            this.labelRes_KDR.TabIndex = 4;
            this.labelRes_KDR.Text = "Результат:";
            // 
            // buttonHelp_KDR
            // 
            this.buttonHelp_KDR.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonHelp_KDR.Location = new System.Drawing.Point(12, 386);
            this.buttonHelp_KDR.Name = "buttonHelp_KDR";
            this.buttonHelp_KDR.Size = new System.Drawing.Size(90, 39);
            this.buttonHelp_KDR.TabIndex = 14;
            this.buttonHelp_KDR.Text = "Справка";
            this.buttonHelp_KDR.UseVisualStyleBackColor = false;
            this.buttonHelp_KDR.Click += new System.EventHandler(this.buttonHelp_KDR_Click);
            // 
            // buttonDone_KDR
            // 
            this.buttonDone_KDR.BackColor = System.Drawing.Color.LimeGreen;
            this.buttonDone_KDR.Location = new System.Drawing.Point(348, 386);
            this.buttonDone_KDR.Name = "buttonDone_KDR";
            this.buttonDone_KDR.Size = new System.Drawing.Size(135, 39);
            this.buttonDone_KDR.TabIndex = 13;
            this.buttonDone_KDR.Text = "Выполнить";
            this.buttonDone_KDR.UseVisualStyleBackColor = false;
            this.buttonDone_KDR.Click += new System.EventHandler(this.buttonDone_KDR_Click);
            this.buttonDone_KDR.MouseDown += new System.Windows.Forms.MouseEventHandler(this.buttonDone_KDR_MouseDown);
            this.buttonDone_KDR.MouseEnter += new System.EventHandler(this.buttonDone_KDR_MouseEnter);
            this.buttonDone_KDR.MouseLeave += new System.EventHandler(this.buttonDone_KDR_MouseLeave);
            // 
            // X
            // 
            this.X.HeaderText = "X";
            this.X.Name = "X";
            this.X.Width = 50;
            // 
            // Y
            // 
            this.Y.HeaderText = "F(X)";
            this.Y.Name = "Y";
            this.Y.Width = 50;
            // 
            // chartFunc_KDR
            // 
            chartArea4.Name = "ChartArea1";
            this.chartFunc_KDR.ChartAreas.Add(chartArea4);
            legend4.Name = "Legend1";
            this.chartFunc_KDR.Legends.Add(legend4);
            this.chartFunc_KDR.Location = new System.Drawing.Point(126, 44);
            this.chartFunc_KDR.Name = "chartFunc_KDR";
            series4.ChartArea = "ChartArea1";
            series4.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series4.IsVisibleInLegend = false;
            series4.Legend = "Legend1";
            series4.Name = "Series1";
            this.chartFunc_KDR.Series.Add(series4);
            this.chartFunc_KDR.Size = new System.Drawing.Size(473, 349);
            this.chartFunc_KDR.TabIndex = 3;
            this.chartFunc_KDR.Text = "chart1";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1106, 450);
            this.Controls.Add(this.groupBoxTask_KDR);
            this.Controls.Add(this.groupBoxInputData_KDR);
            this.Controls.Add(this.groupBoxOutputData_KDR);
            this.Controls.Add(this.buttonHelp_KDR);
            this.Controls.Add(this.buttonDone_KDR);
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Спринт 6 | Таск 2 | Вариант 12 | Колчаков Д. Р.";
            this.groupBoxTask_KDR.ResumeLayout(false);
            this.groupBoxTask_KDR.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFormula_KDR)).EndInit();
            this.groupBoxInputData_KDR.ResumeLayout(false);
            this.groupBoxInputData_KDR.PerformLayout();
            this.groupBoxOutputData_KDR.ResumeLayout(false);
            this.groupBoxOutputData_KDR.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFunc_KDR)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartFunc_KDR)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxTask_KDR;
        private System.Windows.Forms.Label labelTask_KDR;
        private System.Windows.Forms.PictureBox pictureBoxFormula_KDR;
        private System.Windows.Forms.GroupBox groupBoxInputData_KDR;
        private System.Windows.Forms.TextBox textBoxVarStop_KDR;
        private System.Windows.Forms.Label labelStop_KDR;
        private System.Windows.Forms.Label labelStart_KDR;
        private System.Windows.Forms.TextBox textBoxVarStart_KDR;
        private System.Windows.Forms.GroupBox groupBoxOutputData_KDR;
        private System.Windows.Forms.Label labelRes_KDR;
        private System.Windows.Forms.Button buttonHelp_KDR;
        private System.Windows.Forms.Button buttonDone_KDR;
        private System.Windows.Forms.DataGridView dataGridViewFunc_KDR;
        private System.Windows.Forms.DataGridViewTextBoxColumn X;
        private System.Windows.Forms.DataGridViewTextBoxColumn Y;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartFunc_KDR;
    }
}

