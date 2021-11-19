using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

//Business Layer used for product information.
//Contains definitions for all product related information, such as product name, price, description and the category it belongs to.

namespace c3305879_Assign2
{
    public class ProductList
    {
        private string _productName; //define variables
        private float _productPrice;
        private string _productDescription;
        private string _productCategory;

        public string productName //define the properties (getters and setters) for each variable
        {
            get { return _productName; }
            set { _productName = value; }
        }

        public float productPrice
        {
            get { return _productPrice; }
            set { _productPrice = value; }
        }

        public string productDescription
        {
            get { return _productDescription; }
            set { _productDescription = value; }
        }

        public string productCategory
        {
            get { return _productCategory; }
            set { _productCategory = value; }
        }

        public DataSet View() //method used to display products on a GridView (used in Products.aspx and ManageProducts.aspx)
        {
            try //try and catch for error prevention
            {
                DAL obj = new DAL();
                DataSet ds = obj.FetchView();
                return ds;
            }
            catch (Exception ex)
            {
                throw new Exception("There has been an error with displaying products. Please try again.");
            }
        }

        public bool Add() //method used to add a new product to the listing (used in AddNewProduct.aspx)
        {
            try //try and catch for error prevention
            {
                DAL obj = new DAL();
                obj.AddNewProduct(_productName, _productPrice, _productDescription, _productCategory );
                return true;
            }
            catch (Exception ex)
            {
                throw new Exception("There has been an error with adding a new product. Please try again.");
            }
        }
    }
}
