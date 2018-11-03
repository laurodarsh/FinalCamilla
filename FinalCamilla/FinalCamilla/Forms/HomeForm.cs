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
    public partial class HomeForm : Form
    {
        public HomeForm()
        {
            InitializeComponent();
        }

        private void pbxProduct_MouseEnter(object sender, EventArgs e)
        {
            pbxProduct.BackColor = Color.LightGray;
        }
        private void pbxCategory_MouseEnter(object sender, EventArgs e)
        {
            pbxCategory.BackColor = Color.LightGray;
        }
        private void pbxUser_MouseEnter(object sender, EventArgs e)
        {
            pbxUser.BackColor = Color.LightGray;
        }
        private void pbxProfile_MouseEnter(object sender, EventArgs e)
        {
            pbxProfile.BackColor = Color.LightGray;
        }
        private void pbxLog_MouseEnter(object sender, EventArgs e)
        {
            pbxLog.BackColor = Color.LightGray;
        }
        private void pbxProduct_MouseLeave(object sender, EventArgs e)
        {
            pbxProduct.BackColor = Color.Transparent;
        }
        private void pbxCategory_MouseLeave(object sender, EventArgs e)
        {
            pbxCategory.BackColor = Color.Transparent;
        }
        private void pbxUser_MouseLeave(object sender, EventArgs e)
        {
            pbxUser.BackColor = Color.Transparent;
        }
        private void pbxProfile_MouseLeave(object sender, EventArgs e)
        {
            pbxProfile.BackColor = Color.Transparent;
        }
        private void pbxLog_MouseLeave(object sender, EventArgs e)
        {
            pbxLog.BackColor = Color.Transparent;
                
        }

        private void pbxProduct_Click(object sender, EventArgs e)
        {
            ProductAllForm paf = new ProductAllForm();
            paf.Show();
            this.Hide();
        }

        private void pbxCategory_Click(object sender, EventArgs e)
        {
            CategoryAllForm caf = new CategoryAllForm();
            caf.Show();
            this.Hide();
        }

        private void pbxUser_Click(object sender, EventArgs e)
        {
            UserAllForm uaf = new UserAllForm();
            uaf.Show();
            this.Hide();
        }

        private void pbxProfile_Click(object sender, EventArgs e)
        {
            UserProfileAllForm upaf = new UserProfileAllForm();
            upaf.Show();
            this.Hide();
        }

        private void pbxLog_Click(object sender, EventArgs e)
        {
            LogForm lf = new LogForm();
            lf.Show();
            this.Hide();
        }

        private void pbxBack_Click(object sender, EventArgs e)
        {
            LoginForm lgf = new LoginForm();
            lgf.Show();
            this.Hide();
        }
    }
}
