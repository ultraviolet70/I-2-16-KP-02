using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Shop
{
    public partial class FormCreateOrder : Form
    {
        public FormCreateOrder()
        {
            InitializeComponent();
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormMain formMain = new FormMain();
            formMain.Show();
        }

        private void FormCreateOrder_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void FormCreateOrder_Load(object sender, EventArgs e)
        {
            BackColor = (Color)FormMain.obj;

            string query1 = "SELECT ID_Client, Surname_client as 'Фамилия клиента', Name_client as 'Имя клиента', Patronymic_client as 'Отчество клиента',Number_client as 'Контактный телефон', Email_client as 'Электронная почта', Client_Logical_Delete FROM Client";
            DataTable table1 = new DataTable();
            SqlDataAdapter adapter1 = new SqlDataAdapter(query1, FormAuthoriz.sql);
            adapter1.Fill(table1);
            dataGridViewClient.DataSource = table1;
            dataGridViewClient.Columns[0].Visible = false;
            dataGridViewClient.Columns[6].Visible = false;
        }

        private void buttonAdd1_Click(object sender, EventArgs e)
        {
            AddClient addClient = new AddClient();
            addClient.Show();
        }
    }
}
