
namespace Tyuiu.KolchakovDR.Sprint6.Task5.V27
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.panelTop_KDR = new System.Windows.Forms.Panel();
            this.buttonOpen_KDR = new System.Windows.Forms.Button();
            this.groupBoxTask_KDR = new System.Windows.Forms.GroupBox();
            this.labelTask_KDR = new System.Windows.Forms.Label();
            this.buttonHelp_KDR = new System.Windows.Forms.Button();
            this.buttonDone_KDR = new System.Windows.Forms.Button();
            this.panelLeft_KDR = new System.Windows.Forms.Panel();
            this.dataGridViewValid_KDR = new System.Windows.Forms.DataGridView();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.panelFill_KDR = new System.Windows.Forms.Panel();
            this.chartFunc_KDR = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.X = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Y = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panelTop_KDR.SuspendLayout();
            this.groupBoxTask_KDR.SuspendLayout();
            this.panelLeft_KDR.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewValid_KDR)).BeginInit();
            this.panelFill_KDR.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartFunc_KDR)).BeginInit();
            this.SuspendLayout();
            // 
            // panelTop_KDR
            // 
            this.panelTop_KDR.Controls.Add(this.buttonOpen_KDR);
            this.panelTop_KDR.Controls.Add(this.groupBoxTask_KDR);
            this.panelTop_KDR.Controls.Add(this.buttonHelp_KDR);
            this.panelTop_KDR.Controls.Add(this.buttonDone_KDR);
            this.panelTop_KDR.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop_KDR.Location = new System.Drawing.Point(0, 0);
            this.panelTop_KDR.Name = "panelTop_KDR";
            this.panelTop_KDR.Padding = new System.Windows.Forms.Padding(5);
            this.panelTop_KDR.Size = new System.Drawing.Size(784, 87);
            this.panelTop_KDR.TabIndex = 0;
            // 
            // buttonOpen_KDR
            // 
            this.buttonOpen_KDR.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonOpen_KDR.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.buttonOpen_KDR.Location = new System.Drawing.Point(496, 50);
            this.buttonOpen_KDR.Name = "buttonOpen_KDR";
            this.buttonOpen_KDR.Size = new System.Drawing.Size(135, 29);
            this.buttonOpen_KDR.TabIndex = 24;
            this.buttonOpen_KDR.Text = "Открыть файл";
            this.buttonOpen_KDR.UseVisualStyleBackColor = false;
            this.buttonOpen_KDR.Click += new System.EventHandler(this.buttonOpen_KDR_Click);
            // 
            // groupBoxTask_KDR
            // 
            this.groupBoxTask_KDR.Controls.Add(this.labelTask_KDR);
            this.groupBoxTask_KDR.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupBoxTask_KDR.Location = new System.Drawing.Point(5, 5);
            this.groupBoxTask_KDR.Name = "groupBoxTask_KDR";
            this.groupBoxTask_KDR.Padding = new System.Windows.Forms.Padding(10);
            this.groupBoxTask_KDR.Size = new System.Drawing.Size(485, 77);
            this.groupBoxTask_KDR.TabIndex = 16;
            this.groupBoxTask_KDR.TabStop = false;
            this.groupBoxTask_KDR.Text = "Условие";
            // 
            // labelTask_KDR
            // 
            this.labelTask_KDR.AutoSize = true;
            this.labelTask_KDR.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelTask_KDR.Location = new System.Drawing.Point(10, 23);
            this.labelTask_KDR.Name = "labelTask_KDR";
            this.labelTask_KDR.Padding = new System.Windows.Forms.Padding(5);
            this.labelTask_KDR.Size = new System.Drawing.Size(399, 36);
            this.labelTask_KDR.TabIndex = 2;
            this.labelTask_KDR.Text = "Прочитать данные из файла InPutFileTask5V27.txt. Вывести в dataGridView. \r\nВывест" +
    "и все числа не кратные 5.";
            // 
            // buttonHelp_KDR
            // 
            this.buttonHelp_KDR.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonHelp_KDR.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonHelp_KDR.Location = new System.Drawing.Point(682, 14);
            this.buttonHelp_KDR.Name = "buttonHelp_KDR";
            this.buttonHelp_KDR.Size = new System.Drawing.Size(90, 30);
            this.buttonHelp_KDR.TabIndex = 23;
            this.buttonHelp_KDR.Text = "Справка";
            this.buttonHelp_KDR.UseVisualStyleBackColor = false;
            this.buttonHelp_KDR.Click += new System.EventHandler(this.buttonHelp_KDR_Click);
            // 
            // buttonDone_KDR
            // 
            this.buttonDone_KDR.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonDone_KDR.BackColor = System.Drawing.Color.LimeGreen;
            this.buttonDone_KDR.Location = new System.Drawing.Point(496, 13);
            this.buttonDone_KDR.Name = "buttonDone_KDR";
            this.buttonDone_KDR.Size = new System.Drawing.Size(135, 31);
            this.buttonDone_KDR.TabIndex = 22;
            this.buttonDone_KDR.Text = "Выполнить";
            this.buttonDone_KDR.UseVisualStyleBackColor = false;
            this.buttonDone_KDR.Click += new System.EventHandler(this.buttonDone_KDR_Click);
            // 
            // panelLeft_KDR
            // 
            this.panelLeft_KDR.Controls.Add(this.dataGridViewValid_KDR);
            this.panelLeft_KDR.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelLeft_KDR.Location = new System.Drawing.Point(0, 87);
            this.panelLeft_KDR.Name = "panelLeft_KDR";
            this.panelLeft_KDR.Padding = new System.Windows.Forms.Padding(5);
            this.panelLeft_KDR.Size = new System.Drawing.Size(145, 374);
            this.panelLeft_KDR.TabIndex = 1;
            // 
            // dataGridViewValid_KDR
            // 
            this.dataGridViewValid_KDR.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewValid_KDR.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.X,
            this.Y});
            this.dataGridViewValid_KDR.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewValid_KDR.Location = new System.Drawing.Point(5, 5);
            this.dataGridViewValid_KDR.Name = "dataGridViewValid_KDR";
            this.dataGridViewValid_KDR.RowHeadersVisible = false;
            this.dataGridViewValid_KDR.Size = new System.Drawing.Size(135, 364);
            this.dataGridViewValid_KDR.TabIndex = 25;
            // 
            // splitter1
            // 
            this.splitter1.Location = new System.Drawing.Point(145, 87);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(3, 374);
            this.splitter1.TabIndex = 2;
            this.splitter1.TabStop = false;
            // 
            // panelFill_KDR
            // 
            this.panelFill_KDR.Controls.Add(this.chartFunc_KDR);
            this.panelFill_KDR.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelFill_KDR.Location = new System.Drawing.Point(148, 87);
            this.panelFill_KDR.Name = "panelFill_KDR";
            this.panelFill_KDR.Padding = new System.Windows.Forms.Padding(5);
            this.panelFill_KDR.Size = new System.Drawing.Size(636, 374);
            this.panelFill_KDR.TabIndex = 3;
            // 
            // chartFunc_KDR
            // 
            chartArea1.Name = "ChartArea1";
            this.chartFunc_KDR.ChartAreas.Add(chartArea1);
            this.chartFunc_KDR.Dock = System.Windows.Forms.DockStyle.Fill;
            legend1.Enabled = false;
            legend1.Name = "Legend1";
            this.chartFunc_KDR.Legends.Add(legend1);
            this.chartFunc_KDR.Location = new System.Drawing.Point(5, 5);
            this.chartFunc_KDR.Name = "chartFunc_KDR";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chartFunc_KDR.Series.Add(series1);
            this.chartFunc_KDR.Size = new System.Drawing.Size(626, 364);
            this.chartFunc_KDR.TabIndex = 0;
            this.chartFunc_KDR.Text = "График чисел не кратных 5";
            title1.Name = "Title1";
            title1.Text = "График чисел не кратных 5";
            this.chartFunc_KDR.Titles.Add(title1);
            // 
            // X
            // 
            this.X.HeaderText = "№";
            this.X.Name = "X";
            this.X.Width = 60;
            // 
            // Y
            // 
            this.Y.HeaderText = "Число";
            this.Y.Name = "Y";
            this.Y.Width = 60;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 461);
            this.Controls.Add(this.panelFill_KDR);
            this.Controls.Add(this.splitter1);
            this.Controls.Add(this.panelLeft_KDR);
            this.Controls.Add(this.panelTop_KDR);
            this.MinimumSize = new System.Drawing.Size(800, 500);
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Спринт 6 | Таск 5 | Вариант 27 | Колчаков Д. Р.";
            this.panelTop_KDR.ResumeLayout(false);
            this.groupBoxTask_KDR.ResumeLayout(false);
            this.groupBoxTask_KDR.PerformLayout();
            this.panelLeft_KDR.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewValid_KDR)).EndInit();
            this.panelFill_KDR.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chartFunc_KDR)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelTop_KDR;
        private System.Windows.Forms.Panel panelLeft_KDR;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.Panel panelFill_KDR;
        private System.Windows.Forms.GroupBox groupBoxTask_KDR;
        private System.Windows.Forms.Label labelTask_KDR;
        private System.Windows.Forms.Button buttonOpen_KDR;
        private System.Windows.Forms.Button buttonHelp_KDR;
        private System.Windows.Forms.Button buttonDone_KDR;
        private System.Windows.Forms.DataGridView dataGridViewValid_KDR;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartFunc_KDR;
        private System.Windows.Forms.DataGridViewTextBoxColumn X;
        private System.Windows.Forms.DataGridViewTextBoxColumn Y;
    }
}

