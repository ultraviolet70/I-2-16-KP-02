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
    public partial class FormSupply : Form
    {
        public FormSupply()
        {
            InitializeComponent();
        }

        private void FormSupply_Load(object sender, EventArgs e)
        {
            BackColor = (Color)FormMain.obj;

            string query2 = "SELECT ID_Supplier, Name_supplier as 'Наименование поставщика', Contact_number as 'Контактный номер', Email_supplier as 'Электронная почта', Supplier_Logical_Delete FROM Supplier";
            DataTable table2 = new DataTable();
            SqlDataAdapter adapter2 = new SqlDataAdapter(query2, FormAuthoriz.sql);
            adapter2.Fill(table2);
            dataGridViewSupplier.DataSource = table2;
            dataGridViewSupplier.Columns[0].Visible = false;
            dataGridViewSupplier.Columns[4].Visible = false;
        }

        private void FormSupply_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void buttonBack2_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormMain formMain = new FormMain();
            formMain.Show();
        }

        private void buttonAddSup_Click(object sender, EventArgs e)
        {
            FormAddSupplier addSupplier = new FormAddSupplier();
            addSupplier.Show();
        }
    }
}
