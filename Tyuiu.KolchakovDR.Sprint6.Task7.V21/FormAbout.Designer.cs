
namespace Tyuiu.KolchakovDR.Sprint6.Task7.V21
{
    partial class FormAbout
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAbout));
            this.buttonAccept_KDR = new System.Windows.Forms.Button();
            this.labelInfo_KDR = new System.Windows.Forms.Label();
            this.pictureBoxTrueMe_KDR = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTrueMe_KDR)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonAccept_KDR
            // 
            this.buttonAccept_KDR.Location = new System.Drawing.Point(318, 117);
            this.buttonAccept_KDR.Name = "buttonAccept_KDR";
            this.buttonAccept_KDR.Size = new System.Drawing.Size(75, 23);
            this.buttonAccept_KDR.TabIndex = 10;
            this.buttonAccept_KDR.Text = "Согласен";
            this.buttonAccept_KDR.UseVisualStyleBackColor = true;
            this.buttonAccept_KDR.Click += new System.EventHandler(this.buttonAccept_KDR_Click);
            // 
            // labelInfo_KDR
            // 
            this.labelInfo_KDR.AutoSize = true;
            this.labelInfo_KDR.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelInfo_KDR.Location = new System.Drawing.Point(131, 9);
            this.labelInfo_KDR.Name = "labelInfo_KDR";
            this.labelInfo_KDR.Size = new System.Drawing.Size(276, 91);
            this.labelInfo_KDR.TabIndex = 9;
            this.labelInfo_KDR.Text = "Разработчик: Колчаков Д. Р.\r\nГруппа ИИПб-23-2\r\n\r\nЛучшая цитата: \"я крутой.\"\r\n\r\n\r\n" +
    "Внутренне имя: Tyuiu.KolchakovDR.Sprint6.Task6.V20";
            // 
            // pictureBoxTrueMe_KDR
            // 
            this.pictureBoxTrueMe_KDR.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxTrueMe_KDR.Image")));
            this.pictureBoxTrueMe_KDR.Location = new System.Drawing.Point(0, 0);
            this.pictureBoxTrueMe_KDR.Name = "pictureBoxTrueMe_KDR";
            this.pictureBoxTrueMe_KDR.Size = new System.Drawing.Size(126, 152);
            this.pictureBoxTrueMe_KDR.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxTrueMe_KDR.TabIndex = 15;
            this.pictureBoxTrueMe_KDR.TabStop = false;
            // 
            // FormAbout
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(419, 152);
            this.Controls.Add(this.buttonAccept_KDR);
            this.Controls.Add(this.labelInfo_KDR);
            this.Controls.Add(this.pictureBoxTrueMe_KDR);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(435, 191);
            this.Name = "FormAbout";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "О программе";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTrueMe_KDR)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button buttonAccept_KDR;
        private System.Windows.Forms.Label labelInfo_KDR;
        private System.Windows.Forms.PictureBox pictureBoxTrueMe_KDR;
    }
}