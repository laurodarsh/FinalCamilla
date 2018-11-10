﻿using System;
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
    public partial class UserProfileAllForm : Form
    {
        string connectionString = "workstation id=StockControl.mssql.somee.com;packet size=4096;user id=levelupacademy_SQLLogin_1;pwd=3wwate8gu1;data source=StockControl.mssql.somee.com;persist security info=False;initial catalog=StockControl";
        public UserProfileAllForm()
        {
            InitializeComponent();
            ShowData();
            ResizeDataGridView();
        }

        private void pbxPlus_Click(object sender, EventArgs e)
        {
            UserProfileDetailsForm updf = new UserProfileDetailsForm();
            updf.Show();
            this.Hide();
        }

        


             private void ShowData()
        {
            SqlConnection sqlConnect = new SqlConnection(connectionString);

            try
            {
                sqlConnect.Open();

                SqlCommand cmd = new SqlCommand("SELECT * FROM USER_PROFILE", sqlConnect);
                // SqlDataReader reader = cmd.ExecuteReader();

                cmd.ExecuteNonQuery();

                DataTable dt = new DataTable();
                SqlDataAdapter sqlDtAdapter = new SqlDataAdapter(cmd);
                sqlDtAdapter.Fill(dt);

                dgvProfile.DataSource = dt;

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
            dgvProfile.Columns["ID"].Visible = false;
            dgvProfile.Columns["NAME"].HeaderText = "Nome";
            dgvProfile.Columns["ACTIVE"].HeaderText = "Ativo";


            foreach (DataGridViewColumn col in dgvProfile.Columns)
            {
                col.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                col.HeaderCell.Style.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Pixel);
            }
        }

        private void pbxEdit_Click(object sender, EventArgs e)
        {
            UserProfileDetailsForm updf = new UserProfileDetailsForm();
            updf.Show();
            this.Hide();
        }
        private void pbxBack_Click(object sender, EventArgs e)
        {
            HomeForm hf = new HomeForm();
            hf.Show();
            this.Close();
        }
    }
}
