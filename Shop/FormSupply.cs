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
            FormAuthoriz.sql.Open();
            SqlCommand command3 = new SqlCommand("SELECT Name_supplier FROM Supplier", FormAuthoriz.sql);
            SqlCommand command4 = new SqlCommand("SELECT Surname_employee FROM Employee", FormAuthoriz.sql);
            SqlCommand command5 = new SqlCommand("SELECT Name_product FROM Type_Product", FormAuthoriz.sql);

            SqlDataReader read3 = command3.ExecuteReader();
            while (read3.Read())
            {
                cbPost.Items.Add(read3.GetValue(0).ToString());
            }
            read3.Close();

            SqlDataReader read4 = command4.ExecuteReader();
            while (read4.Read())
            {
                cbEmployee.Items.Add(read4.GetValue(0).ToString());
            }
            read4.Close();

            SqlDataReader read5 = command5.ExecuteReader();
            while (read5.Read())
            {
                cbCategory.Items.Add(read5.GetValue(0).ToString());
            }
            read5.Close();

            FormAuthoriz.sql.Close();
        }

        private void FormSupply_Load(object sender, EventArgs e)
        {
            BackColor = (Color)FormMain.obj;
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
            this.Hide();
            FormMain formMain = new FormMain();
            formMain.Show();
        }

        private void btnPostInsert_Click(object sender, EventArgs e)
        {
            FormAddSupplier child1 = new FormAddSupplier(this);
            child1.Show();
        }

        private void btnKlientInsert_Click(object sender, EventArgs e)
        {
            FormAddCategory formAddCategory = new FormAddCategory();
            formAddCategory.Show();
        }
    }
}
