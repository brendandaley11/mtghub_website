using System;
using System.Collections.Generic;
using System.Text;
using System.Web;
using System.Data;
using System.Data.SqlClient;

// Data Access Layer portion of the project.
// Contains many different methods for viewing and inserting data into the database tables

namespace c3305879_Assign2
{
    public class DAL
    {
        //----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
        // USER REGISTRATION AND USER LOGIN VALIDATION
        //----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
        public bool RegisterData(string strFirstName, string strLastName, string strEmail, string strPassword, string strContactNo, string strAddress) //method called to register a new user
        {
            conString.con.Open(); //open the connection
            try //try catch finally for error prevention
            {
                string query = "INSERT INTO tblUsers VALUES ('" + strFirstName + "','" + strLastName + "','" + strEmail + "','" + strPassword + "','"+ strContactNo +"','" + strAddress + "')";
                SqlCommand cmd = new SqlCommand(query, conString.con);
                cmd.ExecuteNonQuery();
                return true;
            }

            catch(Exception ex)
            {
                throw new Exception(ex.Message.ToString());
            }
            finally
            {
                conString.con.Close(); //close the connection
            }
        }

        public DataTable LoginData(string strEmail, string strPassword) //method called to validate a new user
        {
            conString.con.Open(); //open the connection
            try //try catch finally for error prevention
            {
                string query = "SELECT * FROM tblUsers WHERE Email='" + strEmail + "' and userPassword='" + strPassword + "'";
                SqlDataAdapter da = new SqlDataAdapter(query, conString.con);
                DataSet ds = new DataSet();
                da.Fill(ds);
                DataTable dt;
                dt = ds.Tables[0];
                return dt;
            }

            catch (Exception ex)
            {
                throw new Exception(ex.Message.ToString());
            }
            finally
            {
                conString.con.Close(); //close the connection
            }
        }

        //----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
        // DISPLAYING PRODUCTS
        //----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

        public DataSet FetchView() //method called to display tblProducts within a GridView
        {
            conString.con.Open(); //open the connection
            try //try catch finally for error prevention
            {
                string query = "SELECT * FROM tblProducts";
                SqlDataAdapter da = new SqlDataAdapter(query, conString.con);
                DataSet ds = new DataSet();
                da.Fill(ds);

                return ds;

            }
            catch(Exception ex)
            {
                throw new Exception(ex.Message.ToString());
            }
            finally
            {
                conString.con.Close(); //close the connection
            }
        }

        //----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
        // CART RELATED METHODS
        //----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

        public bool AddItem(string strUserEmail, string strProductName, float fltProductPrice, int intProductAmount) //method called to add an item to the user's cart
        {
            conString.con.Open(); //open the connection
            try //try catch finally for error prevention
            {
                string query = "INSERT INTO tblCart VALUES ('" + strUserEmail + "','" + strProductName + "'," + fltProductPrice + "," + intProductAmount + ")";
                SqlCommand cmd = new SqlCommand(query, conString.con);
                cmd.ExecuteNonQuery();
                return true;
            }

            catch (Exception ex)
            {
                throw new Exception(ex.Message.ToString());
            }
            finally
            {
                conString.con.Close(); //close the connection
            }
        }

        public bool ClearCart() //method called to clear the user's cart after they are finished with it
        {
            conString.con.Open(); //open the connection
            try //try catch finally for error prevention
            {
                string query = "DELETE FROM tblCart";
                SqlCommand cmd = new SqlCommand(query, conString.con);
                cmd.ExecuteNonQuery();
                return true;
            }

            catch (Exception ex)
            {
                throw new Exception(ex.Message.ToString());
            }
            
            finally
            {
                conString.con.Close(); //close the connection
            }
        }

        public DataSet ViewCart() //method called to display the user's cart
        {
            conString.con.Open(); //open the connection
            try //try catch finally for error prevention
            {
                string query = "SELECT * FROM tblCart";
                SqlDataAdapter da = new SqlDataAdapter(query, conString.con);
                DataSet ds = new DataSet();
                da.Fill(ds);

                return ds;

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message.ToString());
            }
            finally
            {
                conString.con.Close(); //close the connection
            }
        }

        //----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
        // ADMIN RELATED METHODS
        //----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

        public bool AddNewProduct(string strProductName, float fltProductPrice, string strProductDesc, string strProductCategory) //method called to add a new product to the listing
        {
            conString.con.Open(); //open the connection
            try //try catch finally for error prevention
            {
                string query = "INSERT INTO tblProducts VALUES ('" + strProductName + "'," + fltProductPrice + ",'" + strProductDesc + "','" + strProductCategory + "')";
                SqlCommand cmd = new SqlCommand(query, conString.con);
                cmd.ExecuteNonQuery();
                return true;
            }

            catch (Exception ex)
            {
                throw new Exception(ex.Message.ToString());
            }
            finally
            {
                conString.con.Close(); //close the connection
            }
        }

        public DataSet ViewUsers() //method called to display users within a GridView
        {
            conString.con.Open(); //open the connection
            try //try catch finally for error prevention
            {
                string query = "SELECT * FROM tblUsers";
                SqlDataAdapter da = new SqlDataAdapter(query, conString.con);
                DataSet ds = new DataSet();
                da.Fill(ds);

                return ds;

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message.ToString());
            }
            finally
            {
                conString.con.Close(); //close the connection
            }
        }
    }
}
