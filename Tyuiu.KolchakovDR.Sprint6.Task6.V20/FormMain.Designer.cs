
namespace Tyuiu.KolchakovDR.Sprint6.Task6.V20
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
            this.panelTopOne_KDR = new System.Windows.Forms.Panel();
            this.buttonHelp_KDR = new System.Windows.Forms.Button();
            this.buttonLoadFile_KDR = new System.Windows.Forms.Button();
            this.buttonOpenFile_KDR = new System.Windows.Forms.Button();
            this.panelTopTwo_KDR = new System.Windows.Forms.Panel();
            this.groupBoxTask_KDR = new System.Windows.Forms.GroupBox();
            this.labelTask_KDR = new System.Windows.Forms.Label();
            this.panelLeft_KDR = new System.Windows.Forms.Panel();
            this.groupBoxInputData_KDR = new System.Windows.Forms.GroupBox();
            this.textBoxIn_KDR = new System.Windows.Forms.TextBox();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.panelFill_KDR = new System.Windows.Forms.Panel();
            this.groupBoxOutputData_KDR = new System.Windows.Forms.GroupBox();
            this.textBoxOut_KDR = new System.Windows.Forms.TextBox();
            this.openFileDialogTask_KDR = new System.Windows.Forms.OpenFileDialog();
            this.toolTip_KDR = new System.Windows.Forms.ToolTip(this.components);
            this.panelTopOne_KDR.SuspendLayout();
            this.panelTopTwo_KDR.SuspendLayout();
            this.groupBoxTask_KDR.SuspendLayout();
            this.panelLeft_KDR.SuspendLayout();
            this.groupBoxInputData_KDR.SuspendLayout();
            this.panelFill_KDR.SuspendLayout();
            this.groupBoxOutputData_KDR.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelTopOne_KDR
            // 
            this.panelTopOne_KDR.Controls.Add(this.buttonHelp_KDR);
            this.panelTopOne_KDR.Controls.Add(this.buttonLoadFile_KDR);
            this.panelTopOne_KDR.Controls.Add(this.buttonOpenFile_KDR);
            this.panelTopOne_KDR.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTopOne_KDR.Location = new System.Drawing.Point(0, 0);
            this.panelTopOne_KDR.Name = "panelTopOne_KDR";
            this.panelTopOne_KDR.Size = new System.Drawing.Size(784, 58);
            this.panelTopOne_KDR.TabIndex = 0;
            // 
            // buttonHelp_KDR
            // 
            this.buttonHelp_KDR.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonHelp_KDR.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonHelp_KDR.BackgroundImage")));
            this.buttonHelp_KDR.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.buttonHelp_KDR.Location = new System.Drawing.Point(711, 3);
            this.buttonHelp_KDR.Name = "buttonHelp_KDR";
            this.buttonHelp_KDR.Size = new System.Drawing.Size(61, 49);
            this.buttonHelp_KDR.TabIndex = 2;
            this.toolTip_KDR.SetToolTip(this.buttonHelp_KDR, "О программе");
            this.buttonHelp_KDR.UseVisualStyleBackColor = true;
            this.buttonHelp_KDR.Click += new System.EventHandler(this.buttonHelp_KDR_Click);
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
            // 
            // buttonOpenFile_KDR
            // 
            this.buttonOpenFile_KDR.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonOpenFile_KDR.BackgroundImage")));
            this.buttonOpenFile_KDR.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.buttonOpenFile_KDR.Location = new System.Drawing.Point(8, 3);
            this.buttonOpenFile_KDR.Name = "buttonOpenFile_KDR";
            this.buttonOpenFile_KDR.Size = new System.Drawing.Size(57, 49);
            this.buttonOpenFile_KDR.TabIndex = 0;
            this.toolTip_KDR.SetToolTip(this.buttonOpenFile_KDR, "Открыть файл");
            this.buttonOpenFile_KDR.UseVisualStyleBackColor = true;
            this.buttonOpenFile_KDR.Click += new System.EventHandler(this.buttonOpenFile_KDR_Click);
            // 
            // panelTopTwo_KDR
            // 
            this.panelTopTwo_KDR.Controls.Add(this.groupBoxTask_KDR);
            this.panelTopTwo_KDR.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTopTwo_KDR.Location = new System.Drawing.Point(0, 58);
            this.panelTopTwo_KDR.Name = "panelTopTwo_KDR";
            this.panelTopTwo_KDR.Size = new System.Drawing.Size(784, 86);
            this.panelTopTwo_KDR.TabIndex = 1;
            // 
            // groupBoxTask_KDR
            // 
            this.groupBoxTask_KDR.Controls.Add(this.labelTask_KDR);
            this.groupBoxTask_KDR.Location = new System.Drawing.Point(3, 6);
            this.groupBoxTask_KDR.Name = "groupBoxTask_KDR";
            this.groupBoxTask_KDR.Padding = new System.Windows.Forms.Padding(10);
            this.groupBoxTask_KDR.Size = new System.Drawing.Size(769, 74);
            this.groupBoxTask_KDR.TabIndex = 17;
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
            this.labelTask_KDR.Size = new System.Drawing.Size(733, 36);
            this.labelTask_KDR.TabIndex = 2;
            this.labelTask_KDR.Text = resources.GetString("labelTask_KDR.Text");
            // 
            // panelLeft_KDR
            // 
            this.panelLeft_KDR.Controls.Add(this.groupBoxInputData_KDR);
            this.panelLeft_KDR.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelLeft_KDR.Location = new System.Drawing.Point(0, 144);
            this.panelLeft_KDR.Name = "panelLeft_KDR";
            this.panelLeft_KDR.Padding = new System.Windows.Forms.Padding(5);
            this.panelLeft_KDR.Size = new System.Drawing.Size(392, 267);
            this.panelLeft_KDR.TabIndex = 2;
            // 
            // groupBoxInputData_KDR
            // 
            this.groupBoxInputData_KDR.Controls.Add(this.textBoxIn_KDR);
            this.groupBoxInputData_KDR.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxInputData_KDR.Location = new System.Drawing.Point(5, 5);
            this.groupBoxInputData_KDR.Name = "groupBoxInputData_KDR";
            this.groupBoxInputData_KDR.Size = new System.Drawing.Size(382, 257);
            this.groupBoxInputData_KDR.TabIndex = 22;
            this.groupBoxInputData_KDR.TabStop = false;
            this.groupBoxInputData_KDR.Text = "Вывод данных:";
            // 
            // textBoxIn_KDR
            // 
            this.textBoxIn_KDR.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxIn_KDR.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxIn_KDR.Location = new System.Drawing.Point(3, 16);
            this.textBoxIn_KDR.Multiline = true;
            this.textBoxIn_KDR.Name = "textBoxIn_KDR";
            this.textBoxIn_KDR.ReadOnly = true;
            this.textBoxIn_KDR.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxIn_KDR.Size = new System.Drawing.Size(376, 238);
            this.textBoxIn_KDR.TabIndex = 21;
            this.textBoxIn_KDR.TabStop = false;
            // 
            // splitter1
            // 
            this.splitter1.Location = new System.Drawing.Point(392, 144);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(3, 267);
            this.splitter1.TabIndex = 3;
            this.splitter1.TabStop = false;
            // 
            // panelFill_KDR
            // 
            this.panelFill_KDR.Controls.Add(this.groupBoxOutputData_KDR);
            this.panelFill_KDR.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelFill_KDR.Location = new System.Drawing.Point(395, 144);
            this.panelFill_KDR.Name = "panelFill_KDR";
            this.panelFill_KDR.Padding = new System.Windows.Forms.Padding(5);
            this.panelFill_KDR.Size = new System.Drawing.Size(389, 267);
            this.panelFill_KDR.TabIndex = 4;
            // 
            // groupBoxOutputData_KDR
            // 
            this.groupBoxOutputData_KDR.Controls.Add(this.textBoxOut_KDR);
            this.groupBoxOutputData_KDR.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxOutputData_KDR.Location = new System.Drawing.Point(5, 5);
            this.groupBoxOutputData_KDR.Name = "groupBoxOutputData_KDR";
            this.groupBoxOutputData_KDR.Size = new System.Drawing.Size(379, 257);
            this.groupBoxOutputData_KDR.TabIndex = 18;
            this.groupBoxOutputData_KDR.TabStop = false;
            this.groupBoxOutputData_KDR.Text = "Вывод данных:";
            // 
            // textBoxOut_KDR
            // 
            this.textBoxOut_KDR.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxOut_KDR.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxOut_KDR.Location = new System.Drawing.Point(3, 16);
            this.textBoxOut_KDR.Multiline = true;
            this.textBoxOut_KDR.Name = "textBoxOut_KDR";
            this.textBoxOut_KDR.ReadOnly = true;
            this.textBoxOut_KDR.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxOut_KDR.Size = new System.Drawing.Size(373, 238);
            this.textBoxOut_KDR.TabIndex = 21;
            this.textBoxOut_KDR.TabStop = false;
            // 
            // openFileDialogTask_KDR
            // 
            this.openFileDialogTask_KDR.FileName = "openFileDialog1";
            // 
            // toolTip_KDR
            // 
            this.toolTip_KDR.ToolTipTitle = "Подсказка";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 411);
            this.Controls.Add(this.panelFill_KDR);
            this.Controls.Add(this.splitter1);
            this.Controls.Add(this.panelLeft_KDR);
            this.Controls.Add(this.panelTopTwo_KDR);
            this.Controls.Add(this.panelTopOne_KDR);
            this.MinimumSize = new System.Drawing.Size(800, 450);
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Спринт 6 | Таск 6 | Вариант 20 | Колчаков Д. Р.";
            this.panelTopOne_KDR.ResumeLayout(false);
            this.panelTopTwo_KDR.ResumeLayout(false);
            this.groupBoxTask_KDR.ResumeLayout(false);
            this.groupBoxTask_KDR.PerformLayout();
            this.panelLeft_KDR.ResumeLayout(false);
            this.groupBoxInputData_KDR.ResumeLayout(false);
            this.groupBoxInputData_KDR.PerformLayout();
            this.panelFill_KDR.ResumeLayout(false);
            this.groupBoxOutputData_KDR.ResumeLayout(false);
            this.groupBoxOutputData_KDR.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelTopOne_KDR;
        private System.Windows.Forms.Button buttonHelp_KDR;
        private System.Windows.Forms.Button buttonLoadFile_KDR;
        private System.Windows.Forms.Button buttonOpenFile_KDR;
        private System.Windows.Forms.Panel panelTopTwo_KDR;
        private System.Windows.Forms.Panel panelLeft_KDR;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.Panel panelFill_KDR;
        private System.Windows.Forms.GroupBox groupBoxTask_KDR;
        private System.Windows.Forms.Label labelTask_KDR;
        private System.Windows.Forms.GroupBox groupBoxInputData_KDR;
        private System.Windows.Forms.TextBox textBoxIn_KDR;
        private System.Windows.Forms.GroupBox groupBoxOutputData_KDR;
        private System.Windows.Forms.TextBox textBoxOut_KDR;
        private System.Windows.Forms.OpenFileDialog openFileDialogTask_KDR;
        private System.Windows.Forms.ToolTip toolTip_KDR;
    }
}

