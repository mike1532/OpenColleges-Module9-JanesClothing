using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//main form need to access CustomersView.cs
using JanesClothingDB.Presentation_Layer;

namespace JanesClothingDB
{
    public partial class frmMainForm : Form
    {
        public frmMainForm()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            //exit application
            Application.Exit();
        }

        //**DELETE**
        private void btnAddProduct_Click(object sender, EventArgs e)
        {
            //opens add product details/hides main
            frmProductAdd addProd = new frmProductAdd();
            addProd.Show();
            Hide();
        }

        //**DELETE**
        private void btnEditProduct_Click(object sender, EventArgs e)
        {
            //opens edit product details/hides main
            frmProductEdit editProd = new frmProductEdit();
            editProd.Show();
            Hide();
        }

        private void frmMainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            //exits application when closed
            Application.Exit();
        }

        private void btnCustomersView_Click(object sender, EventArgs e)
        {
            //opens view customers/hides main
            frmCustomersView viewForm = new frmCustomersView();
            viewForm.Show();
            Hide();
        }

        private void btnViewProducts_Click(object sender, EventArgs e)
        {
            //opens view products/hides main
            frmProductView viewProd = new frmProductView();
            viewProd.Show();
            Hide();
        }
    }
}
