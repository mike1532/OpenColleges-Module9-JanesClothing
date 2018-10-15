using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JanesClothingDB
{
    public partial class frmCustomersEdit : Form
    {
        public frmCustomersEdit()
        {
            InitializeComponent();
        }

        private void frmCustomersEdit_FormClosing(object sender, FormClosingEventArgs e)
        {
            //closes form/displays main form
            frmMainForm mainForm = new frmMainForm();
            mainForm.Show();
            Hide();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            //closes form
            this.Close();
        }
    }
}
