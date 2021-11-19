using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

// Admin.Master
// Admin master page
// Provides the navmenu and design for the admin section of the website

namespace c3305879_Assign2
{
    public partial class Admin : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if ((String)Session["username"] != "admin@email.com") //if the user isn't logged into the admin account
            {
                Response.Redirect("UnauthorisedAccess.aspx"); //redirect unauthorised users (non admin) to an error page
            }
            else
            {
                if (Session["username"] != null) //if the user is logged in
                {
                    lblWelcome.Text = "Welcome, " + Session["username"] + "!"; //update the welcome label
                }
            }

        }
    }
}