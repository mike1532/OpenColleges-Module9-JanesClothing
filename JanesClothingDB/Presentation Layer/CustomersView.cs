using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//added to access database and folders
using System.Data.SqlClient;
using JanesClothingDB.Data_Access_Layer;
using JanesClothingDB.Business_Logic_Layer;

namespace JanesClothingDB.Presentation_Layer
{
    public partial class frmCustomersView : Form
    {
        public frmCustomersView()
        {
            InitializeComponent();
        }

        private void lvCustomers_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        //when called, will populate the ListView control with rows from the Customers table
        public void DisplayCustomers()
        {
            string selectQuery = " SELECT Customers.CustomersID, Categories.Category, Customers.FirstName, Customers.LastName, "
                + " Customers.Address, Customers.Suburb, Customers.State, Customers.Postcode, "
                + " Customers.Gender, Customers.SendCatalogue FROM Customers INNER JOIN "
                + "Categories ON Customers.CustomerID = Categories.CategoryID";

            //calls DatabaseConnection method from ConnectionManager.cs file and instantiate DataReaderObject
            SqlConnection conn = ConnectionManager.DatabaseConnection();            
            SqlDataReader rdr = null;

            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(selectQuery, conn);
                //TO-DO finish method code
            }
            catch (Exception ex)
            {
                MessageBox.Show("Unsuccessfull" + ex);
            }
        }
    }
}
