using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

//User Registration page
//User page
//A page to allow the user to register a new account

namespace c3305879_Assign2
{
    public partial class UserRegistration : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnRegister_Click(object sender, EventArgs e)
        {
            try //try catch for error prevention
            {
                CustomerReg CustReg = new CustomerReg(); //create a new CustomerReg
                CustReg.FirstName = tbxFName.Text; //assign the tbx values to the variables of CustReg
                CustReg.LastName = tbxLName.Text;
                CustReg.Email = tbxEmail.Text;
                CustReg.Password = tbxPassword.Text;
                CustReg.contactNo = tbxContactNo.Text;
                CustReg.Address = tbxAddress.Text;

                bool status = CustReg.Save(); //call the Save() method

                if (status == true) //if Save() returns true
                {
                    Session["username"] = tbxEmail.Text; //assign the username variable the value of tbxEmail
                    Response.Redirect("Home.aspx"); //redirect the user to the homepage
                }
                else
                {
                    lblStatus.Text = "Failure."; //update the status label to show that the registration did not succeed
                }
            }

            catch (Exception ex)
            {
                lblStatus.Text = ex.Message.ToString();
            }
        }
    }
}