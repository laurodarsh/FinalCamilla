using FinalCamilla.Classes;
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

namespace FinalCamilla.Forms
{
    public partial class ForgetPassword : Form
    {
        string Name1 = "";
        string connectionString = "workstation id=StockControl.mssql.somee.com;packet size=4096;user id=levelupacademy_SQLLogin_1;pwd=3wwate8gu1;data source=StockControl.mssql.somee.com;persist security info=False;initial catalog=StockControl";
        bool updated = true;

        public ForgetPassword()
        {
            InitializeComponent();
        }



        void UpdatePassword()
        {
            User user = UserHelper.SelectByName(tbxEmailForget.Text);

            if (user.Name == null)
            {
                MessageBox.Show("Usuário não encontrado");
                updated = false;
            }
            else
            {
                SqlConnection sqlConnect = new SqlConnection(connectionString);
                Random rnd = new Random();
                int randomPassword = rnd.Next(1, 1000);

                try
                {
                    EmailHelper.SendEmail(user.Email, randomPassword);


                    sqlConnect.Open();
                    string sql = "UPDATE [USER] SET PASSWORD = @password Where ID = @id";

                    SqlCommand cmd = new SqlCommand(sql, sqlConnect);
                    cmd.Parameters.Add(new SqlParameter("@password", UserHelper.Hash(randomPassword.ToString())));

                    cmd.Parameters.Add(new SqlParameter("@id", user.Id));
                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Uma nova senha foi enviada para seu e-mail!");
                    Log.SaveLog(sqlConnect, "Usuário Editado", DateTime.Now, "Edição");
                }
                catch (Exception Ex)
                {
                    MessageBox.Show("Erro ao enviar nova senha!" + "\n\n" + Ex.Message);
                    updated = false;
                    throw;
                }
                finally
                {
                    sqlConnect.Close();
                }
            }
        }

        private void btnForgetPassword_Click(object sender, EventArgs e)
        {
            if (tbxEmailForget.Text.Length > 0)
            {
                UpdatePassword();
                if (updated)
                {
                    this.Close();
                    LoginForm lgf = new LoginForm();
                    lgf.Show();
                }
            }

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            LoginForm lgf = new LoginForm();
            lgf.Show();
            this.Hide();
        }
    }
}
