using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

// User list page
// Admin page
// Displays the current user list within a GridView

namespace c3305879_Assign2
{
    public partial class UserList : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            try //try catch for error prevention
            {
                CustomerReg UserList = new CustomerReg(); //create a new CustomerReg

                DataSet dstUsers = UserList.ViewUsers(); //call the ViewUsers method
                gvUserList.DataSource = dstUsers; //assign dstUsers to the data source of the grid view
                gvUserList.DataBind();

            }

            catch (Exception ex)
            {
                lblStatus.Text = ex.Message.ToString();
            }

        }
    }
}