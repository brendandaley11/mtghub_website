using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;


//Business Layer section of the customer's cart.
//Contains definitions for the user's email, product's name + price + amount the user as ordered.

namespace c3305879_Assign2
{
    public class Cart
    {
        private string _userEmail; //define variables
        private string _productName;
        private float _productPrice;
        private int _productAmount;

        public string userEmail //define the properties (getters and setters) for each variable
        {
            get { return _userEmail; }
            set { _userEmail = value; }
        }

        public string productName
        {
            get { return _productName; }
            set { _productName = value; }
        }

        public float productPrice
        {
            get { return _productPrice; }
            set { _productPrice = value; }
        }

        public int productAmount
        {
            get { return _productAmount; }
            set { _productAmount = value; }
        }

        public bool AddToCart() //method to add an item to the user's cart.
        {
            try //try and catch for error prevention
            {
                DAL obj = new DAL();
                obj.AddItem(_userEmail, _productName, _productPrice, _productAmount);
                return true;
            }
            catch (Exception ex)
            {
                throw new Exception("There has been an error with adding your item. Please try again.");
            }
        }

        public bool RemoveCart()//method used to clear user's cart (after checking out or logging off) (Used in Logout.aspx)
        {
            try //try and catch for error prevention
            {
                DAL obj = new DAL();
                obj.ClearCart();
                return true;
            }
            catch (Exception ex)
            {
                throw new Exception("There has been an error clearing your cart.");
            }
        }

        public DataSet ViewCart()//method for displaying the user's cart within a GridView (used in Cart.aspx)
        {
            try //try and catch for error prevention
            {
                DAL obj = new DAL();
                DataSet ds = obj.ViewCart();
                return ds;
            }
            catch (Exception ex)
            {
                throw new Exception("There has been an error with displaying your cart. Please try again.");
            }
        }


    }
}
