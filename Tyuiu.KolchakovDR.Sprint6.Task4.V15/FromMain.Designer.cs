
namespace Tyuiu.KolchakovDR.Sprint6.Task4.V15
{
    partial class FromMain
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FromMain));
            this.groupBoxTask_KDR = new System.Windows.Forms.GroupBox();
            this.chartFunc_KDR = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.buttonSave_KDR = new System.Windows.Forms.Button();
            this.pictureBoxFormula_KDR = new System.Windows.Forms.PictureBox();
            this.labelTask_KDR = new System.Windows.Forms.Label();
            this.buttonHelp_KDR = new System.Windows.Forms.Button();
            this.groupBoxInputData_KDR = new System.Windows.Forms.GroupBox();
            this.textBoxVarStart_KDR = new System.Windows.Forms.TextBox();
            this.labelStart_KDR = new System.Windows.Forms.Label();
            this.labelStop_KDR = new System.Windows.Forms.Label();
            this.textBoxVarStop_KDR = new System.Windows.Forms.TextBox();
            this.buttonDone_KDR = new System.Windows.Forms.Button();
            this.textBoxRes_KDR = new System.Windows.Forms.TextBox();
            this.groupBoxOutputData_KDR = new System.Windows.Forms.GroupBox();
            this.groupBoxTask_KDR.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartFunc_KDR)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFormula_KDR)).BeginInit();
            this.groupBoxInputData_KDR.SuspendLayout();
            this.groupBoxOutputData_KDR.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxTask_KDR
            // 
            this.groupBoxTask_KDR.Controls.Add(this.labelTask_KDR);
            this.groupBoxTask_KDR.Controls.Add(this.pictureBoxFormula_KDR);
            this.groupBoxTask_KDR.Location = new System.Drawing.Point(12, 6);
            this.groupBoxTask_KDR.Name = "groupBoxTask_KDR";
            this.groupBoxTask_KDR.Size = new System.Drawing.Size(355, 103);
            this.groupBoxTask_KDR.TabIndex = 15;
            this.groupBoxTask_KDR.TabStop = false;
            this.groupBoxTask_KDR.Text = "Условие";
            // 
            // chartFunc_KDR
            // 
            chartArea1.Name = "ChartArea1";
            this.chartFunc_KDR.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartFunc_KDR.Legends.Add(legend1);
            this.chartFunc_KDR.Location = new System.Drawing.Point(221, 115);
            this.chartFunc_KDR.Name = "chartFunc_KDR";
            this.chartFunc_KDR.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.None;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series1.IsVisibleInLegend = false;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chartFunc_KDR.Series.Add(series1);
            this.chartFunc_KDR.Size = new System.Drawing.Size(557, 399);
            this.chartFunc_KDR.TabIndex = 20;
            this.chartFunc_KDR.Text = "chart1";
            // 
            // buttonSave_KDR
            // 
            this.buttonSave_KDR.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.buttonSave_KDR.Location = new System.Drawing.Point(524, 64);
            this.buttonSave_KDR.Name = "buttonSave_KDR";
            this.buttonSave_KDR.Size = new System.Drawing.Size(135, 29);
            this.buttonSave_KDR.TabIndex = 21;
            this.buttonSave_KDR.Text = "Сохранить";
            this.buttonSave_KDR.UseVisualStyleBackColor = false;
            this.buttonSave_KDR.Click += new System.EventHandler(this.buttonSave_KDR_Click);
            // 
            // pictureBoxFormula_KDR
            // 
            this.pictureBoxFormula_KDR.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxFormula_KDR.Image")));
            this.pictureBoxFormula_KDR.Location = new System.Drawing.Point(22, 50);
            this.pictureBoxFormula_KDR.Name = "pictureBoxFormula_KDR";
            this.pictureBoxFormula_KDR.Size = new System.Drawing.Size(322, 37);
            this.pictureBoxFormula_KDR.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBoxFormula_KDR.TabIndex = 0;
            this.pictureBoxFormula_KDR.TabStop = false;
            // 
            // labelTask_KDR
            // 
            this.labelTask_KDR.AutoSize = true;
            this.labelTask_KDR.Location = new System.Drawing.Point(19, 17);
            this.labelTask_KDR.Name = "labelTask_KDR";
            this.labelTask_KDR.Size = new System.Drawing.Size(299, 26);
            this.labelTask_KDR.TabIndex = 2;
            this.labelTask_KDR.Text = "Протабулировать функцию на заданном диапазоне [-5;5].\r\nРезультат вывести в таблиц" +
    "у.\r\n";
            // 
            // buttonHelp_KDR
            // 
            this.buttonHelp_KDR.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonHelp_KDR.Location = new System.Drawing.Point(688, 23);
            this.buttonHelp_KDR.Name = "buttonHelp_KDR";
            this.buttonHelp_KDR.Size = new System.Drawing.Size(90, 30);
            this.buttonHelp_KDR.TabIndex = 19;
            this.buttonHelp_KDR.Text = "Справка";
            this.buttonHelp_KDR.UseVisualStyleBackColor = false;
            this.buttonHelp_KDR.Click += new System.EventHandler(this.buttonHelp_KDR_Click);
            // 
            // groupBoxInputData_KDR
            // 
            this.groupBoxInputData_KDR.Controls.Add(this.textBoxVarStop_KDR);
            this.groupBoxInputData_KDR.Controls.Add(this.labelStop_KDR);
            this.groupBoxInputData_KDR.Controls.Add(this.labelStart_KDR);
            this.groupBoxInputData_KDR.Controls.Add(this.textBoxVarStart_KDR);
            this.groupBoxInputData_KDR.Location = new System.Drawing.Point(373, 6);
            this.groupBoxInputData_KDR.Name = "groupBoxInputData_KDR";
            this.groupBoxInputData_KDR.Size = new System.Drawing.Size(145, 103);
            this.groupBoxInputData_KDR.TabIndex = 16;
            this.groupBoxInputData_KDR.TabStop = false;
            this.groupBoxInputData_KDR.Text = "Ввод данных";
            // 
            // textBoxVarStart_KDR
            // 
            this.textBoxVarStart_KDR.Location = new System.Drawing.Point(6, 31);
            this.textBoxVarStart_KDR.Name = "textBoxVarStart_KDR";
            this.textBoxVarStart_KDR.Size = new System.Drawing.Size(108, 20);
            this.textBoxVarStart_KDR.TabIndex = 0;
            // 
            // labelStart_KDR
            // 
            this.labelStart_KDR.AutoSize = true;
            this.labelStart_KDR.Location = new System.Drawing.Point(6, 15);
            this.labelStart_KDR.Name = "labelStart_KDR";
            this.labelStart_KDR.Size = new System.Drawing.Size(67, 13);
            this.labelStart_KDR.TabIndex = 1;
            this.labelStart_KDR.Text = "Старт шага:";
            // 
            // labelStop_KDR
            // 
            this.labelStop_KDR.AutoSize = true;
            this.labelStop_KDR.Location = new System.Drawing.Point(6, 61);
            this.labelStop_KDR.Name = "labelStop_KDR";
            this.labelStop_KDR.Size = new System.Drawing.Size(69, 13);
            this.labelStop_KDR.TabIndex = 2;
            this.labelStop_KDR.Text = "Конец шага:";
            // 
            // textBoxVarStop_KDR
            // 
            this.textBoxVarStop_KDR.Location = new System.Drawing.Point(6, 77);
            this.textBoxVarStop_KDR.Name = "textBoxVarStop_KDR";
            this.textBoxVarStop_KDR.Size = new System.Drawing.Size(108, 20);
            this.textBoxVarStop_KDR.TabIndex = 3;
            // 
            // buttonDone_KDR
            // 
            this.buttonDone_KDR.BackColor = System.Drawing.Color.LimeGreen;
            this.buttonDone_KDR.Location = new System.Drawing.Point(524, 22);
            this.buttonDone_KDR.Name = "buttonDone_KDR";
            this.buttonDone_KDR.Size = new System.Drawing.Size(135, 31);
            this.buttonDone_KDR.TabIndex = 18;
            this.buttonDone_KDR.Text = "Выполнить";
            this.buttonDone_KDR.UseVisualStyleBackColor = false;
            this.buttonDone_KDR.Click += new System.EventHandler(this.buttonDone_KDR_Click);
            // 
            // textBoxRes_KDR
            // 
            this.textBoxRes_KDR.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxRes_KDR.Location = new System.Drawing.Point(6, 19);
            this.textBoxRes_KDR.Multiline = true;
            this.textBoxRes_KDR.Name = "textBoxRes_KDR";
            this.textBoxRes_KDR.ReadOnly = true;
            this.textBoxRes_KDR.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxRes_KDR.Size = new System.Drawing.Size(191, 374);
            this.textBoxRes_KDR.TabIndex = 21;
            this.textBoxRes_KDR.TabStop = false;
            this.textBoxRes_KDR.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // groupBoxOutputData_KDR
            // 
            this.groupBoxOutputData_KDR.Controls.Add(this.textBoxRes_KDR);
            this.groupBoxOutputData_KDR.Location = new System.Drawing.Point(12, 115);
            this.groupBoxOutputData_KDR.Name = "groupBoxOutputData_KDR";
            this.groupBoxOutputData_KDR.Size = new System.Drawing.Size(203, 399);
            this.groupBoxOutputData_KDR.TabIndex = 17;
            this.groupBoxOutputData_KDR.TabStop = false;
            this.groupBoxOutputData_KDR.Text = "Вывод данных";
            // 
            // FromMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(790, 544);
            this.Controls.Add(this.buttonSave_KDR);
            this.Controls.Add(this.chartFunc_KDR);
            this.Controls.Add(this.groupBoxTask_KDR);
            this.Controls.Add(this.groupBoxInputData_KDR);
            this.Controls.Add(this.groupBoxOutputData_KDR);
            this.Controls.Add(this.buttonHelp_KDR);
            this.Controls.Add(this.buttonDone_KDR);
            this.MinimumSize = new System.Drawing.Size(806, 583);
            this.Name = "FromMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Спринт 6 | Таск 4 | Вариант 15 | Колчаков Д. Р.";
            this.groupBoxTask_KDR.ResumeLayout(false);
            this.groupBoxTask_KDR.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartFunc_KDR)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFormula_KDR)).EndInit();
            this.groupBoxInputData_KDR.ResumeLayout(false);
            this.groupBoxInputData_KDR.PerformLayout();
            this.groupBoxOutputData_KDR.ResumeLayout(false);
            this.groupBoxOutputData_KDR.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxTask_KDR;
        private System.Windows.Forms.Label labelTask_KDR;
        private System.Windows.Forms.PictureBox pictureBoxFormula_KDR;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartFunc_KDR;
        private System.Windows.Forms.Button buttonSave_KDR;
        private System.Windows.Forms.Button buttonHelp_KDR;
        private System.Windows.Forms.GroupBox groupBoxInputData_KDR;
        private System.Windows.Forms.TextBox textBoxVarStop_KDR;
        private System.Windows.Forms.Label labelStop_KDR;
        private System.Windows.Forms.Label labelStart_KDR;
        private System.Windows.Forms.TextBox textBoxVarStart_KDR;
        private System.Windows.Forms.Button buttonDone_KDR;
        private System.Windows.Forms.TextBox textBoxRes_KDR;
        private System.Windows.Forms.GroupBox groupBoxOutputData_KDR;
    }
}

