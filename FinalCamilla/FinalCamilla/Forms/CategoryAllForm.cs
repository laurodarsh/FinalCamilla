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
        string search = "";

        string connectionString = "workstation id=StockControl.mssql.somee.com;packet size=4096;user id=levelupacademy_SQLLogin_1;pwd=3wwate8gu1;data source=StockControl.mssql.somee.com;persist security info=False;initial catalog=StockControl";

        public CategoryAllForm()
        {
            InitializeComponent();
            ShowData();
            ResizeDataGridView();
        }
        private void ShowData()
        {
            SqlConnection sqlConnect = new SqlConnection(connectionString);

            try
            {
                sqlConnect.Open();

                SqlCommand cmd = new SqlCommand("SELECT * FROM CATEGORY", sqlConnect);
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
            HomeForm hf = new HomeForm();
            hf.Show();
            this.Close();
        }

        private void pbxEdit_Click(object sender, EventArgs e)
        {
            CategotyDetailsForm cdf = new CategotyDetailsForm();
            cdf.Show();
            this.Close();
        }

        private void pbxPlus_Click(object sender, EventArgs e)
        {
            CategotyDetailsForm cdf = new CategotyDetailsForm();
            cdf.Show();
            this.Close();
        }

        private void pbxDelete_Click(object sender, EventArgs e)
        {

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
