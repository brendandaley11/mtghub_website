using System;
using System.Collections.Generic;
using System.Text;
using System.Data;

//Business Layer section for customer login information.
//Contains definitions for user's email and password.
//This .cs file is used primarily for validation during UserLogin.aspx

namespace c3305879_Assign2
{
    public class CustomerLogin
    {
        private string _Email; //define variables
        private string _Password;

        public string Password //define the properties (getters and setters) for each variable
        {
            get { return _Password; }
            set { _Password = value; }
        }

        public string Email
        {
            get { return _Email; }
            set { _Email = value; }
        }



        public bool IsValidUser(string userEmail, string userPassword) //method used for login validation (used in Login.aspx)
        {
            try //try and catch for error prevention
            {
                DataTable dt;
                DAL obj = new DAL();
                dt = obj.LoginData(userEmail, userPassword);
                if (dt.Rows.Count > 0)
                {
                    return true;
                }
                else
                {
                    return false;

                }
            }
            catch (Exception ex)
            {
                throw new Exception("There has been an error with logging in. Please try again.");
            }
        }
    }
}
