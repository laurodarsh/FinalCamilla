using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalCamilla.Forms
{
    public partial class CategoryAllForm : Form
    {
        public CategoryAllForm()
        {
            InitializeComponent();
        }

        private void pbxSearchCategory_Click(object sender, EventArgs e)
        {

        }

        private void pbxClean_Click(object sender, EventArgs e)
        {

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
    }
}
