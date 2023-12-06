using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tyuiu.KolchakovDR.Sprint6.Task6.V20
{
    public partial class FormAbout : Form
    {
        public FormAbout()
        {
            InitializeComponent();
        }

        private void buttonAccept_KDR_Click(object sender, EventArgs e)
        {
            buttonAccept2_KDR.Visible = true;
            pictureMe1_KDR.Visible = true;
            pictureMe2_KDR.Visible = true;
            pictureMe3_KDR.Visible = true;
            pictureBoxMe_KDR.Visible = true;
            buttonAccept_KDR.Visible = false;
        }

        private void buttonAccept2_KDR_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
