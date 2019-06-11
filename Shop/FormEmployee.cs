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
    public partial class FormEmployee : Form
    {
        public FormEmployee()
        {
            InitializeComponent();
        }

        private void buttonBack3_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormMain formMain = new FormMain();
            formMain.Show();
        }

        private void FormEmployee_Load(object sender, EventArgs e)
        {
            BackColor = (Color)FormMain.obj;
            GetData3();
        }

        private void buttonAddPosition_Click(object sender, EventArgs e)
        {
            FormAddPosition formAddPosition = new FormAddPosition();
            formAddPosition.Show();
        }

        public SqlCommand command3 = new SqlCommand("Select [Login_accounts] as 'Логин', [Password_accounts] as 'Пароль', [Roles_ID] as 'Роль' from [dbo].[Accounts]");
        public void GetData3()
        {
            Action act = () =>
            {
                command3.Connection = FormAuthoriz.sql;
                command3.Notification = null;
                SqlDependency dependency = new SqlDependency(command3);
                SqlDependency.Start(FormAuthoriz.sql.ConnectionString);
                dependency.OnChange += new OnChangeEventHandler(OnDataChanget3);
                FormAuthoriz.sql.Open();
                DataTable data = new DataTable();
                data.Load(command3.ExecuteReader());
                dataGridViewAcc.DataSource = data;
                FormAuthoriz.sql.Close();
            };
            Invoke(act);
        }

        public void OnDataChanget3(object sender, SqlNotificationEventArgs e)
        {
            if (e.Info != SqlNotificationInfo.Invalid)
                GetData3();
        }

        private void FormEmployee_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
