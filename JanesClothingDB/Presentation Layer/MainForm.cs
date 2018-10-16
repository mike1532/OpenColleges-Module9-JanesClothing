﻿using System;
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

        private void btnAddCustomer_Click(object sender, EventArgs e)
        {
            //opens add customer form/hides main form
            frmCustomerAdd addForm = new frmCustomerAdd();
            addForm.Show();
            Hide();
        }

        private void btnEditCustomer_Click(object sender, EventArgs e)
        {
            //opens edit customer from/hides main form
            frmCustomersEdit editForm = new frmCustomersEdit();
            editForm.Show();
            Hide();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            //exit application
            Application.Exit();
        }

        private void btnAddProduct_Click(object sender, EventArgs e)
        {
            //opens add product details/hides main
            frmProductDetails addProd = new frmProductDetails();
            addProd.Show();
            Hide();
        }

        private void btnEditProduct_Click(object sender, EventArgs e)
        {
            //opens edit product details/hides main
            frmProductEdit editProd = new frmProductEdit();
            editProd.Show();
            Hide();
        }

        private void frmMainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void btnCustomersView_Click(object sender, EventArgs e)
        {
            frmCustomersView viewForm = new frmCustomersView();
            viewForm.Show();
            Hide();
        }
    }
}
