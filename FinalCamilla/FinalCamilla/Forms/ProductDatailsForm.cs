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


    public partial class ProductDatailsForm : Form
    {
        string name = "";
        int price = 0;
        string category = "";
        bool active = false;

        string connectionString = "workstation id=StockControl.mssql.somee.com;packet size=4096;user id=levelupacademy_SQLLogin_1;pwd=3wwate8gu1;data source=StockControl.mssql.somee.com;persist security info=False;initial catalog=StockControl";

        List<Category> categories = new List<Category>();

        public ProductDatailsForm()
        {
            InitializeComponent();
            cbmCategory.DisplayMember = "NAME";
            LoadComboBox();
        }
        void LoadComboBox()
        {
            SqlConnection cn = new SqlConnection(connectionString);

            try
            {
                cn.Open();
                SqlCommand sqlCommand = new SqlCommand("SELECT * FROM CATEGORY", cn);

                SqlDataReader reader = sqlCommand.ExecuteReader();
                while (reader.Read())
                {
                    Category c = new Category(Int32.Parse(reader["ID"].ToString()), reader["NAME"].ToString(), bool.Parse(reader["ACTIVE"].ToString()) );
                    categories.Add(c);
                }
            }
            catch (Exception ex)
            {

            }
            finally
            {
                cn.Close();
            }
            foreach (Category c in categories)
            {
                cbmCategory.Items.Add(c);
            }
        }

        private void pbxBack_Click(object sender, EventArgs e)
        {

        }

        private void pbxSave_Click(object sender, EventArgs e)
        {
            SqlConnection sqlConnect = new SqlConnection(connectionString);
            try
            {
                GetData();
                Category c = (Category)cbmCategory.SelectedItem;
                Product p = new Product(name, price, c, active);
                sqlConnect.Open();
                string sql = "INSERT INTO PRODUCT(NAME, PRICE, ACTIVE, FK_PRODUCT) VALUES (@name, @price, @active, @category)";

                SqlCommand cmd = new SqlCommand(sql, sqlConnect);

                cmd.Parameters.Add(new SqlParameter("@name", name));
                cmd.Parameters.Add(new SqlParameter("@price", price));
                cmd.Parameters.Add(new SqlParameter("@active", active));
                cmd.Parameters.Add(new SqlParameter("@category", p.Category.Id));
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
            name = tbxName.Text;
            price = Int32.Parse(tbxPrice.Text);
            category= cbmCategory.Text;
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
            tbxPrice.Text = "";
            cbmCategory.Text = "";
            cbxActive.Checked = false;
        }
    }
}
