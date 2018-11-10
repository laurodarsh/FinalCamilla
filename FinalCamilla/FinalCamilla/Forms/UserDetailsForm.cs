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
    public partial class UserDetailsForm : Form
    {
        string name = "";
        string email = "";
        string password = "";
        string confirm = "";
        string profile = "";
        bool active = false;
        List<UserProfile> profiles = new List<UserProfile>();
        string connectionString = "workstation id=StockControl.mssql.somee.com;packet size=4096;user id=levelupacademy_SQLLogin_1;pwd=3wwate8gu1;data source=StockControl.mssql.somee.com;persist security info=False;initial catalog=StockControl";

        public UserDetailsForm()
        {
            InitializeComponent();
            cmbProfile.DisplayMember = "NAME";
            LoadComboBox();
        }

        void LoadComboBox()
        {
            SqlConnection cn = new SqlConnection(connectionString);

            try
            {
                cn.Open();
                SqlCommand sqlCommand = new SqlCommand("SELECT * FROM USER_PROFILE", cn);

                SqlDataReader reader = sqlCommand.ExecuteReader();
                while (reader.Read())
                {
                    UserProfile u = new UserProfile(Int32.Parse(reader["ID"].ToString()), reader["NAME"].ToString(), bool.Parse(reader["ACTIVE"].ToString()));
                    profiles.Add(u);
                }
            }
            catch (Exception ex)
            {

            }
            finally
            {
                cn.Close();
            }
            foreach (UserProfile u in profiles)
            {
                cmbProfile.Items.Add(u);
            }
        }
        private void pbxSave_Click(object sender, EventArgs e)
        {
            SqlConnection sqlConnect = new SqlConnection(connectionString);
            try
            {
                GetData();
                UserProfile up = (UserProfile)cmbProfile.SelectedItem;
                User u = new User(name, password, email, up, active);
                sqlConnect.Open();
                string sql = "INSERT INTO [USER](NAME, PASSWORD, EMAIL, ACTIVE, FK_USERPROFILE) VALUES (@name, @password, @email, @active, @user)";

                SqlCommand cmd = new SqlCommand(sql, sqlConnect);

                cmd.Parameters.Add(new SqlParameter("@name", u.Name));
                cmd.Parameters.Add(new SqlParameter("@password", u.Password));
                cmd.Parameters.Add(new SqlParameter("@email", u.Email));
                cmd.Parameters.Add(new SqlParameter("@active", u.Active));
                cmd.Parameters.Add(new SqlParameter("@user", u.UserProfile.Id));
                cmd.ExecuteNonQuery();

                MessageBox.Show("Adicionado com sucesso!");
                CleanData();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao adicionar usuario!" + ex.Message);
                CleanData();
            }
            finally
            {
                sqlConnect.Close();

            }

        }

        void GetData()
        {
            name = tbxName.Text;
            email = tbxEmail.Text;
            password = tbxPassword.Text;
            confirm = tbxComfirm.Text;
            profile = cmbProfile.Text;
            if (cbxActive.Checked)
            {
                active = true;
            }
            else
            {
                active = false;
            }

        }
        void CleanData()
        {
            tbxName.Text = "";
            tbxEmail.Text = "";
            tbxPassword.Text = "";
            tbxComfirm.Text = "";
            cmbProfile.Text = "";
            cbxActive.Checked = false;
        }

        private void pbxBack_Click(object sender, EventArgs e)
        {
            UserDetailsForm udf = new UserDetailsForm();
            udf.Show();
            this.Close();
        }
    }
}
