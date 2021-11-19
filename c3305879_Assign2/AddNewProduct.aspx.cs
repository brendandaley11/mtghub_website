using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

// Add new product page
// Admin page
// Provides the admin the medium to add a new product to the listing.
// The admin must enter the product name, price, description of the product and the category the product belongs to.

namespace c3305879_Assign2
{
    public partial class AddNewProduct : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            try //try catch for error prevention
            {
                ProductList Product= new ProductList(); //create a new ProductList called Product
                Product.productName = tbxProductName.Text; //assign the entries the admin has provided to variables of Product
                Product.productPrice = Convert.ToInt32(tbxPrice.Text);
                Product.productDescription = tbxDescription.Text;
                Product.productCategory = tbxCategory.Text;

                bool status = Product.Add(); //call the Add() method

                if (status == true) //if it returns true (a.k.a works)
                {
                    Response.Redirect("ManageProducts.aspx"); //redirect the user to ManageProducts.aspx
                }
                else
                {
                    lblStatus.Text = "Failure.";
                }
            }

            catch (Exception ex)
            {
                lblStatus.Text = ex.Message.ToString();
            }
        }
    }
}