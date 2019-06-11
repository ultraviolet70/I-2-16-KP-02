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
    public partial class FormAddCategory : Form
    {
        public FormAddCategory()
        {
            InitializeComponent();
        }

        private void FormAddCategory_Load(object sender, EventArgs e)
        {
            BackColor = (Color)FormMain.obj;
            GetData();
        }

        public SqlCommand command = new SqlCommand("Select [Name_product] as 'Категория товара' from [dbo].[Type_Product]");
        public void GetData()
        {
            Action act = () =>
            {
                command.Connection = FormAuthoriz.sql;
                command.Notification = null;
                SqlDependency dependency = new SqlDependency(command);
                SqlDependency.Start(FormAuthoriz.sql.ConnectionString);
                dependency.OnChange += new OnChangeEventHandler(OnDataChanget);
                FormAuthoriz.sql.Open();
                DataTable data = new DataTable();
                data.Load(command.ExecuteReader());
                dgvCategory.DataSource = data;
                FormAuthoriz.sql.Close();
            };
            Invoke(act);
        }

        public void OnDataChanget(object sender, SqlNotificationEventArgs e)
        {
            if (e.Info != SqlNotificationInfo.Invalid)
                GetData();
        }

        private void btnAddCategory_Click(object sender, EventArgs e)
        {
            try
            {
                FormAuthoriz.sql.Open();
                SqlCommand Add = new SqlCommand("Type_Product_Insert", FormAuthoriz.sql);
                Add.CommandType = CommandType.StoredProcedure;
                Add.Parameters.AddWithValue("@Name_product", tbCategory.Text);
                Add.ExecuteNonQuery();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                FormAuthoriz.sql.Close();
            }
            tbCategory.Clear();
        }

        private void btnDelCategory_Click(object sender, EventArgs e)
        {
            DataRowView id = (DataRowView)dgvCategory.CurrentRow.DataBoundItem;
            try
            {
                FormAuthoriz.sql.Open();
                SqlCommand del = new SqlCommand("Type_Product_Delete", FormAuthoriz.sql);
                if (MessageBox.Show("Вы действительно хотите удалить данную позицию из базы данных навсегда?", "Удаление", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    del.CommandType = CommandType.StoredProcedure;
                    del.Parameters.AddWithValue("@ID_Type_Product", (int)id["ID_Type_Product"]);
                    del.ExecuteNonQuery();
                }
                else
                {

                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                FormAuthoriz.sql.Close();
            }
        }
    }
}
