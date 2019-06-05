using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Shop
{
    public partial class FormMain : Form
    {
        public int BackForm = 1;

        public FormMain()
        {
            InitializeComponent();
        }

        private void FormMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            this.BackColor = Color.PapayaWhip;
            BackForm = 1;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            this.BackColor = Color.LightSkyBlue;
            BackForm = 2;
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            this.BackColor = Color.FromArgb(244, 249, 248);
            BackForm = 3;
        }

        private void buttonSetting_Click(object sender, EventArgs e)
        {
            if (panelColor.Visible == true)
            {
                panelColor.Visible = false;
            }
            else
            {
                panelColor.Visible = true;
            }
        }
    }
}
