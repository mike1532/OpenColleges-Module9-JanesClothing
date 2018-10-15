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
    public partial class frmProductEdit : Form
    {
        public frmProductEdit()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void frmProductEdit_FormClosing(object sender, FormClosingEventArgs e)
        {

            frmMainForm mainForm = new frmMainForm();
            mainForm.Show();
            Hide();
        }
    }
}
