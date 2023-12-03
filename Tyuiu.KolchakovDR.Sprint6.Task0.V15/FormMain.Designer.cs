
namespace Tyuiu.KolchakovDR.Sprint6.Task0.V15
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
            this.groupBoxTask_KDR = new System.Windows.Forms.GroupBox();
            this.labelTask_KDR = new System.Windows.Forms.Label();
            this.pictureBoxFormula_KDR = new System.Windows.Forms.PictureBox();
            this.groupBoxData_KDR = new System.Windows.Forms.GroupBox();
            this.labelX_KDR = new System.Windows.Forms.Label();
            this.textBoxVarX_KDR = new System.Windows.Forms.TextBox();
            this.groupBoxRes_KDR = new System.Windows.Forms.GroupBox();
            this.labelRes_KDR = new System.Windows.Forms.Label();
            this.textBoxRes_KDR = new System.Windows.Forms.TextBox();
            this.buttonDone_KDR = new System.Windows.Forms.Button();
            this.buttonHelp_KDR = new System.Windows.Forms.Button();
            this.groupBoxTask_KDR.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFormula_KDR)).BeginInit();
            this.groupBoxData_KDR.SuspendLayout();
            this.groupBoxRes_KDR.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxTask_KDR
            // 
            this.groupBoxTask_KDR.Controls.Add(this.labelTask_KDR);
            this.groupBoxTask_KDR.Controls.Add(this.pictureBoxFormula_KDR);
            this.groupBoxTask_KDR.Location = new System.Drawing.Point(12, 32);
            this.groupBoxTask_KDR.Name = "groupBoxTask_KDR";
            this.groupBoxTask_KDR.Size = new System.Drawing.Size(776, 193);
            this.groupBoxTask_KDR.TabIndex = 0;
            this.groupBoxTask_KDR.TabStop = false;
            this.groupBoxTask_KDR.Text = "Условие";
            // 
            // labelTask_KDR
            // 
            this.labelTask_KDR.AutoSize = true;
            this.labelTask_KDR.Location = new System.Drawing.Point(23, 28);
            this.labelTask_KDR.Name = "labelTask_KDR";
            this.labelTask_KDR.Size = new System.Drawing.Size(189, 13);
            this.labelTask_KDR.TabIndex = 2;
            this.labelTask_KDR.Text = "Вычислить выражение по формуле:";
            // 
            // pictureBoxFormula_KDR
            // 
            this.pictureBoxFormula_KDR.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxFormula_KDR.Image")));
            this.pictureBoxFormula_KDR.Location = new System.Drawing.Point(508, 19);
            this.pictureBoxFormula_KDR.Name = "pictureBoxFormula_KDR";
            this.pictureBoxFormula_KDR.Size = new System.Drawing.Size(248, 35);
            this.pictureBoxFormula_KDR.TabIndex = 0;
            this.pictureBoxFormula_KDR.TabStop = false;
            // 
            // groupBoxData_KDR
            // 
            this.groupBoxData_KDR.Controls.Add(this.labelX_KDR);
            this.groupBoxData_KDR.Controls.Add(this.textBoxVarX_KDR);
            this.groupBoxData_KDR.Location = new System.Drawing.Point(12, 231);
            this.groupBoxData_KDR.Name = "groupBoxData_KDR";
            this.groupBoxData_KDR.Size = new System.Drawing.Size(370, 111);
            this.groupBoxData_KDR.TabIndex = 1;
            this.groupBoxData_KDR.TabStop = false;
            this.groupBoxData_KDR.Text = "Исходные данные";
            // 
            // labelX_KDR
            // 
            this.labelX_KDR.AutoSize = true;
            this.labelX_KDR.Location = new System.Drawing.Point(23, 31);
            this.labelX_KDR.Name = "labelX_KDR";
            this.labelX_KDR.Size = new System.Drawing.Size(84, 13);
            this.labelX_KDR.TabIndex = 1;
            this.labelX_KDR.Text = "Переменная Х:";
            // 
            // textBoxVarX_KDR
            // 
            this.textBoxVarX_KDR.Location = new System.Drawing.Point(26, 47);
            this.textBoxVarX_KDR.Name = "textBoxVarX_KDR";
            this.textBoxVarX_KDR.Size = new System.Drawing.Size(100, 20);
            this.textBoxVarX_KDR.TabIndex = 0;
            this.textBoxVarX_KDR.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxVarX_KDR_KeyPress);
            // 
            // groupBoxRes_KDR
            // 
            this.groupBoxRes_KDR.Controls.Add(this.labelRes_KDR);
            this.groupBoxRes_KDR.Controls.Add(this.textBoxRes_KDR);
            this.groupBoxRes_KDR.Location = new System.Drawing.Point(388, 231);
            this.groupBoxRes_KDR.Name = "groupBoxRes_KDR";
            this.groupBoxRes_KDR.Size = new System.Drawing.Size(400, 111);
            this.groupBoxRes_KDR.TabIndex = 2;
            this.groupBoxRes_KDR.TabStop = false;
            this.groupBoxRes_KDR.Text = "Результат";
            // 
            // labelRes_KDR
            // 
            this.labelRes_KDR.AutoSize = true;
            this.labelRes_KDR.Location = new System.Drawing.Point(19, 31);
            this.labelRes_KDR.Name = "labelRes_KDR";
            this.labelRes_KDR.Size = new System.Drawing.Size(62, 13);
            this.labelRes_KDR.TabIndex = 2;
            this.labelRes_KDR.Text = "Результат:";
            this.labelRes_KDR.Click += new System.EventHandler(this.labelRes_KDR_Click);
            // 
            // textBoxRes_KDR
            // 
            this.textBoxRes_KDR.Location = new System.Drawing.Point(22, 47);
            this.textBoxRes_KDR.Name = "textBoxRes_KDR";
            this.textBoxRes_KDR.ReadOnly = true;
            this.textBoxRes_KDR.Size = new System.Drawing.Size(129, 20);
            this.textBoxRes_KDR.TabIndex = 2;
            // 
            // buttonDone_KDR
            // 
            this.buttonDone_KDR.Location = new System.Drawing.Point(633, 366);
            this.buttonDone_KDR.Name = "buttonDone_KDR";
            this.buttonDone_KDR.Size = new System.Drawing.Size(135, 39);
            this.buttonDone_KDR.TabIndex = 3;
            this.buttonDone_KDR.Text = "Выполнить";
            this.buttonDone_KDR.UseVisualStyleBackColor = true;
            this.buttonDone_KDR.Click += new System.EventHandler(this.buttonDone_KDR_Click);
            // 
            // buttonHelp_KDR
            // 
            this.buttonHelp_KDR.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonHelp_KDR.Location = new System.Drawing.Point(588, 366);
            this.buttonHelp_KDR.Name = "buttonHelp_KDR";
            this.buttonHelp_KDR.Size = new System.Drawing.Size(39, 39);
            this.buttonHelp_KDR.TabIndex = 4;
            this.buttonHelp_KDR.Text = "?";
            this.buttonHelp_KDR.UseVisualStyleBackColor = true;
            this.buttonHelp_KDR.Click += new System.EventHandler(this.buttonHelp_KDR_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonHelp_KDR);
            this.Controls.Add(this.buttonDone_KDR);
            this.Controls.Add(this.groupBoxRes_KDR);
            this.Controls.Add(this.groupBoxData_KDR);
            this.Controls.Add(this.groupBoxTask_KDR);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Спринт 6 | Таск 0 | Вариант 15 | Колчаков Д. Р.";
            this.groupBoxTask_KDR.ResumeLayout(false);
            this.groupBoxTask_KDR.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFormula_KDR)).EndInit();
            this.groupBoxData_KDR.ResumeLayout(false);
            this.groupBoxData_KDR.PerformLayout();
            this.groupBoxRes_KDR.ResumeLayout(false);
            this.groupBoxRes_KDR.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxTask_KDR;
        private System.Windows.Forms.GroupBox groupBoxData_KDR;
        private System.Windows.Forms.GroupBox groupBoxRes_KDR;
        private System.Windows.Forms.PictureBox pictureBoxFormula_KDR;
        private System.Windows.Forms.Label labelX_KDR;
        private System.Windows.Forms.TextBox textBoxVarX_KDR;
        private System.Windows.Forms.Label labelRes_KDR;
        private System.Windows.Forms.TextBox textBoxRes_KDR;
        private System.Windows.Forms.Button buttonDone_KDR;
        private System.Windows.Forms.Label labelTask_KDR;
        private System.Windows.Forms.Button buttonHelp_KDR;
    }
}

