using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

//Unauthorised Access page
//User page
//Used as an error prevention technique to stop users from accessing any important admin pages
//This page is only used in Admin.Master as a parameter in the Response.Redirect() method

namespace c3305879_Assign2
{
    public partial class UnauthorisedAccess : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
    }
}