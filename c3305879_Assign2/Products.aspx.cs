using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

//Products page
//User page
//Showcases the product listing in the form of a GridView

namespace c3305879_Assign2
{
    public partial class Products : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            try //try catch for error prevention
            {
                ProductList ProdList = new ProductList(); //create a new ProductList

                DataSet dstProducts = ProdList.View(); //call the View method
                gvProductList.DataSource = dstProducts; //assign dstProducts to the DataSource of the GridView
                gvProductList.DataBind();

            }

            catch (Exception ex)
            {
                lblStatus.Text = ex.Message.ToString();
            }
        }
            

        protected void gvProductList_SelectedIndexChanged(object sender, EventArgs e) //method for when the user has selected an option on the GridView
        {
            if (Session["username"] != null) //if the user is logged in
            {
                lblProductName.Text = gvProductList.SelectedRow.Cells[1].Text; //assign labels the relative selected row information (for presentation purposes)
                lblProductPrice.Text = gvProductList.SelectedRow.Cells[2].Text;
                lblProductDescription.Text = gvProductList.SelectedRow.Cells[3].Text;

                lblAmount.Visible = true; //show labels
                ddlAmount.Visible = true;
                btnAddToCart.Visible = true;
            }
            else
            {
                Response.Redirect("UserLogin.aspx"); //redirect the user to login, as they cannot order items without being logged into an account
            }
            
        }

        protected void btnAddToCart_Click(object sender, EventArgs e) //method for when the user decides to add the item to their cart 
        {         
            try //try catch for error prevention
            {
                Cart CurrentCart = new Cart(); //create a new cart
                Session["cart"] = CurrentCart; //assign the "cart" session the CurrentCart value
                CurrentCart.userEmail = Convert.ToString(Session["username"]); //assign the variables of CurrentCart to the relative variables of both the username Session and the label values
                CurrentCart.productName = lblProductName.Text;
                CurrentCart.productPrice = Convert.ToInt32(lblProductPrice.Text);
                CurrentCart.productAmount = Convert.ToInt32(ddlAmount.SelectedValue);


                bool status = CurrentCart.AddToCart(); //call the AddToCart() method

                if (status == true) //if AddToCart returns true
                {
                    lblStatus.Text = "Item(s) successfully added to cart."; //update the status label to reflect the successful operation
                    
                    if (Session["cart_count"] != null) //if the cart_count variable is not null
                    {
                        Session["cart_count"] = (int)Session["cart_count"] + Convert.ToInt32(ddlAmount.SelectedValue); //update the cart_count session variable (for presentation purposes in the menu)
                    }
                    else
                    {
                        Session["cart_count"] = Convert.ToInt32(ddlAmount.SelectedValue); //update the cart_count session variable (for presentation purposes in the menu)
                    }
                }
                else
                {
                    lblStatus.Text = "Failure."; //update status label to show adding the item did not succeed
                }
            }
            catch (Exception ex)
            {
                lblStatus.Text = ex.Message.ToString(); //update status label to show adding the item did not succeed
            }
        }
    }
}