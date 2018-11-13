using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//added access to database and folders
using System.Data.SqlClient;
using JanesClothingDB.Business_Logic_Layer;
using JanesClothingDB.Data_Access_Layer;

namespace JanesClothingDB.Presentation_Layer
{
    public partial class frmProductView : Form
    {
        public frmProductView()
        {
            InitializeComponent();
        }

        //loading/closing actions
        private void ProductView_FormClosing(object sender, FormClosingEventArgs e)
        {
            frmMainForm mainForm = new frmMainForm();
            mainForm.Show();
            Hide();
        }
        private void ProductView_FormClosed(object sender, FormClosedEventArgs e)
        { 
            frmMainForm mainForm = new frmMainForm();
            mainForm.Show();
            Hide();
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void frmProductView_Load(object sender, EventArgs e)
        {
            DisplayProducts();
        }          

        //add, update, delete, search
        private void btnAdd_Click(object sender, EventArgs e)
        {
            GlobalVariable.selectedProductID = 0;
            frmProductAdd editForm = new frmProductAdd();
            editForm.ShowDialog();
            lvProducts.Items.Clear();
            DisplayProducts();
        }
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            //checks that product has been chosen
            if (lvProducts.SelectedItems.Count == 0)
            {
                MessageBox.Show("Please select a Product to update");
                return;
            }
            GlobalVariable.selectedProductID = int.Parse(lvProducts.SelectedItems[0].Text);
            frmProductAdd editForm = new frmProductAdd();
            editForm.ShowDialog();
            lvProducts.Items.Clear();
            DisplayProducts();
        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (lvProducts.SelectedItems.Count == 0)
            {
                MessageBox.Show("Please select a Product to delete.");
                return;
            }

            DialogResult dialogResult = MessageBox.Show("Are you sure you wish to delete this record?",
                                            "Product Delete", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.No)
                return;

            int selectedProductID = int.Parse(lvProducts.SelectedItems[0].Text);
            string deleteProduct = "sp_Products_DeleteProduct";

            SqlConnection connection = ConnectionManager.DatabaseConnection();
            connection.Open();
            SqlCommand command = new SqlCommand(deleteProduct, connection);

            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@ProductID", selectedProductID);
            command.Transaction = connection.BeginTransaction();
            command.ExecuteNonQuery();
            command.Transaction.Commit();

            connection.Close();

            lvProducts.Items.Clear();
            DisplayProducts();

        }

        //displays products
        public void DisplayProducts()
        {
            //query to show product details
            string selectQuery = "SELECT Products.ProductID, Brands.BrandName, Products.ProductDescription, "
            + "Products.Price, Products.GenderType, Products.ColourFast FROM Products INNER JOIN Brands "
            + " ON Products.BrandID = Brands.BrandID";

            //calls DatabaseConnection method from ConnectionManager.cs file and instantiate DataReaderObject
            SqlConnection conn = ConnectionManager.DatabaseConnection();
            SqlDataReader reader = null;

            try
            {
                //Open the connection, passes query of databse to cmd, executes query through SQLDataReader object
                conn.Open();
                SqlCommand command = new SqlCommand(selectQuery, conn);
                reader = command.ExecuteReader();

                //defines the variable list items (GenderType, ColourFast)
                while (reader.Read())
                {
                    //defaults to male, sets to female or unisex
                    string genderType = "Male";
                    if (reader["GenderType"].ToString() == "F")
                    {
                        genderType = "Female";
                    }
                    else if (reader["GenderType"].ToString() == "U")
                    {
                        genderType = "Unisex";
                    }

                    //defaults to no, sets entry as boolean, if true returns yes
                    string colourFast = "No";
                    bool cf = reader.GetBoolean(reader.GetOrdinal("ColourFast"));

                    if (cf)
                    {
                        colourFast = "Yes";
                    }
                    //calls parameterised products constructor
                    Product product = new Product(int.Parse(reader["ProductID"].ToString()), reader["BrandName"].ToString(),
                                      reader["productDescription"].ToString(), decimal.Parse(reader["Price"].ToString()),
                                      genderType, colourFast);

                    //creates ListViewItem, then adds ListViewItems to lvProducts
                    ListViewItem listViewItem = new ListViewItem(product.ProductID.ToString());
                    listViewItem.SubItems.Add(product.Brand);
                    listViewItem.SubItems.Add(product.ProductDescription);
                    listViewItem.SubItems.Add(product.Price.ToString("0.00"));
                    listViewItem.SubItems.Add(product.Gender);
                    listViewItem.SubItems.Add(product.ColourFast);


                    lvProducts.Items.Add(listViewItem);
                }
                //if null, close datareader object and close connection
                if (reader != null)
                    reader.Close();
                conn.Close();
            }

            catch (Exception ex)
            {
                MessageBox.Show("Unsuccessfull" + ex);
                //added an application exit cause if the program threw an exception it went into an infinite loop :/
                Application.Exit();
            }
        }

       
    }
}
