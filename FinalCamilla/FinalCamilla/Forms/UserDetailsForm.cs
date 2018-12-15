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
        User aux;
        string name = "";
        string email = "";
        string password = "";
        string confirm = "";
        string profile = "";
        bool active = false;
        List<UserProfile> profiles = new List<UserProfile>();
        string connectionString = "workstation id=StockControl.mssql.somee.com;packet size=4096;user id=levelupacademy_SQLLogin_1;pwd=3wwate8gu1;data source=StockControl.mssql.somee.com;persist security info=False;initial catalog=StockControl";

        public UserDetailsForm(int idUser, User user2)
        {

            InitializeComponent();
            aux = user2;
            cmbProfile.DisplayMember = "NAME";
            LoadComboBox();

            lblID.Text = idUser.ToString();

            SqlConnection sqlConnect = new SqlConnection(connectionString);

            if (!string.IsNullOrEmpty(lblID.Text))
            {
                try
                {

                    sqlConnect.Open();

                    SqlCommand cmd = new SqlCommand("SELECT * FROM [USER] WHERE ID = @id", sqlConnect);


                    cmd.Parameters.Add(new SqlParameter("@id", idUser));

                    User user = new User();

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            user.Id = Int32.Parse(reader["ID"].ToString());
                            user.Name = reader["NAME"].ToString();
                            user.Active = bool.Parse(reader["ACTIVE"].ToString());
                            user.Email = reader["EMAIL"].ToString();
                            user.Password = reader["PASSWORD"].ToString();



                        }
                    }

                    tbxName.Text = user.Name;
                    cbxActive.Checked = user.Active;
                    tbxEmail.Text = user.Email;
                    tbxPassword.Text = user.Password;

                }
                catch (Exception EX)
                {
                    MessageBox.Show("Erro ao carregar o produto");

                    throw;
                }
                finally
                {

                    sqlConnect.Close();
                }
            }
        }

        public UserDetailsForm(User user)
        {
            InitializeComponent();
            aux = user;
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

            if (string.IsNullOrEmpty(lblID.Text)) //-----
            {
                try
                {
                    GetData();
                    UserProfile up = (UserProfile)cmbProfile.SelectedItem;
                    User u = new User(name, password, email, up, active);
                    sqlConnect.Open();
                    string sql = "INSERT INTO [USER](NAME, PASSWORD, EMAIL, ACTIVE, FK_USERPROFILE) VALUES (@name, @password, @email, @active, @user)";

                    SqlCommand cmd = new SqlCommand(sql, sqlConnect);

                    cmd.Parameters.Add(new SqlParameter("@name", u.Name));
                    cmd.Parameters.Add(new SqlParameter("@password", UserHelper.Hash(u.Password)));
                    cmd.Parameters.Add(new SqlParameter("@email", u.Email));
                    cmd.Parameters.Add(new SqlParameter("@active", u.Active));
                    cmd.Parameters.Add(new SqlParameter("@user", u.UserProfile.Id));
                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Adicionado com sucesso!");
                    Log.SaveLog(sqlConnect,"Usuário Inserido", DateTime.Now, "Inserção");
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
            else
            {
                try
                {
                    GetData();
                    UserProfile up = (UserProfile)cmbProfile.SelectedItem;
                    sqlConnect.Open();
                    string sql = "UPDATE [USER](NAME, PASSWORD, EMAIL, ACTIVE, FK_USERPROFILE) VALUES (@name, @password, @email, @active, @user) WHERE ID = @id";

                    SqlCommand cmd = new SqlCommand(sql, sqlConnect);

                    cmd.Parameters.Add(new SqlParameter("@name", name));
                    cmd.Parameters.Add(new SqlParameter("@password", UserHelper.Hash(password)));
                    cmd.Parameters.Add(new SqlParameter("@email", email));
                    cmd.Parameters.Add(new SqlParameter("@active", active));
                    cmd.Parameters.Add(new SqlParameter("@user", up.Id));
                    cmd.Parameters.Add(new SqlParameter("@id", lblID.Text));
                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Altereções salvas com sucesso!");
                    Log.SaveLog(sqlConnect,"Usuário Editado", DateTime.Now, "Edição");
                }
                catch (Exception Ex)
                {
                    MessageBox.Show("Erro ao editar este usuário!" + "\n\n" + Ex.Message);
                    throw;
                }
                finally
                {
                    sqlConnect.Close();

                    UserAllForm mainForm = new UserAllForm(aux);
                    mainForm.Show();
                    this.Hide();
                }
            }
        }
        private void pbxBack_Click(object sender, EventArgs e)
        {
            UserAllForm udf = new UserAllForm(aux);
            udf.Show();
            this.Close();
        }

        private void pbxDelete_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(lblID.Text))
            {
                SqlConnection sqlConnect = new SqlConnection(connectionString);

                try

                {
                    sqlConnect.Open();
                    string sql = "UPDATE [USER] SET ACTIVE = @active WHERE ID = @id";

                    SqlCommand cmd = new SqlCommand(sql, sqlConnect);

                    cmd.Parameters.Add(new SqlParameter("@id", lblID.Text));
                    cmd.Parameters.Add(new SqlParameter("@active", false));

                    cmd.ExecuteNonQuery();

                    MessageBox.Show("usuário inativo!");
                    Log.SaveLog(sqlConnect,"Usuário Excluído", DateTime.Now, "Exclusão");
                }
                catch (Exception Ex)
                {
                    MessageBox.Show("Erro ao desativar este usuário!" + "\n\n" + Ex.Message);
                    throw;
                }
                finally
                {
                    sqlConnect.Close();
                }
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
    }
}
