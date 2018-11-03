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
    public partial class CategotyDetailsForm : Form
    {
        string name = "";
        bool active = false;
        string connectionString = "workstation id=StockControl.mssql.somee.com;packet size=4096;user id=levelupacademy_SQLLogin_1;pwd=3wwate8gu1;data source=StockControl.mssql.somee.com;persist security info=False;initial catalog=StockControl";

        public CategotyDetailsForm()
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

