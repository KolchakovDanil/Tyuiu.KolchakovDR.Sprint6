
namespace Tyuiu.KolchakovDR.Sprint6.Task7.V21
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.panelLeft_KDR = new System.Windows.Forms.Panel();
            this.groupBoxInputData_KDR = new System.Windows.Forms.GroupBox();
            this.dataGridViewIn_KDR = new System.Windows.Forms.DataGridView();
            this.panelTopTwo_KDR = new System.Windows.Forms.Panel();
            this.groupBoxTask_KDR = new System.Windows.Forms.GroupBox();
            this.labelTask_KDR = new System.Windows.Forms.Label();
            this.panelTopOne_KDR = new System.Windows.Forms.Panel();
            this.buttonSaveFile_KDR = new System.Windows.Forms.Button();
            this.buttonHelp_KDR = new System.Windows.Forms.Button();
            this.buttonLoadFile_KDR = new System.Windows.Forms.Button();
            this.buttonOpenFile_KDR = new System.Windows.Forms.Button();
            this.groupBoxOutputData_KDR = new System.Windows.Forms.GroupBox();
            this.dataGridViewOut_KDR = new System.Windows.Forms.DataGridView();
            this.panelFill_KDR = new System.Windows.Forms.Panel();
            this.splitterL_KDR = new System.Windows.Forms.Splitter();
            this.openFileDialogTask_KDR = new System.Windows.Forms.OpenFileDialog();
            this.toolTip_KDR = new System.Windows.Forms.ToolTip(this.components);
            this.saveFileDialogTask_KDR = new System.Windows.Forms.SaveFileDialog();
            this.panelLeft_KDR.SuspendLayout();
            this.groupBoxInputData_KDR.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewIn_KDR)).BeginInit();
            this.panelTopTwo_KDR.SuspendLayout();
            this.groupBoxTask_KDR.SuspendLayout();
            this.panelTopOne_KDR.SuspendLayout();
            this.groupBoxOutputData_KDR.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOut_KDR)).BeginInit();
            this.panelFill_KDR.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelLeft_KDR
            // 
            this.panelLeft_KDR.Controls.Add(this.groupBoxInputData_KDR);
            this.panelLeft_KDR.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelLeft_KDR.Location = new System.Drawing.Point(0, 135);
            this.panelLeft_KDR.Name = "panelLeft_KDR";
            this.panelLeft_KDR.Padding = new System.Windows.Forms.Padding(5);
            this.panelLeft_KDR.Size = new System.Drawing.Size(433, 276);
            this.panelLeft_KDR.TabIndex = 7;
            // 
            // groupBoxInputData_KDR
            // 
            this.groupBoxInputData_KDR.Controls.Add(this.dataGridViewIn_KDR);
            this.groupBoxInputData_KDR.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxInputData_KDR.Location = new System.Drawing.Point(5, 5);
            this.groupBoxInputData_KDR.Name = "groupBoxInputData_KDR";
            this.groupBoxInputData_KDR.Padding = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.groupBoxInputData_KDR.Size = new System.Drawing.Size(423, 266);
            this.groupBoxInputData_KDR.TabIndex = 22;
            this.groupBoxInputData_KDR.TabStop = false;
            this.groupBoxInputData_KDR.Text = "Вывод данных:";
            // 
            // dataGridViewIn_KDR
            // 
            this.dataGridViewIn_KDR.AllowUserToResizeColumns = false;
            this.dataGridViewIn_KDR.AllowUserToResizeRows = false;
            this.dataGridViewIn_KDR.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridViewIn_KDR.ColumnHeadersVisible = false;
            this.dataGridViewIn_KDR.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewIn_KDR.Location = new System.Drawing.Point(5, 16);
            this.dataGridViewIn_KDR.Name = "dataGridViewIn_KDR";
            this.dataGridViewIn_KDR.RowHeadersVisible = false;
            this.dataGridViewIn_KDR.Size = new System.Drawing.Size(413, 247);
            this.dataGridViewIn_KDR.TabIndex = 0;
            // 
            // panelTopTwo_KDR
            // 
            this.panelTopTwo_KDR.Controls.Add(this.groupBoxTask_KDR);
            this.panelTopTwo_KDR.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTopTwo_KDR.Location = new System.Drawing.Point(0, 58);
            this.panelTopTwo_KDR.Name = "panelTopTwo_KDR";
            this.panelTopTwo_KDR.Size = new System.Drawing.Size(784, 77);
            this.panelTopTwo_KDR.TabIndex = 6;
            // 
            // groupBoxTask_KDR
            // 
            this.groupBoxTask_KDR.Controls.Add(this.labelTask_KDR);
            this.groupBoxTask_KDR.Location = new System.Drawing.Point(3, 2);
            this.groupBoxTask_KDR.Name = "groupBoxTask_KDR";
            this.groupBoxTask_KDR.Padding = new System.Windows.Forms.Padding(10);
            this.groupBoxTask_KDR.Size = new System.Drawing.Size(769, 72);
            this.groupBoxTask_KDR.TabIndex = 17;
            this.groupBoxTask_KDR.TabStop = false;
            this.groupBoxTask_KDR.Text = "Условие";
            // 
            // labelTask_KDR
            // 
            this.labelTask_KDR.AutoSize = true;
            this.labelTask_KDR.Location = new System.Drawing.Point(13, 15);
            this.labelTask_KDR.Name = "labelTask_KDR";
            this.labelTask_KDR.Padding = new System.Windows.Forms.Padding(5);
            this.labelTask_KDR.Size = new System.Drawing.Size(633, 49);
            this.labelTask_KDR.TabIndex = 2;
            this.labelTask_KDR.Text = resources.GetString("labelTask_KDR.Text");
            // 
            // panelTopOne_KDR
            // 
            this.panelTopOne_KDR.Controls.Add(this.buttonSaveFile_KDR);
            this.panelTopOne_KDR.Controls.Add(this.buttonHelp_KDR);
            this.panelTopOne_KDR.Controls.Add(this.buttonLoadFile_KDR);
            this.panelTopOne_KDR.Controls.Add(this.buttonOpenFile_KDR);
            this.panelTopOne_KDR.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTopOne_KDR.Location = new System.Drawing.Point(0, 0);
            this.panelTopOne_KDR.Name = "panelTopOne_KDR";
            this.panelTopOne_KDR.Size = new System.Drawing.Size(784, 58);
            this.panelTopOne_KDR.TabIndex = 5;
            // 
            // buttonSaveFile_KDR
            // 
            this.buttonSaveFile_KDR.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonSaveFile_KDR.BackgroundImage")));
            this.buttonSaveFile_KDR.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.buttonSaveFile_KDR.Enabled = false;
            this.buttonSaveFile_KDR.Location = new System.Drawing.Point(138, 3);
            this.buttonSaveFile_KDR.Name = "buttonSaveFile_KDR";
            this.buttonSaveFile_KDR.Size = new System.Drawing.Size(61, 49);
            this.buttonSaveFile_KDR.TabIndex = 3;
            this.toolTip_KDR.SetToolTip(this.buttonSaveFile_KDR, "Сохранить результат в новый файл");
            this.buttonSaveFile_KDR.UseVisualStyleBackColor = true;
            this.buttonSaveFile_KDR.Click += new System.EventHandler(this.buttonSaveFile_KDR_Click);
            this.buttonSaveFile_KDR.MouseEnter += new System.EventHandler(this.buttonSaveFile_KDR_MouseEnter);
            // 
            // buttonHelp_KDR
            // 
            this.buttonHelp_KDR.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonHelp_KDR.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonHelp_KDR.BackgroundImage")));
            this.buttonHelp_KDR.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.buttonHelp_KDR.Location = new System.Drawing.Point(712, 3);
            this.buttonHelp_KDR.Name = "buttonHelp_KDR";
            this.buttonHelp_KDR.Size = new System.Drawing.Size(61, 49);
            this.buttonHelp_KDR.TabIndex = 2;
            this.toolTip_KDR.SetToolTip(this.buttonHelp_KDR, "О программе");
            this.buttonHelp_KDR.UseVisualStyleBackColor = true;
            this.buttonHelp_KDR.Click += new System.EventHandler(this.buttonHelp_KDR_Click);
            this.buttonHelp_KDR.MouseEnter += new System.EventHandler(this.buttonHelp_KDR_MouseEnter);
            // 
            // buttonLoadFile_KDR
            // 
            this.buttonLoadFile_KDR.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonLoadFile_KDR.BackgroundImage")));
            this.buttonLoadFile_KDR.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.buttonLoadFile_KDR.Enabled = false;
            this.buttonLoadFile_KDR.Location = new System.Drawing.Point(71, 3);
            this.buttonLoadFile_KDR.Name = "buttonLoadFile_KDR";
            this.buttonLoadFile_KDR.Size = new System.Drawing.Size(61, 49);
            this.buttonLoadFile_KDR.TabIndex = 1;
            this.toolTip_KDR.SetToolTip(this.buttonLoadFile_KDR, "Производит поиск в файле");
            this.buttonLoadFile_KDR.UseVisualStyleBackColor = true;
            this.buttonLoadFile_KDR.Click += new System.EventHandler(this.buttonLoadFile_KDR_Click);
            this.buttonLoadFile_KDR.MouseEnter += new System.EventHandler(this.buttonLoadFile_KDR_MouseEnter);
            // 
            // buttonOpenFile_KDR
            // 
            this.buttonOpenFile_KDR.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonOpenFile_KDR.BackgroundImage")));
            this.buttonOpenFile_KDR.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.buttonOpenFile_KDR.Location = new System.Drawing.Point(8, 3);
            this.buttonOpenFile_KDR.Name = "buttonOpenFile_KDR";
            this.buttonOpenFile_KDR.Size = new System.Drawing.Size(57, 49);
            this.buttonOpenFile_KDR.TabIndex = 0;
            this.toolTip_KDR.SetToolTip(this.buttonOpenFile_KDR, "Выбрать исходный файл загрузки");
            this.buttonOpenFile_KDR.UseVisualStyleBackColor = true;
            this.buttonOpenFile_KDR.Click += new System.EventHandler(this.buttonOpenFile_KDR_Click);
            this.buttonOpenFile_KDR.MouseEnter += new System.EventHandler(this.buttonOpenFile_KDR_MouseEnter);
            // 
            // groupBoxOutputData_KDR
            // 
            this.groupBoxOutputData_KDR.Controls.Add(this.dataGridViewOut_KDR);
            this.groupBoxOutputData_KDR.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxOutputData_KDR.Location = new System.Drawing.Point(5, 5);
            this.groupBoxOutputData_KDR.Name = "groupBoxOutputData_KDR";
            this.groupBoxOutputData_KDR.Padding = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.groupBoxOutputData_KDR.Size = new System.Drawing.Size(341, 266);
            this.groupBoxOutputData_KDR.TabIndex = 18;
            this.groupBoxOutputData_KDR.TabStop = false;
            this.groupBoxOutputData_KDR.Text = "Вывод данных:";
            // 
            // dataGridViewOut_KDR
            // 
            this.dataGridViewOut_KDR.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridViewOut_KDR.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewOut_KDR.ColumnHeadersVisible = false;
            this.dataGridViewOut_KDR.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewOut_KDR.Location = new System.Drawing.Point(5, 16);
            this.dataGridViewOut_KDR.Name = "dataGridViewOut_KDR";
            this.dataGridViewOut_KDR.RowHeadersVisible = false;
            this.dataGridViewOut_KDR.Size = new System.Drawing.Size(331, 247);
            this.dataGridViewOut_KDR.TabIndex = 1;
            // 
            // panelFill_KDR
            // 
            this.panelFill_KDR.Controls.Add(this.groupBoxOutputData_KDR);
            this.panelFill_KDR.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelFill_KDR.Location = new System.Drawing.Point(433, 135);
            this.panelFill_KDR.Name = "panelFill_KDR";
            this.panelFill_KDR.Padding = new System.Windows.Forms.Padding(5);
            this.panelFill_KDR.Size = new System.Drawing.Size(351, 276);
            this.panelFill_KDR.TabIndex = 9;
            // 
            // splitterL_KDR
            // 
            this.splitterL_KDR.Location = new System.Drawing.Point(433, 135);
            this.splitterL_KDR.Name = "splitterL_KDR";
            this.splitterL_KDR.Size = new System.Drawing.Size(5, 276);
            this.splitterL_KDR.TabIndex = 10;
            this.splitterL_KDR.TabStop = false;
            // 
            // openFileDialogTask_KDR
            // 
            this.openFileDialogTask_KDR.FileName = "openFileDialog1";
            // 
            // toolTip_KDR
            // 
            this.toolTip_KDR.IsBalloon = true;
            this.toolTip_KDR.ToolTipTitle = "Подсказка";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 411);
            this.Controls.Add(this.splitterL_KDR);
            this.Controls.Add(this.panelFill_KDR);
            this.Controls.Add(this.panelLeft_KDR);
            this.Controls.Add(this.panelTopTwo_KDR);
            this.Controls.Add(this.panelTopOne_KDR);
            this.MinimumSize = new System.Drawing.Size(800, 450);
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Спринт 6 | Таск 7 | Вариант 21 | Колчаков Д. Р.";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.panelLeft_KDR.ResumeLayout(false);
            this.groupBoxInputData_KDR.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewIn_KDR)).EndInit();
            this.panelTopTwo_KDR.ResumeLayout(false);
            this.groupBoxTask_KDR.ResumeLayout(false);
            this.groupBoxTask_KDR.PerformLayout();
            this.panelTopOne_KDR.ResumeLayout(false);
            this.groupBoxOutputData_KDR.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOut_KDR)).EndInit();
            this.panelFill_KDR.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panelLeft_KDR;
        private System.Windows.Forms.GroupBox groupBoxInputData_KDR;
        private System.Windows.Forms.Panel panelTopTwo_KDR;
        private System.Windows.Forms.GroupBox groupBoxTask_KDR;
        private System.Windows.Forms.Label labelTask_KDR;
        private System.Windows.Forms.Panel panelTopOne_KDR;
        private System.Windows.Forms.Button buttonHelp_KDR;
        private System.Windows.Forms.Button buttonLoadFile_KDR;
        private System.Windows.Forms.Button buttonOpenFile_KDR;
        private System.Windows.Forms.DataGridView dataGridViewIn_KDR;
        private System.Windows.Forms.GroupBox groupBoxOutputData_KDR;
        private System.Windows.Forms.DataGridView dataGridViewOut_KDR;
        private System.Windows.Forms.Panel panelFill_KDR;
        private System.Windows.Forms.Splitter splitterL_KDR;
        private System.Windows.Forms.Button buttonSaveFile_KDR;
        private System.Windows.Forms.OpenFileDialog openFileDialogTask_KDR;
        private System.Windows.Forms.ToolTip toolTip_KDR;
        private System.Windows.Forms.SaveFileDialog saveFileDialogTask_KDR;
    }
}

