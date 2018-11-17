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

       
        //loading/closing events
        private void frmCustomersView_Load(object sender, EventArgs e)
        {
            DisplayCustomers();
        }
        private void frmCustomersView_FormClosing(object sender, FormClosingEventArgs e)
        {
            frmMainForm mainForm = new frmMainForm();
            mainForm.Show();
            Hide();
        }
        private void frmCustomersView_FormClosed(object sender, FormClosedEventArgs e)
        {
            //when closing, shows main form and hides add customer form
            frmMainForm mainForm = new frmMainForm();
            mainForm.Show();
            Hide();
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        //add, update, search, delete
        private void btnAdd_Click(object sender, EventArgs e)
        {
            GlobalVariable.selectedCustomerID = 0;
            frmCustomerAdd editForm = new frmCustomerAdd();
            editForm.ShowDialog();
            lvCustomers.Items.Clear();
            DisplayCustomers();
           
        }
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (lvCustomers.SelectedItems.Count == 0)
            {
                MessageBox.Show("Please select a Customer to update.");
                return;
            }
            GlobalVariable.selectedCustomerID = int.Parse(lvCustomers.SelectedItems[0].Text);
            frmCustomerAdd editForm = new frmCustomerAdd();
            editForm.ShowDialog();
            lvCustomers.Items.Clear();
            DisplayCustomers();
        }        
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (lvCustomers.SelectedItems.Count == 0)
            {
                MessageBox.Show("Please select a Customer to delete.");
                return;
            }

            DialogResult dialogResult = MessageBox.Show("Are you sure you wish to delete this record?",
                                            "Customer Delete", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.No)
                return;

            int selectedCustomerID = int.Parse(lvCustomers.SelectedItems[0].Text);
            string deleteQuery = "sp_Customers_DeleteCustomer";

            SqlConnection connection = ConnectionManager.DatabaseConnection();
            connection.Open();
            SqlCommand command = new SqlCommand(deleteQuery, connection);

            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@CustomerID", selectedCustomerID);
            command.Transaction = connection.BeginTransaction();
            command.ExecuteNonQuery();
            command.Transaction.Commit();

            connection.Close();

            lvCustomers.Items.Clear();
            DisplayCustomers();
               
        }
        private void btnSearch_Click(object sender, EventArgs e)
        {
            GlobalVariable.customerSearchCriteria = "";
            frmCustomerSearch searchForm = new frmCustomerSearch();
            searchForm.ShowDialog();
            lvCustomers.Items.Clear();
            DisplayCustomers();
        }

        //when called, will populate the ListView control with rows from the Customers table
        public void DisplayCustomers()
        {
            string selectQuery = " SELECT Customers.CustomerID, Categories.Category, Customers.FirstName, Customers.LastName, "
            + " Customers.Address, Customers.Suburb, Customers.State, Customers.Postcode, "
            + " Customers.Gender, Customers.SendCatalogue FROM Customers INNER JOIN "
            + "Categories ON Customers.CategoryID = Categories.CategoryID";
            selectQuery = selectQuery + " " + GlobalVariable.customerSearchCriteria;


            //calls DatabaseConnection method from ConnectionManager.cs file and instantiate DataReaderObject
            SqlConnection conn = ConnectionManager.DatabaseConnection();
            SqlDataReader rdr = null;

            try
            {
                //Open the connection, passes query of databse to cmd, executes query through SQLDataReader object
                conn.Open();
                SqlCommand cmd = new SqlCommand(selectQuery, conn);
                rdr = cmd.ExecuteReader();

                //defines the variable list items (gender/send catalogue)
                while (rdr.Read())
                {
                    //defaults male. changes to female if F is found
                    string gender = "Male";
                    if (rdr["Gender"].ToString() == "F")
                    {
                        gender = "Female";
                    }

                    //defaults to no, sets entry as a boolean, if true return yes
                    string sendCatalogue = "No";
                    bool sc = rdr.GetBoolean(rdr.GetOrdinal("SendCatalogue"));

                    if (sc)
                    {
                        sendCatalogue = "Yes";
                    }

                    //calls parameterised customer constructor
                    Customer customer = new Customer(int.Parse(rdr["CustomerID"].ToString()), rdr["FirstName"].ToString(),
                                        rdr["LastName"].ToString(), rdr["Category"].ToString(), gender, rdr["Address"].ToString(),
                                        rdr["Suburb"].ToString(), rdr["State"].ToString(), int.Parse(rdr["Postcode"].ToString()), sendCatalogue);

                    //creates ListViewItems, then adds ListViewItems to lvCustomers
                    ListViewItem lvi = new ListViewItem(customer.CustomerID.ToString());
                    lvi.SubItems.Add(customer.FirstName);
                    lvi.SubItems.Add(customer.LastName);
                    lvi.SubItems.Add(customer.Address);
                    lvi.SubItems.Add(customer.Suburb);
                    lvi.SubItems.Add(customer.State);
                    lvi.SubItems.Add(customer.PostCode.ToString());
                    lvi.SubItems.Add(customer.Gender);
                    lvi.SubItems.Add(customer.Category);
                    lvi.SubItems.Add(customer.SendCatalogue);

                    lvCustomers.Items.Add(lvi);

                }

                //if null, close DataReader object and close connection
                if (rdr != null)
                    rdr.Close();
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

