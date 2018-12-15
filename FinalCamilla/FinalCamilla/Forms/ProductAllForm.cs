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


    public partial class ProductAllForm : Form
    {
        User aux;

        string connectionString = "workstation id=StockControl.mssql.somee.com;packet size=4096;user id=levelupacademy_SQLLogin_1;pwd=3wwate8gu1;data source=StockControl.mssql.somee.com;persist security info=False;initial catalog=StockControl";
        public ProductAllForm(User user)
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
                SqlCommand cmd;
                sqlConnect.Open();

                if (aux.UserProfile.Name != "Gerente")
                {
                    cmd = new SqlCommand("SELECT PRODUCT.ID, PRODUCT.NAME, PRODUCT.ACTIVE, PRODUCT.PRICE, CATEGORY.NAME FROM PRODUCT INNER JOIN CATEGORY ON PRODUCT.FK_PRODUCT = CATEGORY.ID; WHERE PRODUCT.ACTIVE = @active", sqlConnect);
                    cmd.Parameters.Add(new SqlParameter("@active", true));
                }
                else
                {
                    cmd = new SqlCommand("SELECT PRODUCT.ID, PRODUCT.NAME, PRODUCT.ACTIVE, PRODUCT.PRICE, CATEGORY.NAME FROM PRODUCT INNER JOIN CATEGORY ON PRODUCT.FK_PRODUCT = CATEGORY.ID;", sqlConnect);
                }


                cmd.ExecuteNonQuery();

                DataTable dt = new DataTable();
                SqlDataAdapter sqlDtAdapter = new SqlDataAdapter(cmd);
                sqlDtAdapter.Fill(dt);

                dgvProduct.DataSource = dt;

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
            dgvProduct.Columns["ID"].Visible = false;
            dgvProduct.Columns["NAME"].HeaderText = "Nome";
            dgvProduct.Columns["ACTIVE"].HeaderText = "Ativo";

            dgvProduct.Columns["ACTIVE"].DisplayIndex = 4;
            dgvProduct.Columns["NAME1"].HeaderText = "Categoria";
            dgvProduct.Columns["NAME1"].DisplayIndex = 3;
            dgvProduct.Columns["PRICE"].HeaderText = "Preço";


            foreach (DataGridViewColumn col in dgvProduct.Columns)
            {
                col.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                col.HeaderCell.Style.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Pixel);
            }
        }

        private void pbxSearch_Click(object sender, EventArgs e)
        {

        }

        private void pbxClean_Click(object sender, EventArgs e)
        {

        }

        private void pbxBack_Click(object sender, EventArgs e)
        {
            HomeForm hf = new HomeForm(aux);
            hf.Show();
            this.Close();
        }

        private void pbxEdit_Click(object sender, EventArgs e)
        {
            int idProduct = Int32.Parse(dgvProduct.SelectedRows[0].Cells[0].Value.ToString());

            ProductDetailsForm pdf = new ProductDetailsForm(idProduct, aux);
            pdf.Show();

            this.Close();
        }

        private void pbxPlus_Click(object sender, EventArgs e)
        {
            ProductDetailsForm pdf = new ProductDetailsForm(aux);
            pdf.Show();
            this.Close();
        }

        private void pbxDelete_Click(object sender, EventArgs e)
        {
            int idProduct = Int32.Parse(dgvProduct.SelectedRows[0].Cells[0].Value.ToString());
            SqlConnection sqlConnect = new SqlConnection(connectionString);

            try
            {
                sqlConnect.Open();
                string sql = "UPDATE PRODUCT SET ACTIVE = @active WHERE ID = @id";

                SqlCommand cmd = new SqlCommand(sql, sqlConnect);

                cmd.Parameters.Add(new SqlParameter("@id", idProduct));
                cmd.Parameters.Add(new SqlParameter("@active", false));

                cmd.ExecuteNonQuery();

                ShowData();
                MessageBox.Show("Produto inativo!");
                Log.SaveLog(sqlConnect, "Produto Excluído", DateTime.Now, "Exclusão");

            }
            catch (Exception Ex)
            {
                MessageBox.Show("Erro ao editar este produto!" + "\n\n" + Ex.Message);
                throw;
            }
            finally
            {
                sqlConnect.Close();
            }
        }
    }
}
