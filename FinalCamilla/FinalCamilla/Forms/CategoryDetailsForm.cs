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
    public partial class CategoryDetailsForm : Form
    {
        string name = "";
        bool active = false;
        string connectionString = "workstation id=StockControl.mssql.somee.com;packet size=4096;user id=levelupacademy_SQLLogin_1;pwd=3wwate8gu1;data source=StockControl.mssql.somee.com;persist security info=False;initial catalog=StockControl";
        public CategoryDetailsForm(int idCategory)
        {

            InitializeComponent();

            lblID.Text = idCategory.ToString(); 

            SqlConnection sqlConnect = new SqlConnection(connectionString);

            if (!string.IsNullOrEmpty(lblID.Text))
            {
                try
                {
                    
                    sqlConnect.Open();

                    SqlCommand cmd = new SqlCommand("SELECT * FROM CATEGORY WHERE ID = @id", sqlConnect);
                   

                    cmd.Parameters.Add(new SqlParameter("@id", idCategory));

                    Category category = new Category(); 

                    using (SqlDataReader reader = cmd.ExecuteReader()) 
                    {
                        while (reader.Read())
                        {
                            category.Id = Int32.Parse(reader["ID"].ToString());
                            category.Name = reader["NAME"].ToString();
                            category.Active = bool.Parse(reader["ACTIVE"].ToString());





                        }
                    }

                    tbxCategory.Text = category.Name;
                    cbxActive.Checked = category.Active;


                }
                catch (Exception EX)
                {
                    MessageBox.Show("Problema ao carregar!");
                    throw;
                }
                finally
                {
                    
                    sqlConnect.Close();
                }
            }
        }

        public CategoryDetailsForm()
        {
            InitializeComponent();
        }

        private void pbxBack_Click(object sender, EventArgs e)
        {
            CategoryAllForm caf = new CategoryAllForm();
            caf.Show();
            this.Close();
        }

        private void pbxSave_Click(object sender, EventArgs e)
        {
            SqlConnection sqlConnect = new SqlConnection(connectionString);
            try
            {
                GetData();
                Category c = new Category(name, active);
                                   
                    
             sqlConnect.Open();   string sql = "INSERT INTO CATEGORY(NAME, ACTIVE) VALUES (@name, @active)";

                SqlCommand cmd = new SqlCommand(sql, sqlConnect);

                cmd.Parameters.Add(new SqlParameter("@name", c.Name));
                cmd.Parameters.Add(new SqlParameter("@active", c.Active));

                cmd.ExecuteNonQuery();

                MessageBox.Show("Adicionado com sucesso!");
                CleanData();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao adicionar categoria!" + ex.Message);
                CleanData();
            }
            finally
            {
                sqlConnect.Close();
            }

        }

        private void pbxDelete_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(lblID.Text)) 
            {
                SqlConnection sqlConnect = new SqlConnection(connectionString);

                try
 
                {
                    sqlConnect.Open();
                    string sql = "UPDATE CATEGORY SET ACTIVE = @active WHERE ID = @id";

                    SqlCommand cmd = new SqlCommand(sql, sqlConnect);

                    cmd.Parameters.Add(new SqlParameter("@id", lblID.Text));
                    cmd.Parameters.Add(new SqlParameter("@active", false));

                    cmd.ExecuteNonQuery();

                    MessageBox.Show("categoria inativa!");
                }
                catch (Exception Ex)
                {
                    MessageBox.Show("Erro ao desativar esta categoria!" + "\n\n" + Ex.Message);
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
            name = tbxCategory.Text;
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
            tbxCategory.Text = "";
            cbxActive.Checked = false;
        }

        
    }


}

