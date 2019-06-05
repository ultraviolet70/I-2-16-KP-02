using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Shop
{
    public partial class FormScreen : Form
    {

        public FormScreen()
        {
            InitializeComponent();
        }

        private void timerScreen_Tick(object sender, EventArgs e)
        {
            FormAuthoriz fa = new FormAuthoriz();
            fa.Show();
            this.Hide();
            timerScreen.Enabled = false;
        }
    }
}
