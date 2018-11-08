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

            //code to update products
            if (GlobalVariable.selectedProductID == 0)
                btnAdd.Text = "&Add";
            else
                btnAdd.Text = "U&pdate";

            if (GlobalVariable.selectedProductID > 0)
            {                
                selectQuery = "SELECT * FROM Products WHERE ProductID = " + GlobalVariable.selectedProductID.ToString();
                                
                SqlConnection connection1 = ConnectionManager.DatabaseConnection();
                SqlDataReader reader1 = null;

                try
                {
                    //try to open connection and connect to database, perform action, close connection
                    connection1.Open();
                    SqlCommand command1 = new SqlCommand(selectQuery, connection1);
                    reader1 = command1.ExecuteReader();
                    reader1.Read();
                                        
                    cbBrandID.SelectedIndex = int.Parse(reader1["BrandID"].ToString()) - 1;
                    txtProductDescription.Text = reader1["ProductDescription"].ToString();
                    txtPrice.Text = reader1["Price"].ToString();
                    if (reader1["GenderType"].ToString() == "M")
                          rbMale.Checked = true;                    
                    else if (reader1["GenderType"].ToString() == "F")                    
                        rbFemale.Checked = true;                    
                    else
                        rbUnisex.Checked = true;
                    if (bool.Parse(reader1["ColourFast"].ToString()) == true)
                        cbColourFast.Checked = true;
                    else
                        cbColourFast.Checked = true;

                    //close reader object and connection
                    reader1.Close();
                    connection1.Close();                      
                }
                //catches exception if unsuccessful
                catch (Exception ex)
                {
                    MessageBox.Show("Unsuccessful" + Environment.NewLine + ex);
                }

            }
        }

        //buttons
        private void btnAdd_Click(object sender, EventArgs e)
        {
            //Validate and set values to input choices
            if (String.IsNullOrEmpty(cbBrandID.Text))
            {
                MessageBox.Show("Please choose a Brand.");
                return;
            }
            if (String.IsNullOrEmpty(txtProductDescription.Text))
            {
                MessageBox.Show("Please enter the Products description.");
                return;
            }
            if (String.IsNullOrEmpty(txtPrice.Text))
            {
                MessageBox.Show("Please enter the Products price.");
                return;
            }
            if (!decimal.TryParse(txtPrice.Text, out decimal parsedValue))
            {
                MessageBox.Show("Price must be a number.");
                return;
            }
            if (rbFemale.Checked == false && rbMale.Checked == false && rbUnisex.Checked == false)
            {
                MessageBox.Show("Please choose a Gender.");
                return;
            }

            string gender = "M";
            if (rbFemale.Checked)
                gender = "F";
            else if (rbUnisex.Checked)
                gender = "U";

            int colourFast = 0;
            if (cbColourFast.Checked)
                colourFast = 1;

            //create product object with values
            Product product = new Product(GlobalVariable.selectedProductID, 
                                          lbBrandID.Items[cbBrandID.SelectedIndex].ToString(),
                                          txtProductDescription.Text, decimal.Parse(txtPrice.Text), 
                                          gender, colourFast.ToString());

            string addQuery;

            if (GlobalVariable.selectedProductID == 0)
            {
                addQuery = "sp_Products_CreateProduct ";
            }
            else
            {
                addQuery = "sp_Products_UpdateProduct ";
            }

            SqlConnection connection = ConnectionManager.DatabaseConnection();
            connection.Open();
            SqlCommand command = new SqlCommand(addQuery, connection);
            command.CommandType = CommandType.StoredProcedure;

            if (GlobalVariable.selectedProductID != 0)
            {
                command.Parameters.AddWithValue("@ProductID", product.ProductID);
            }
            command.Parameters.AddWithValue("@BrandID", product.Brand);
            command.Parameters.AddWithValue("@ProductDescription", product.ProductDescription);
            command.Parameters.AddWithValue("@Price", product.Price);
            command.Parameters.AddWithValue("@GenderType", product.Gender);
            command.Parameters.AddWithValue("@ColourFast", product.ColourFast);
            
            if (GlobalVariable.selectedProductID == 0)
            {
                command.Parameters.AddWithValue("@NewProductID", SqlDbType.Int).Direction = ParameterDirection.Output;
            }

            command.Transaction = connection.BeginTransaction();
            command.ExecuteNonQuery();
            command.Transaction.Commit();

            connection.Close();
            Close();
            
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
