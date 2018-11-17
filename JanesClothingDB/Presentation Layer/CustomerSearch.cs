using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using JanesClothingDB.Data_Access_Layer;


namespace JanesClothingDB.Presentation_Layer
{
    public partial class frmCustomerSearch : Form
    {
        public frmCustomerSearch()
        {
            InitializeComponent();
        }

        //sets visibilty on selected option
        private void rbAll_Click(object sender, EventArgs e)
        {
            txtSearch.Visible = false;
            cbCategory.Visible = false;
        }
        private void rbLastName_Click(object sender, EventArgs e)
        {
            txtSearch.Visible = true;
            cbCategory.Visible = false;
        }
        private void rbCategory_Click(object sender, EventArgs e)
        {
            txtSearch.Visible = false;
            cbCategory.Visible = true;
            cbCategory.SelectedIndex = -1; //clears previous selection if options are toggled
            cbCategory.Top = txtSearch.Top;
            cbCategory.Left = txtSearch.Left;
        }
        private void rbPostcode_Click(object sender, EventArgs e)
        {
            txtSearch.Visible = true;
            cbCategory.Visible = false;
        }

        //load/close behaviours
        private void frmCustomerSearch_Load(object sender, EventArgs e)
        {
            txtSearch.Visible = false;
            cbCategory.Visible = false;

            string selectQuery;
            selectQuery = "SELECT * FROM Categories";

            SqlConnection connection = ConnectionManager.DatabaseConnection();
            SqlDataReader reader = null;

            //connects to database to load in category options when page loaded
            try
            {
                connection.Open();
                SqlCommand command = new SqlCommand(selectQuery, connection);
                reader = command.ExecuteReader();

                while (reader.Read())
                {
                    lbCategory.Items.Add(reader["CategoryID"].ToString());
                    cbCategory.Items.Add(reader["Category"].ToString());
                }
                if (reader != null)
                    reader.Close();
                connection.Close();
            }

            catch (Exception ex)
            {
                MessageBox.Show("Unsucessful" + ex);
            }              

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            //search criteria
            if (rbAll.Checked == true)
                GlobalVariable.customerSearchCriteria = "";
            if (rbLastName.Checked == true)
                GlobalVariable.customerSearchCriteria = "WHERE LastName = '" + txtSearch.Text + "'";
            if (rbCategory.Checked == true)
                GlobalVariable.customerSearchCriteria = "WHERE Customers.CategoryID = '" + lbCategory.Items[cbCategory.SelectedIndex].ToString() + "'";
            if (rbPostcode.Checked == true)
                GlobalVariable.customerSearchCriteria = "WHERE PostCode = '" + txtSearch.Text + "'";
            Close();
        }

       
    }
}
