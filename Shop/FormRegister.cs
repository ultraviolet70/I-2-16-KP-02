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
    public partial class FormRegister : Form
    {
        public FormRegister()
        {
            InitializeComponent();
            FormAuthoriz.sql.Open();
            SqlCommand command1 = new SqlCommand("SELECT Name_position FROM Position", FormAuthoriz.sql);
            SqlDataReader read1 = command1.ExecuteReader();
            while (read1.Read())
            {
                comboBoxPosition.Items.Add(read1.GetValue(0).ToString());
            }
            read1.Close();
            FormAuthoriz.sql.Close();
        }

        private void buttonReg_Click(object sender, EventArgs e)
        {
            try
            {
                string Regist = "INSERT INTO Accounts(Login_accounts, Password_accounts, Roles_id, Accounts_Logical_Delete) VALUES('" + textBoxLogin.Text + "', '" + cueTextBoxPassword.Text + "', 5, 0)";
                string CountLogin1 = "SELECT COUNT(Login_accounts) FROM Accounts WHERE Login_accounts = '" + textBoxLogin.Text + "'";
                string Emp = "INSERT INTO Employee(Login_employee, Surname_employee, Name_employee, Patronymic_employee, Position_id, Employee_Logical_Delete) VALUES('" + textBoxLogin.Text + "', '" + textBoxFam.Text + "', '" + textBoxName.Text + "', '" + textBoxMiddleName.Text + "', '" + (comboBoxPosition.SelectedIndex + 1) + "', 0)";
                FormAuthoriz.sql.Open();
                SqlCommand cmdLogin1 = new SqlCommand(CountLogin1, FormAuthoriz.sql);
                SqlCommand cmdRegistr1 = new SqlCommand(Regist, FormAuthoriz.sql);
                SqlCommand cmdRegistr2 = new SqlCommand(Emp, FormAuthoriz.sql);
                int count1 = Convert.ToInt32(cmdLogin1.ExecuteScalar());
                FormAuthoriz.sql.Close();
                if (cueTextBoxPassword.Text == textBoxReturnPassword.Text) //если пароль соответствует повторению
                {
                    if (count1 > 0) //если уже есть такой логин
                    {
                        MessageBox.Show("Данная учётная запись уже существует");
                    }
                    else //если новый логин
                    {
                        FormAuthoriz.sql.Open();
                        cmdRegistr1.ExecuteNonQuery();
                        cmdRegistr2.ExecuteNonQuery();
                        FormAuthoriz.sql.Close();
                        MessageBox.Show("Учетная запись успешно создана");
                        FormAuthoriz fa = new FormAuthoriz();
                        fa.Show();
                        this.Hide();
                    }
                }
                else //если не соответствует
                {
                    textBoxReturnPassword.BackColor = Color.BlueViolet;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Проверьте правильность заполнения полей", ex.ToString() );
            }
        }

        private void FormRegister_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void textBoxReturnPassword_TextChanged(object sender, EventArgs e)
        {
            if (cueTextBoxPassword.Text == "")
            {
                textBoxReturnPassword.BackColor = Color.Magenta;
            }
            else
            {
                textBoxReturnPassword.BackColor = Color.White;
            }
        }

        private void Check(object sender, EventArgs e)
        {
            if ((cueTextBoxPassword.Text != "") & (textBoxLogin.Text != "") & (textBoxReturnPassword.Text != "") & (textBoxFam.Text != "") & (textBoxName.Text != "") & (comboBoxPosition.Text != ""))
            {
                buttonReg.Enabled = true;
            }
        }

        private void checkBoxPassword_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxPassword.Checked)
            {
                cueTextBoxPassword.PasswordChar = '\0';
                textBoxReturnPassword.PasswordChar = '\0';
            }
            else
            {
                cueTextBoxPassword.PasswordChar = '❂';
                textBoxReturnPassword.PasswordChar = '❂';
            }
        }
    }
}
