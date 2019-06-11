using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Shop
{
    public partial class FormAddClient : Form
    {
        public FormCreateOrder otherForm;
        public FormAddClient(FormCreateOrder form1)
        {
            InitializeComponent();
            otherForm = form1;
        }

        private void AddClient_Load(object sender, EventArgs e)
        {
            BackColor = (Color)FormMain.obj;
            GetData();
            dgvClient.Columns["ID_Client"].Visible = false;
        }

        public SqlCommand command = new SqlCommand("Select [ID_Client], [Surname_client] as 'Фамилия клиента', [Name_client] as 'Имя клиента', [Patronymic_client] as 'Отчество клиента', [Number_client] as 'Контактный номер', [Email_client] as 'Почта клиента' from [dbo].[Client]");
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
                dgvClient.DataSource = data;
                FormAuthoriz.sql.Close();
            };
            Invoke(act);
        }

        public void OnDataChanget(object sender, SqlNotificationEventArgs e)
        {
            if (e.Info != SqlNotificationInfo.Invalid)
                GetData();
        }

        private void buttonAddClient_Click(object sender, EventArgs e)
        {
            try
            {
                FormAuthoriz.sql.Open();
                SqlCommand Add = new SqlCommand("Client_Insert", FormAuthoriz.sql);
                Add.CommandType = CommandType.StoredProcedure;
                Add.Parameters.AddWithValue("@Surname_client",textBoxSurnameClient.Text);
                Add.Parameters.AddWithValue("@Name_client", textBoxNameClient.Text);
                Add.Parameters.AddWithValue("@Patronymic_client", cueTextBoxMiddleNameClient.Text);
                Add.Parameters.AddWithValue("@Number_client", Convert.ToBase64String(Aes256.ToAes256(cueTextBoxPhoneClient.Text)));
                Add.Parameters.AddWithValue("@Email_client", cueTextBoxEmailClient.Text);
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
            textBoxSurnameClient.Clear();
            textBoxNameClient.Clear();
            cueTextBoxMiddleNameClient.Clear();
            cueTextBoxPhoneClient.Clear();
            cueTextBoxEmailClient.Clear();
        }

        private void buttonDelClient_Click(object sender, EventArgs e)
        {
            DataRowView id = (DataRowView)dgvClient.CurrentRow.DataBoundItem;
            try
            {
                FormAuthoriz.sql.Open();
                SqlCommand del = new SqlCommand("Client_Delete", FormAuthoriz.sql);
                if (MessageBox.Show("Вы действительно хотите удалить данную позицию из базы данных навсегда?", "Удаление", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    del.CommandType = CommandType.StoredProcedure;
                    del.Parameters.AddWithValue("@ID_Client", (int)id["ID_Client"]);
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
