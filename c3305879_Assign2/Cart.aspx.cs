using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

//Cart page
//User page
//Showcases the items the user has added to their cart.

namespace c3305879_Assign2
{
    public partial class Cart1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            try //try catch for error prevention
            {
                Cart CurrentCart = new Cart(); //create a new Cart object

                DataSet dsCart = CurrentCart.ViewCart(); //call the ViewCart() method
                gvCart.DataSource = dsCart; //assign the new DataSet dsCart as the GridView's data source
                gvCart.DataBind();

            }

            catch (Exception ex)
            {
                lblStatus.Text = ex.Message.ToString();
            }

        }

        protected void btnCheckout_Click(object sender, EventArgs e)
        {
            try //try catch for error prevention
            {
                Cart CurrentCart = (Cart)Session["cart"]; //assign CurrentCart the value of the "cart" Session

                bool status = CurrentCart.RemoveCart(); //call the RemoveCart() method
                Session["cart_count"] = null; //assign the cart_count session variable a null value

                if (status == true) //if RemoveCart() returns true
                {
                    Response.Redirect("OrderConfirmed.aspx"); //redirect the user to the login page
                }
                else
                {
                    Response.Redirect("OrderConfirmed.aspx"); //error prevention
                }


            }
            catch (Exception ex)
            {
                Response.Redirect("OrderConfirmed.aspx"); //error prevention
            }
        }
    }
}