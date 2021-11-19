using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

// Manage Products page
// Admin page
// Allows for the admin to view the product listing, and navigate to the AddNewProduct.aspx page

namespace c3305879_Assign2
{
    public partial class ManageProducts : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            try //try catch for error prevention
            {
                ProductList ProdList = new ProductList(); //create new ProductList

                DataSet dstProducts = ProdList.View(); //call the View() method
                gvProductList.DataSource = dstProducts; //assign dstProducts to the DataSource of the GridView
                gvProductList.DataBind();

            }

            catch (Exception ex)
            {
                lblStatus.Text = ex.Message.ToString();
            }

        }

        protected void btnAddProduct_Click(object sender, EventArgs e)
        {
            Response.Redirect("AddNewProduct.aspx"); //redirect the user to AddNewProduct.aspx
        }
    }
}