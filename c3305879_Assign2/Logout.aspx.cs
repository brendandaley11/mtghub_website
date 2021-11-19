using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

//Logout page
//Both page
//The user will never see this page as it automatically redirects to the login page once loaded.

namespace c3305879_Assign2
{
    public partial class Logout : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["cart"] != null) //if the cart has items in it
            {
                try //try catch for error prevention
                {
                    Cart CurrentCart = (Cart)Session["cart"]; //assign CurrentCart the value of the "cart" Session

                    bool status = CurrentCart.RemoveCart(); //call the RemoveCart command

                    if (status == true)
                    {
                        Session.Clear(); //clear the session
                        Response.Redirect("UserLogin.aspx"); //redirect the user to the login page
                    }
                    else
                    {
                        Response.Redirect("UserLogin.aspx"); //error prevention
                    }


                }
                catch (Exception ex)
                {
                    Response.Redirect("UserLogin.aspx"); //error prevention
                }
            }
            else
            {
                Session.Clear(); //clear the session
                Response.Redirect("UserLogin.aspx"); //redirect the user to the login page
            }
            
            
        }
    }
}