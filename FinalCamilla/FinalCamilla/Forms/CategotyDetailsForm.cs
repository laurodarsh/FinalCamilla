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
    public partial class CategotyDetailsForm : Form
    {
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

        }

        private void pbxDelete_Click(object sender, EventArgs e)
        {

        }
    }
}
