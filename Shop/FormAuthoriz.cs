﻿using System;
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
    public partial class FormAuthoriz : Form
    {
        public static int dostup;
        public static SqlConnection sql = new SqlConnection("Data Source = DESKTOP-N7ITL14\\KATE;" +
                 "Initial Catalog = Shop;" +
                 "Persist Security Info = True; User ID = sa;" +
                 "Password = \"123\"");

        public FormAuthoriz()
        {
            InitializeComponent();
        }

        private void buttonReg_Click(object sender, EventArgs e)
        {
            FormRegister formRegister = new FormRegister();
            formRegister.Show();
            this.Hide();
        }

        private void FormAuthoriz_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void buttonEnter_Click(object sender, EventArgs e)//вход в приложение
        {
            string CountLogin1 = "SELECT COUNT(Login_accounts) FROM Accounts WHERE Login_accounts = '" + textBoxLogin.Text + "' and Password_accounts = '" + textBoxPassword.Text + "'";
            string Role = "SELECT Roles_ID FROM Accounts WHERE Login_accounts = '" + textBoxLogin.Text + "'";
            string AccessTest = "SELECT COUNT( Roles_ID ) FROM Accounts WHERE Roles_id > 0 ";
            sql.Open();
            SqlCommand cmdLogin1 = new SqlCommand(CountLogin1, sql);
            int count1 = Convert.ToInt32(cmdLogin1.ExecuteScalar());
            SqlCommand cmdLogin2 = new SqlCommand(Role, sql);
            int count2 = Convert.ToInt32(cmdLogin2.ExecuteScalar());
            SqlCommand cmdAccess = new SqlCommand(AccessTest, sql);
            int count3 = Convert.ToInt32(cmdAccess.ExecuteScalar());
            sql.Close();
            if (count1 > 0) //если существует
            {
                if (count3 > 0) // если доступ есть
                {
                    sql.Open();
                    SqlCommand cmdRole = new SqlCommand(Role, sql);
                    dostup = Convert.ToInt32(cmdRole.ExecuteScalar());
                    sql.Close();
                    MainForm mf = new MainForm();
                    mf.Show();
                    this.Hide();
                }
                else //если доступа нет
                {
                    MessageBox.Show("Нет доступа");
                }
            }
            else //если пароль неправильный  
            {
                MessageBox.Show("Неверный логин или пароль!");
            }
        }

        private void Check(object sender, EventArgs e)
        {
            if ((textBoxPassword.Text != "") & (textBoxLogin.Text != ""))
            {
                buttonEnter.Enabled = true;
            }
        }

        private void checkBoxPassword_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxPassword.Checked)
            {
                textBoxPassword.PasswordChar = '\0';
            }
            else
            {
                textBoxPassword.PasswordChar = '❂';
            }
        }
    }
}
