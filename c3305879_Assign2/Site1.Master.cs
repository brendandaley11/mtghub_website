using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

// Site1.Master
// User master page
// Provides the navmenu and design for the user section of the website

namespace c3305879_Assign2
{
    public partial class Site1 : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["username"] != null) //if the user is logged in
            {
                lblWelcome.Text = "Welcome, " + Session["username"] + "!"; //update welcome label
                lblLogin.Visible = false; //make the login and register buttons invisible, and cart and logout buttons visible
                lblRegister.Visible = false;
                lblCart.Visible = true;
                lblLogout.Visible = true;
            }

            if (Session["cart_count"] != null) //if the cart isn't empty
            {
                lblCart.Text = "Cart (" + Session["cart_count"] + ")"; //update the cart count
            }

        }
    }
}