﻿using System;
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
    public partial class FormAddSupplier : Form
    {
        public FormSupply otherForm1;

        public FormAddSupplier(FormSupply form2)
        {
            InitializeComponent();
            otherForm1 = form2;
        }

        private void FormAddSupplier_Load(object sender, EventArgs e)
        {
            BackColor = (Color)FormMain.obj;
            GetData();
            dgvSupplier.Columns["ID_Supplier"].Visible = false;
        }

        public SqlCommand command = new SqlCommand("Select [ID_Supplier], [Name_supplier] as 'Наименование поставщика', [Contact_number] as 'Контактный телефон', [Email_supplier] as 'Электронная почта'  from [dbo].[Supplier]");
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
                dgvSupplier.DataSource = data;
                FormAuthoriz.sql.Close();
            };
            Invoke(act);
        }

        public void OnDataChanget(object sender, SqlNotificationEventArgs e)
        {
            if (e.Info != SqlNotificationInfo.Invalid)
                GetData();
        }

        private void buttonAddSupplier_Click(object sender, EventArgs e)
        {
            try
            {
                FormAuthoriz.sql.Open();
                SqlCommand Add = new SqlCommand("Supplier_Insert", FormAuthoriz.sql);
                Add.CommandType = CommandType.StoredProcedure;
                Add.Parameters.AddWithValue("@Name_supplier", textBoxNameSupplier.Text);
                Add.Parameters.AddWithValue("@Contact_number", textBoxNameSupplier.Text);
                Add.Parameters.AddWithValue("@Email_supplier", textBoxNameSupplier.Text);
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
            textBoxNameSupplier.Clear();
            cueTextBoxPhoneSupplier.Clear();
            cueTextBoxEmailSupplier.Clear();
        }

        private void buttonDelSupplier_Click(object sender, EventArgs e)
        {
            DataRowView id = (DataRowView)dgvSupplier.CurrentRow.DataBoundItem;
            try
            {
                FormAuthoriz.sql.Open();
                SqlCommand del = new SqlCommand("Supplier_Delete", FormAuthoriz.sql);
                if (MessageBox.Show("Вы действительно хотите удалить данную позицию из базы данных навсегда?", "Удаление", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    del.CommandType = CommandType.StoredProcedure;
                    del.Parameters.AddWithValue("@ID_Supplier", (int)id["ID_Supplier"]);
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
