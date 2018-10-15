using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JanesClothingDB.Business_Logic_Layer
{
    class Product
    {
        //declare properties of Product
        private int productID;
        private string brand, productDescription, gender, colourFast;
        private decimal price;

        //get-set properties
        public int ProductID
        {
            get { return productID; }
            set { productID = value; }
        }
        public string Brand
        {
            get { return brand; }
            set { brand = value; }
        }
        public string ProductDescription
        {
            get { return productDescription; }
            set { productDescription = value; }
        }
        public string Gender
        {
            get { return gender; }
            set { gender = value; }
        }
        public string ColourFast
        {
            get { return colourFast; }
            set { colourFast = value; }
        }
        public decimal Price
        {
            get { return price; }
            set { price = value; }
        }

        //declare default constructor
        public Product() { }

        //declare parameterised constructor
        public Product(int productID, string brand, string productDescription, string gender,
                        string colourFast, decimal price)
        {
            ProductID = productID;
            Brand = brand;
            ProductDescription = productDescription;
            Gender = gender;
            ColourFast = colourFast;
            Price = price;
        }
            
    }
}
