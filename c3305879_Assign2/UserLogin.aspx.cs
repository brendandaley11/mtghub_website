using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

//User login page
//User page
//A page to allow users to login with their account details.

namespace c3305879_Assign2
{
    public partial class UserLogin : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["username"] != null) //if the user is already logged in
            {
                Response.Redirect("Home.aspx"); //redirect them to the home page (error prevention
            }

        }

        protected void btnLogin_Click(object sender, EventArgs e)
        {
            try //try catch for error prevention
            {
                CustomerLogin CustLogin = new CustomerLogin(); //create a new CustomerLogin
                CustLogin.Email = tbxEmail.Text; //assign the variables of CustLogin with the relevant tbx values
                CustLogin.Password = tbxPassword.Text;

                bool status = CustLogin.IsValidUser(tbxEmail.Text, tbxPassword.Text); //call the IsValidUser method

                if (status == true) //if IsValidUser returns true
                {
                    Session["username"] = tbxEmail.Text; //assign the value of tbxEmail to the username session
                    if ((String)Session["username"] == "admin@email.com") //if the user logging in is on the admin account
                    {
                        Response.Redirect("AdminHome.aspx"); //redirect the user to the admin homepage
                    }
                    else
                    {
                        Response.Redirect("Home.aspx"); //redirect the user to the regular homepage
                    }
                    
                }
                else
                {
                    lblStatus.Text = "Incorrect username or password. Please try again."; //update the status label to show the user that they have entered the wrong details
                }
            }

            catch (Exception ex)
            {
                lblStatus.Text = ex.Message.ToString();
            }
        }
    }
}