
namespace Tyuiu.KolchakovDR.Sprint6.Task3.V13
{
    partial class FormMine
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMine));
            this.dataGridViewInData_KDR = new System.Windows.Forms.DataGridView();
            this.groupBoxTask_KDR = new System.Windows.Forms.GroupBox();
            this.labelTask_KDR = new System.Windows.Forms.Label();
            this.groupBoxOutputData_KDR = new System.Windows.Forms.GroupBox();
            this.labelRes_KDR = new System.Windows.Forms.Label();
            this.dataGridViewResData_KDR = new System.Windows.Forms.DataGridView();
            this.buttonHelp_KDR = new System.Windows.Forms.Button();
            this.buttonDone_KDR = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewInData_KDR)).BeginInit();
            this.groupBoxTask_KDR.SuspendLayout();
            this.groupBoxOutputData_KDR.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewResData_KDR)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewInData_KDR
            // 
            this.dataGridViewInData_KDR.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewInData_KDR.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewInData_KDR.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewInData_KDR.ColumnHeadersVisible = false;
            this.dataGridViewInData_KDR.EnableHeadersVisualStyles = false;
            this.dataGridViewInData_KDR.Location = new System.Drawing.Point(108, 133);
            this.dataGridViewInData_KDR.Name = "dataGridViewInData_KDR";
            this.dataGridViewInData_KDR.ReadOnly = true;
            this.dataGridViewInData_KDR.RowHeadersVisible = false;
            this.dataGridViewInData_KDR.Size = new System.Drawing.Size(188, 114);
            this.dataGridViewInData_KDR.TabIndex = 5;
            // 
            // groupBoxTask_KDR
            // 
            this.groupBoxTask_KDR.Controls.Add(this.dataGridViewInData_KDR);
            this.groupBoxTask_KDR.Controls.Add(this.labelTask_KDR);
            this.groupBoxTask_KDR.Location = new System.Drawing.Point(12, 12);
            this.groupBoxTask_KDR.Name = "groupBoxTask_KDR";
            this.groupBoxTask_KDR.Size = new System.Drawing.Size(415, 293);
            this.groupBoxTask_KDR.TabIndex = 15;
            this.groupBoxTask_KDR.TabStop = false;
            this.groupBoxTask_KDR.Text = "Условие";
            // 
            // labelTask_KDR
            // 
            this.labelTask_KDR.AutoSize = true;
            this.labelTask_KDR.Location = new System.Drawing.Point(23, 28);
            this.labelTask_KDR.Name = "labelTask_KDR";
            this.labelTask_KDR.Size = new System.Drawing.Size(311, 91);
            this.labelTask_KDR.TabIndex = 2;
            this.labelTask_KDR.Text = resources.GetString("labelTask_KDR.Text");
            // 
            // groupBoxOutputData_KDR
            // 
            this.groupBoxOutputData_KDR.Controls.Add(this.dataGridViewResData_KDR);
            this.groupBoxOutputData_KDR.Controls.Add(this.labelRes_KDR);
            this.groupBoxOutputData_KDR.Location = new System.Drawing.Point(433, 12);
            this.groupBoxOutputData_KDR.Name = "groupBoxOutputData_KDR";
            this.groupBoxOutputData_KDR.Size = new System.Drawing.Size(211, 261);
            this.groupBoxOutputData_KDR.TabIndex = 17;
            this.groupBoxOutputData_KDR.TabStop = false;
            this.groupBoxOutputData_KDR.Text = "Вывод данных";
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
            // dataGridViewResData_KDR
            // 
            this.dataGridViewResData_KDR.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewResData_KDR.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewResData_KDR.ColumnHeadersVisible = false;
            this.dataGridViewResData_KDR.Location = new System.Drawing.Point(9, 57);
            this.dataGridViewResData_KDR.Name = "dataGridViewResData_KDR";
            this.dataGridViewResData_KDR.ReadOnly = true;
            this.dataGridViewResData_KDR.RowHeadersVisible = false;
            this.dataGridViewResData_KDR.Size = new System.Drawing.Size(188, 114);
            this.dataGridViewResData_KDR.TabIndex = 6;
            // 
            // buttonHelp_KDR
            // 
            this.buttonHelp_KDR.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonHelp_KDR.Location = new System.Drawing.Point(476, 279);
            this.buttonHelp_KDR.Name = "buttonHelp_KDR";
            this.buttonHelp_KDR.Size = new System.Drawing.Size(27, 26);
            this.buttonHelp_KDR.TabIndex = 19;
            this.buttonHelp_KDR.Text = "?";
            this.buttonHelp_KDR.UseVisualStyleBackColor = true;
            this.buttonHelp_KDR.Click += new System.EventHandler(this.buttonHelp_KDR_Click);
            // 
            // buttonDone_KDR
            // 
            this.buttonDone_KDR.Location = new System.Drawing.Point(509, 279);
            this.buttonDone_KDR.Name = "buttonDone_KDR";
            this.buttonDone_KDR.Size = new System.Drawing.Size(135, 26);
            this.buttonDone_KDR.TabIndex = 18;
            this.buttonDone_KDR.Text = "Выполнить";
            this.buttonDone_KDR.UseVisualStyleBackColor = true;
            this.buttonDone_KDR.Click += new System.EventHandler(this.buttonDone_KDR_Click);
            // 
            // FormMine
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(656, 317);
            this.Controls.Add(this.buttonHelp_KDR);
            this.Controls.Add(this.buttonDone_KDR);
            this.Controls.Add(this.groupBoxTask_KDR);
            this.Controls.Add(this.groupBoxOutputData_KDR);
            this.MaximizeBox = false;
            this.Name = "FormMine";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Спринт 6 | Таск 3 | Вариант 13 | Колчаков Д. Р.";
            this.Load += new System.EventHandler(this.FormMine_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewInData_KDR)).EndInit();
            this.groupBoxTask_KDR.ResumeLayout(false);
            this.groupBoxTask_KDR.PerformLayout();
            this.groupBoxOutputData_KDR.ResumeLayout(false);
            this.groupBoxOutputData_KDR.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewResData_KDR)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewInData_KDR;
        private System.Windows.Forms.GroupBox groupBoxTask_KDR;
        private System.Windows.Forms.Label labelTask_KDR;
        private System.Windows.Forms.GroupBox groupBoxOutputData_KDR;
        private System.Windows.Forms.Label labelRes_KDR;
        private System.Windows.Forms.DataGridView dataGridViewResData_KDR;
        private System.Windows.Forms.Button buttonHelp_KDR;
        private System.Windows.Forms.Button buttonDone_KDR;
    }
}

