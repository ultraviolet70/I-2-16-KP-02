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

        
        public FormMain()
        {
            InitializeComponent();
        }

        private void FormMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void buttonCreateOrder_Click(object sender, EventArgs e)
        { 
            FormCreateOrder formCreateOrder = new FormCreateOrder();
            formCreateOrder.Show();
            this.Hide();
        }

        private void buttonSettingColor_Click(object sender, EventArgs e)
        {
            //return;
            // установка цвета формы
            FormColor(sender);

        }

        public static object obj= Color.FromArgb(244, 249, 248);

        private void FormColor(object sender)
        {
            
            //FormCreateOrder order = new FormCreateOrder();
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                BackColor = colorDialog1.Color;               
                obj = colorDialog1.Color;
            }
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            BackColor = (Color)FormMain.obj;
        }
    }
}
