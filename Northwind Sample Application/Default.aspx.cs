using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;


namespace Northwind_Sample_Application
{
    public partial class _Default : Page
    {
        protected void Button1_Click(object sender, EventArgs e)
        {
            Utilities Util = new Utilities();
            string strConnstring = Util.GetConnectionString();
            string strUserName = UserName.Text;
            string strPassword = Password.Text;
            string strDBPass = string.Empty;
            string strDBGUID = string.Empty;
            string strRole = string.Empty;
            SqlConnection sqlConn = new SqlConnection(strConnstring);
            SqlCommand sqlCmd = new SqlCommand("SELECT UserId, Password, UserGuid FROM [Users] WHERE username=@username", sqlConn);
            sqlCmd.Parameters.AddWithValue("@username", strUserName);
            sqlConn.Open();
            SqlDataReader reader = sqlCmd.ExecuteReader();
            if (reader.Read())
            {
                strDBGUID = Convert.ToString(reader["UserGuid"]);
                strDBPass = Convert.ToString(reader["Password"]);
                strRole = Convert.ToString(reader["UserRole"]);
            }
            else
            {
                Response.Write("Username Does not exist. Please check and try again");
            }

            strPassword = Util.HashSHA1(strPassword + strDBGUID);
            if (strDBPass == strPassword)
            {
                //Create code to redirect to the home page based on access level. 
                if (strRole == "Clerk")
                {
                    Response.Redirect("/Home.aspx");
                }
                else if (strRole == "Manager")
                {

                }
            }
            else
            {
                //make code to show alert.
                //Response.Write("Invalid Password");
                Response.Write("<script language=javascript>alert('Invalid Password');</script>");
            }

        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Redirect("/NewUser.aspx");
        }
    }
}