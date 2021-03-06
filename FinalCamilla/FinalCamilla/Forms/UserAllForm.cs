﻿using FinalCamilla.Classes;
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
    public partial class UserAllForm : Form
    {
        User aux;
        
        string connectionString = "workstation id=StockControl.mssql.somee.com;packet size=4096;user id=levelupacademy_SQLLogin_1;pwd=3wwate8gu1;data source=StockControl.mssql.somee.com;persist security info=False;initial catalog=StockControl";
        public UserAllForm(User user)
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
                SqlCommand cmd = new SqlCommand("SELECT [USER].ID, [USER].NAME, [USER].PASSWORD, [USER].EMAIL, [USER].ACTIVE, USER_PROFILE.NAME FROM [USER] INNER JOIN USER_PROFILE ON [USER].FK_USERPROFILE =  USER_PROFILE.ID;", sqlConnect);


                cmd.ExecuteNonQuery();

                DataTable dt = new DataTable();
                SqlDataAdapter sqlDtAdapter = new SqlDataAdapter(cmd);
                sqlDtAdapter.Fill(dt);

                dgvUser.DataSource = dt;

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
            dgvUser.Columns["ID"].Visible = false;
            dgvUser.Columns["NAME"].HeaderText = "Nome";
            dgvUser.Columns["ACTIVE"].HeaderText = "Ativo";
            dgvUser.Columns["PASSWORD"].Visible = false;
            dgvUser.Columns["ACTIVE"].DisplayIndex = 5;
            dgvUser.Columns["EMAIL"].HeaderText = "E-Mail";
            dgvUser.Columns["NAME1"].DisplayIndex = 4;
            dgvUser.Columns["NAME1"].HeaderText = "Perfil";


            foreach (DataGridViewColumn col in dgvUser.Columns)
            {
                col.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                col.HeaderCell.Style.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Pixel);
            }
        }

        private void pbxEdit_Click(object sender, EventArgs e)
        {
           int idCategory = Int32.Parse(dgvUser.SelectedRows[0].Cells[0].Value.ToString());

            UserDetailsForm udf = new UserDetailsForm(idCategory, aux);
            udf.Show();

            this.Close();
           
        }

        private void pbxPlus_Click(object sender, EventArgs e)
        {
            UserDetailsForm udf = new UserDetailsForm(aux);
            udf.Show();
            this.Hide();
        }

        private void pbxBack_Click(object sender, EventArgs e)
        {
            HomeForm hf = new HomeForm(aux);
            hf.Show();
            this.Close();
        }

        private void pbxDelete_Click(object sender, EventArgs e)
        {
            int idUser = Int32.Parse(dgvUser.SelectedRows[0].Cells[0].Value.ToString());

            SqlConnection sqlConnect = new SqlConnection(connectionString);

            try
            {
                sqlConnect.Open();
                string sql = "UPDATE [USER] SET ACTIVE = @active WHERE ID = @id";

                SqlCommand cmd = new SqlCommand(sql, sqlConnect);

                cmd.Parameters.Add(new SqlParameter("@id", idUser));
                cmd.Parameters.Add(new SqlParameter("@active", false));

                cmd.ExecuteNonQuery();
                
                ShowData();
                MessageBox.Show("Usuário inativo!");
                Log.SaveLog(sqlConnect,"Usuário Excluído", DateTime.Now, "Exclusão");

            }
            catch (Exception Ex)
            {
                MessageBox.Show("Erro ao editar este usuário!" + "\n\n" + Ex.Message);
                throw;
            }
            finally
            {
                sqlConnect.Close();
            }
        }

        private void pbxSearch_Click(object sender, EventArgs e)
        {

        }
    }
}
