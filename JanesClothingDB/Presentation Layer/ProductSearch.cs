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
    public partial class frmProductSearch : Form
    {
        public frmProductSearch()
        {
            InitializeComponent();
        }

        //Set text/combo box vibility for selected buttons
        private void rbAll_Click(object sender, EventArgs e)
        {
            txtSearch.Visible = false;
            cbBrands.Visible = false;
        }
        private void rbDescription_Click(object sender, EventArgs e)
        {
            txtSearch.Visible = true;
            cbBrands.Visible = false;
        }
        private void rbBrand_Click(object sender, EventArgs e)
        {
            txtSearch.Visible = false;
            cbBrands.Visible = true;
            cbBrands.SelectedIndex = -1;
            cbBrands.Top = txtSearch.Top;
            cbBrands.Left = txtSearch.Left;
        }

        //load event to access brands from database
        private void frmProductSearch_Load(object sender, EventArgs e)
        {
            txtSearch.Visible = false;
            cbBrands.Visible = false;

            string selectQuery;
            selectQuery = "SELECT * FROM Brands";

            SqlConnection connection = ConnectionManager.DatabaseConnection();
            SqlDataReader reader = null;

            try
            {
                connection.Open();
                SqlCommand command = new SqlCommand(selectQuery, connection);
                reader = command.ExecuteReader();

                while (reader.Read())
                {
                    lbBrands.Items.Add(reader["BrandID"].ToString());
                    cbBrands.Items.Add(reader["BrandName"].ToString());
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

        //Search criteria for search button
        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (rbAll.Checked == true)
                GlobalVariable.productSearchCriteria = "";
            if (rbProductDescription.Checked == true)
                GlobalVariable.productSearchCriteria = "WHERE ProductDescription = '" + txtSearch.Text + "'";
            if (rbBrand.Checked == true)
                GlobalVariable.productSearchCriteria = "WHERE Products.BrandID = '" + lbBrands.Items[cbBrands.SelectedIndex].ToString() + "'";
            Close();
        }      

    }
}
