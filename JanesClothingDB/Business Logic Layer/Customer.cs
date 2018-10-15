using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JanesClothingDB.Business_Logic_Layer
{
    class Customer
    {
        //declare properties of Customer
        private string firstName, lastName, category, gender, address, suburb, state, sendCatalogue;
        private int customerID, postCode;

        //Get-set properties
        public int CustomerID
        {
            get { return customerID; }
            set { customerID = value; }
        }
        public string FirstName
        {
            get { return firstName; }
            set { firstName = value; }
        }
        public string LastName
        {
            get { return lastName; }
            set { lastName = value; }
        }
        public string Category
        {
            get { return category; }
            set { category = value; }
        }
        public string Gender
        {
            get { return gender; }
            set { gender = value; }
        }
        public string Address
        {
            get { return address; }
            set { address = value; }
        }
        public string Suburb
        {
            get { return suburb; }
            set { suburb = value; }
        }
        public string State
        {
            get { return state; }
            set { state = value; }
        }
        public int PostCode
        {
            get { return postCode; }
            set { postCode = value; }
        }
        public string SendCatalogue
        {
            get { return sendCatalogue; }
            set { sendCatalogue = value; }
        }

        //declaring default constructor
        public Customer() { }

        //parameterised constructor
        public Customer(int customerId, string firstName, string lastName, string category, string gender,
                        string address, string suburb, string state, int postCode, string sendCatalogue)
        {
            CustomerID = customerId;
            FirstName = firstName;
            LastName = lastName;
            Category = category;
            Gender = gender;
            Address = address;
            Suburb = suburb;
            State = state;
            PostCode = postCode;
            SendCatalogue = sendCatalogue;
        }

    }
}
