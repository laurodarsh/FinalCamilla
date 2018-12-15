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
    public partial class CategoryAllForm : Form
    {
        User aux;
        string search = "";

        string connectionString = "workstation id=StockControl.mssql.somee.com;packet size=4096;user id=levelupacademy_SQLLogin_1;pwd=3wwate8gu1;data source=StockControl.mssql.somee.com;persist security info=False;initial catalog=StockControl";

        public CategoryAllForm(User user)
        {
            InitializeComponent();
            aux = user;
            ShowData();
            ResizeDataGridView();
        }
        private void ShowData()
        {
            SqlConnection sqlConnect = new SqlConnection(connectionString);

            try
            {
                sqlConnect.Open();
                SqlCommand cmd;

                if (aux.UserProfile.Name != "Gerente")
                {
                    cmd = new SqlCommand("SELECT * FROM CATEGORY WHERE ACTIVE= @active", sqlConnect);
                    cmd.Parameters.Add(new SqlParameter("@active", true));
                }
                else
                {
                    cmd = new SqlCommand("SELECT * FROM CATEGORY", sqlConnect);
                }



                // SqlDataReader reader = cmd.ExecuteReader();

                cmd.ExecuteNonQuery();

                DataTable dt = new DataTable();
                SqlDataAdapter sqlDtAdapter = new SqlDataAdapter(cmd);
                sqlDtAdapter.Fill(dt);

                dgvCategory.DataSource = dt;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao conectar. " + ex.Message);
            }
            finally
            {
                sqlConnect.Close();
            }
        }

        private void ResizeDataGridView()
        {
            dgvCategory.Columns["ID"].Visible = false;
            dgvCategory.Columns["NAME"].HeaderText = "Nome";
            dgvCategory.Columns["ACTIVE"].HeaderText = "Ativo";

            foreach (DataGridViewColumn col in dgvCategory.Columns)
            {
                col.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                col.HeaderCell.Style.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Pixel);
            }
        }

        private void pbxSearchCategory_Click(object sender, EventArgs e)
        {
            string optionForm = "CategoryForm";
            string optionString = "name";

            Search search = new Search();
            dgvCategory.DataSource = search.SearchFilter(connectionString, tbxSearchCategory.Text, optionString, optionForm);

            tbxSearchCategory.Text = "";
        }

        private void pbxClean_Click(object sender, EventArgs e)
        {
            ShowData();
            CleanData();
        }

        private void pbxBack_Click(object sender, EventArgs e)
        {
            HomeForm hf = new HomeForm(aux);
            hf.Show();
            this.Close();
        }

        private void pbxEdit_Click(object sender, EventArgs e)
        {
            int idCategory = Int32.Parse(dgvCategory.SelectedRows[0].Cells[0].Value.ToString());

            CategoryDetailsForm categoryDetails = new CategoryDetailsForm(idCategory, aux);
            categoryDetails.Show();

            this.Close();




        }

        private void pbxPlus_Click(object sender, EventArgs e)
        {
            CategoryDetailsForm cdf = new CategoryDetailsForm(aux);
            cdf.Show();
            this.Close();
        }

        private void pbxDelete_Click(object sender, EventArgs e)
        {
            int idCategory = Int32.Parse(dgvCategory.SelectedRows[0].Cells[0].Value.ToString());

            SqlConnection sqlConnect = new SqlConnection(connectionString);

            try
            {
                sqlConnect.Open();
                string sql = "UPDATE CATEGORY SET ACTIVE = @active WHERE ID = @id";

                SqlCommand cmd = new SqlCommand(sql, sqlConnect);

                cmd.Parameters.Add(new SqlParameter("@id", idCategory));
                cmd.Parameters.Add(new SqlParameter("@active", false));

                cmd.ExecuteNonQuery();

                ShowData();
                MessageBox.Show("Categoria inativa!");

                Log.SaveLog(sqlConnect, "Categoria Excluída", DateTime.Now, "Exclusão");

            }
            catch (Exception Ex)
            {
                MessageBox.Show("Erro ao editar esta categoria!" + "\n\n" + Ex.Message);
                throw;
            }
            finally
            {
                sqlConnect.Close();
            }
        }

        void GetData()
        {
            search = tbxSearchCategory.Text;
        }

        void CleanData()
        {
            tbxSearchCategory.Text = "";
        }


        private void pbxSearchCategory_MouseLeave(object sender, EventArgs e)
        {
            pbxSearchCategory.BackColor = Color.Transparent;
        }

        private void pbxSearchCategory_MouseEnter(object sender, EventArgs e)
        {
            pbxSearchCategory.BackColor = Color.LightGray;
        }

        private void pbxClean_MouseEnter(object sender, EventArgs e)
        {
            pbxClean.BackColor = Color.LightGray;
        }

        private void pbxClean_MouseLeave(object sender, EventArgs e)
        {
            pbxClean.BackColor = Color.Transparent;
        }
    }
}
