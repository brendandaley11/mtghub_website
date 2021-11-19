using System;
using System.Collections.Generic;
using System.Text;
using System.Data;

//Business Layer used for customer registration data.
//Contains definitions for all important user data, including first and last name, email, contact number, password and shipping address.

namespace c3305879_Assign2
{
    public class CustomerReg
    {
        private string _FirstName; //define variables
        private string _LastName;
        private string _Email;
        private string _contactNo; //contactNo is set as a string since we aren't doing any calculations with the number
        private string _Password;
        private string _Address;

        public string Address //define the properties (getters and setters) for each variable
        {
            get { return _Address; }
            set { _Address = value; }
        }
        public string Password
        {
            get { return _Password; }
            set { _Password = value; }
        }
        public string contactNo
        {
            get { return _contactNo; }
            set { _contactNo = value; }
        }

        public string Email
        {
            get { return _Email; }
            set { _Email = value; }
        }

        public string LastName
        {
            get { return _LastName; }
            set { _LastName = value; }
        }
        public string FirstName
        {
            get { return _FirstName; }
            set { _FirstName = value; }
        }


        public bool Save() //method to register a new user within the database (used in UserRegistration.aspx)
        {
            try
            {
                DAL obj = new DAL();
                obj.RegisterData(_FirstName, _LastName, _Email, _Password, _contactNo, _Address);
                return true;
            }
            catch (Exception ex)
            {
                throw new Exception("There has been an error with registering. Please try again.");
            }
        }

        public DataSet ViewUsers() //method used to display users within a GridView (used in UserList.aspx)
        {
            try //try and catch for error prevention
            {
                DAL obj = new DAL();
                DataSet ds = obj.ViewUsers();
                return ds;
            }
            catch (Exception ex)
            {
                throw new Exception("There has been an error with displaying your cart. Please try again.");
            }
        }
    }
}
