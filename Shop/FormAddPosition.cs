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
    public partial class FormAddPosition : Form
    {
        public FormAddPosition()
        {
            InitializeComponent();
        }

        private void FormAddPosition_Load(object sender, EventArgs e)
        {
            BackColor = (Color)FormMain.obj;
            GetData();
        }

        public SqlCommand command = new SqlCommand("Select [Name_position] as 'Наименование должности' from [dbo].[Position]");
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
                dgvPosition.DataSource = data;
                FormAuthoriz.sql.Close();
            };
            Invoke(act);
        }

        public void OnDataChanget(object sender, SqlNotificationEventArgs e)
        {
            if (e.Info != SqlNotificationInfo.Invalid)
                GetData();
        }

        private void btnAddPosition_Click(object sender, EventArgs e)
        {
            try
            {
                FormAuthoriz.sql.Open();
                SqlCommand Add = new SqlCommand("Position_Insert", FormAuthoriz.sql);
                Add.CommandType = CommandType.StoredProcedure;
                Add.Parameters.AddWithValue("@Name_position", tbPosition.Text);
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
            tbPosition.Clear();
        }

        private void btnDelPosition_Click(object sender, EventArgs e)
        {
            DataRowView id = (DataRowView) dgvPosition.CurrentRow.DataBoundItem;
            try
            {
                FormAuthoriz.sql.Open();
                SqlCommand del = new SqlCommand("Position_Delete", FormAuthoriz.sql);
                if (MessageBox.Show("Вы действительно хотите удалить данную позицию из базы данных навсегда?", "Удаление", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    del.CommandType = CommandType.StoredProcedure;
                    del.Parameters.AddWithValue("@ID_Position", (int)id["ID_Position"]);
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
