using FinalCamilla.Classes;
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
        string login = "";
        string password = "";
        User user;

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
            try
            {
                GetData();

                if (CheckLogin(password, login))
                {
                    HomeForm mainForm = new HomeForm(user);
                    mainForm.Show();
                    this.Hide();
                }
                else
                {
                    CleanData();
                    MessageBox.Show("Usuário ou senha incorretos!");
                }

            }
            catch (Exception ex)
            {
                CleanData();
                MessageBox.Show(ex.Message);
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("http://levelupacademy.com.br/");
        }
        private bool CheckLogin(string password, string name)
        {
             user = UserHelper.SelectByName(name);

            if (user != null)
            {
                if (UserHelper.Hash(password) == user.Password)
                {
                    return true;
                }
            }
            return false;
        }
        void GetData()
        {
            login = tbxUser.Text;
            password = tbxPassword.Text;
                
        }
        void CleanData()
        {
            tbxUser.Text = "";
            tbxPassword.Text = "";
        }




    }
}

