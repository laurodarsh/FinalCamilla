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
    public partial class LogForm : Form
    {
        string search = "";


        string connectionString = "workstation id=StockControl.mssql.somee.com;packet size=4096;user id=levelupacademy_SQLLogin_1;pwd=3wwate8gu1;data source=StockControl.mssql.somee.com;persist security info=False;initial catalog=StockControl";
        public LogForm()
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
                SqlCommand cmd = new SqlCommand("SELECT * FROM LOG", sqlConnect);


                cmd.ExecuteNonQuery();

                DataTable dt = new DataTable();
                SqlDataAdapter sqlDtAdapter = new SqlDataAdapter(cmd);
                sqlDtAdapter.Fill(dt);

                dgvLOG.DataSource = dt;

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
            dgvLOG.Columns["ID"].Visible = false;
            dgvLOG.Columns["DESCRIPTION"].HeaderText = "Descrição";
            dgvLOG.Columns["DATE"].HeaderText = "Data";
            dgvLOG.Columns["TYPE"].HeaderText = "Tipo";





            foreach (DataGridViewColumn col in dgvLOG.Columns)
            {
                col.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                col.HeaderCell.Style.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Pixel);
            }
        }

        private void pbxBack_Click(object sender, EventArgs e)
        {
            HomeForm hf = new HomeForm();
            hf.Show();
            this.Close();
        }

        private void pbxSearch_Click(object sender, EventArgs e)
        {
            string optionForm = "LogForm";
            string optionString = "name";

            Search search = new Search();
            dgvLOG.DataSource = search.SearchFilter(connectionString, tbxSearch.Text, optionString, optionForm);

            tbxSearch.Text = "";
        }

        private void pbxClean_Click(object sender, EventArgs e)
        {
            ShowData();
            CleanData();
        }

        void GetData()
        {
            search = tbxSearch.Text;
        }

        void CleanData()
        {
            tbxSearch.Text = "";
        }

        private void pbxClean_DragEnter(object sender, DragEventArgs e)
        {
            pbxClean.BackColor = Color.LightGray;
        }

        private void pbxClean_DragLeave(object sender, EventArgs e)
        {
            pbxClean.BackColor = Color.Transparent;
        }

        private void pbxSearch_MouseEnter(object sender, EventArgs e)
        {
            pbxSearch.BackColor = Color.LightGray;
        }

        private void pbxSearch_DragLeave(object sender, EventArgs e)
        {
            pbxSearch.BackColor = Color.Transparent;
        }
    }
}


