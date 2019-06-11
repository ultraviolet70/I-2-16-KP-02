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

        public void Vybor(bool Sale, bool Stock, bool Report, bool Employee) //видимость кнопок
        {
            buttonCreateOrder.Visible = Sale;
            buttonTovar.Visible = Stock;
            buttonCreateDoc.Visible = Report;
            buttonAcc.Visible = Employee;
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            BackColor = (Color)FormMain.obj;

            switch (FormAuthoriz.dostup)
            {
                case (1):
                    Vybor(true, true, true,true); //Администратор
                    break;
                case (2):
                    Vybor(true, false, false,false); //Продажи
                    break;
                case (3):
                    Vybor(false, true, false,false); //Склад
                    break;
                case (4):
                    Vybor(false, false, false,true); //Бухгалтерия
                    break;
                case (5):
                    Vybor(false, false, false,false); //Нет доступа
                    break;
            }
        }

        private void buttonTovar_Click(object sender, EventArgs e)
        {
            FormSupply formSupply = new FormSupply();
            formSupply.Show();
            this.Hide();
        }

        private void buttonAcc_Click(object sender, EventArgs e)
        {
            FormEmployee formEmployee = new FormEmployee();
            formEmployee.Show();
            this.Hide();
        }

        private void buttonCreateDoc_Click(object sender, EventArgs e)
        {
            FormAddDocument formAddDocument = new FormAddDocument();
            formAddDocument.Show();
            this.Hide();
        }
    }
}
