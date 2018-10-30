using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//add namespaces/classes to allow access
using System.Data.SqlClient;
using JanesClothingDB.Business_Logic_Layer;
using JanesClothingDB.Data_Access_Layer;

namespace JanesClothingDB
{
    public partial class frmProductAdd : Form
    {
        public frmProductAdd()
        {
            InitializeComponent();
        }

        //events
        private void frmProductDetails_FormClosing(object sender, FormClosingEventArgs e)
        {
            frmMainForm mainForm = new frmMainForm();
            mainForm.Show();
            Hide();
        }
        private void frmProductDetails_FormClosed(object sender, FormClosedEventArgs e)
        {
            frmMainForm mainForm = new frmMainForm();
            mainForm.Show();
            Hide();
        }
        private void frmProductDetails_Load(object sender, EventArgs e)
        {
            //setting query value and instantiating DataReader object and connection to database
            string selectQuery;

            selectQuery = "SELECT * FROM Brands";
            SqlConnection connection = ConnectionManager.DatabaseConnection();
            SqlDataReader reader = null;

            try
            {
                //code to populate BrandID box
                connection.Open();
                SqlCommand command = new SqlCommand(selectQuery, connection);
                reader = command.ExecuteReader();

                while (reader.Read())
                {
                    lbBrandID.Items.Add(reader["BrandID"].ToString());
                    cbBrandID.Items.Add(reader["BrandName"].ToString());
                }
                if (reader != null)
                    reader.Close();
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Unsuccessful" + ex);             
            }

            //TO-DO code to update product
        }

        //buttons
        private void btnAdd_Click(object sender, EventArgs e)
        {

        }
        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearInfo();
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        //Clear Info
        public void ClearInfo()
        {
            txtProductID.Clear();
            cbBrandID.SelectedIndex = -1;
            txtProductDescription.Clear();
            txtPrice.Clear();
            rbMale.Checked = false;
            rbFemale.Checked = false;
            rbUnisex.Checked = false;
            cbColourFast.Checked = false;
        }

        
    }
}
