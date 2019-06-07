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
    public partial class AddClient : Form
    {
        DBProcedure DBProcedure = new DBProcedure();
        public AddClient()
        {
            InitializeComponent();
        }

        private void AddClient_Load(object sender, EventArgs e)
        {
            BackColor = (Color)FormMain.obj;
        }

        private void buttonAddClient_Click(object sender, EventArgs e)
        {
            DBProcedure.Client_Insert(textBoxSurnameClient.Text, textBoxNameClient.Text, cueTextBoxMiddleNameClient.Text, cueTextBoxPhoneClient.Text, textBoxEmailClient.Text);

        }
    }
}
