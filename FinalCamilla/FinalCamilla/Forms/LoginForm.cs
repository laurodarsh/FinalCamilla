using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalCamilla.Forms
{
    public partial class LoginForm : Form
    {
        string connectionString = "workstation id=StockControl.mssql.somee.com;packet size=4096";


        public LoginForm()
        {
            InitializeComponent();
        }

        private void lblForgotPassword_MouseEnter(object sender, EventArgs e)
        {
            
        }

        private void lblForgotPassword_MouseLeave(object sender, EventArgs e)
        {

        }

        private void lblForgotPassword_DoubleClick(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            HomeForm lf = new HomeForm();
            lf.Show();
            this.Close();

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("http://levelupacademy.com.br/");
        }
    }
}
