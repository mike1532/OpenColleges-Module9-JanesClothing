using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//added to allow access
using System.Data.SqlClient;
using JanesClothingDB.Business_Logic_Layer;
using JanesClothingDB.Data_Access_Layer;

namespace JanesClothingDB
{
    public partial class frmCustomerAdd : Form
    {
        public frmCustomerAdd()
        {
            InitializeComponent();
        }

        private void frmCustomerAdd_FormClosing(object sender, FormClosingEventArgs e)
        {
            //when closing, shows main form and hides add customer form
           // frmMainForm mainForm = new frmMainForm();
            //mainForm.Show();
            //Hide();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            //edit checked to validate user input
            if (String.IsNullOrEmpty(txtFirstName.Text))
            {
                MessageBox.Show("Please enter the First Name.");
                return;
            }
            if (String.IsNullOrEmpty(txtLastName.Text))
            {
                MessageBox.Show("Please enter the Last Name.");
                return;
            }
            if (rbMale.Checked == false && rbFemale.Checked == false)
            {
                MessageBox.Show("Please select a Gender.");
                return;
            }
            if (String.IsNullOrEmpty(cbCategory.Text))
            {
                MessageBox.Show("Please select a Category.");
                return;
            }
            if (String.IsNullOrEmpty(txtAddress.Text))
            {
                MessageBox.Show("Please enter an Address");
                return;
            }
            if (String.IsNullOrEmpty(txtSuburb.Text))
            {
                MessageBox.Show("Please enter a Suburb.");
                return;
            }
            if (String.IsNullOrEmpty(cbState.Text))
            {
                MessageBox.Show("Please select a State.");
                return;
            }
            if (String.IsNullOrEmpty(txtPostcode.Text))
            {
                MessageBox.Show("Please enter a Postcode.");
                return;
            }
            if (!int.TryParse(txtPostcode.Text, out int parsedValue))
            {
                MessageBox.Show("Postcode must be a number.");
                return;
            }
            if (chkYes.Checked == false && chkNo.Checked == false)
            {
                MessageBox.Show("Please select if the Customer wishes to receive our Catalogue");
                return;
            }
            string gender = "M";
            if (rbFemale.Checked)
            {
                gender = "F";           
            }
            int sendCatalogue = 1;
            if (chkNo.Checked)
            {
                sendCatalogue = 0;
            }


        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            //closes form
            Close();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtFirstName.Clear();
            txtLastName.Clear();
            rbMale.Checked = false;
            rbFemale.Checked = false;
            cbCategory.SelectedIndex = -1;
            txtAddress.Clear();
            txtSuburb.Clear();
            cbState.SelectedIndex = -1;
            txtPostcode.Clear();
            txtCustomerNo.Clear();
            chkYes.Checked = false;
            chkNo.Checked = false;
        }

        private void frmCustomerAdd_FormClosed(object sender, FormClosedEventArgs e)
        {
            //when closing, shows main form and hides add customer form
            frmMainForm mainForm = new frmMainForm();
            mainForm.Show();
            Hide();
        }

        private void frmCustomerAdd_Load(object sender, EventArgs e)
        {
            //database query
            string selectQuery = "SELECT * FROM Categories";
                        
            SqlConnection connection = ConnectionManager.DatabaseConnection();
            SqlDataReader reader = null;

            try
            {
                connection.Open();
                SqlCommand command = new SqlCommand(selectQuery, connection);
                reader = command.ExecuteReader();

                while (reader.Read())
                {
                    lbCategoryID.Items.Add(reader["CategoryID"].ToString());
                    cbCategory.Items.Add(reader["Category"].ToString());
                }
                if (reader != null)
                    reader.Close();
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Unsuccessful" + ex);
                Application.Exit();
            }       
        }
    }
}
