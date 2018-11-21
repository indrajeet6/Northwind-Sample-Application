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
        protected void Page_Load(object sender, EventArgs e)
        {
            
            //// First create a new Guid for the user. This will be unique for each user
            //Guid userGuid = System.Guid.NewGuid();

            //// Hash the password together with our unique userGuid
            //string hashedPassword = Util.HashSHA1("Indrani7&" + userGuid.ToString());
            //using (SqlCommand cmd = new SqlCommand("INSERT INTO [Users] VALUES (@username, @password, @userguid)", sqlConn))
            //{
            //    cmd.Parameters.AddWithValue("@username", "indrajeet6");
            //    cmd.Parameters.AddWithValue("@password", hashedPassword); // store the hashed value
            //    cmd.Parameters.AddWithValue("@userguid", userGuid); // store the Guid

            //    sqlConn.Open();
            //    cmd.ExecuteNonQuery();
            //    sqlConn.Close();
            //}


        }

        protected void Login1_Authenticate(object sender, AuthenticateEventArgs e)
        {
            Utilities Util = new Utilities();
            string strConnstring = Util.GetConnectionString();
            string strUserName = Login1.UserName.ToString();
            string strPassword = Login1.Password.ToString();
            string strDBPass = string.Empty;
            string strDBGUID = string.Empty;
            SqlConnection sqlConn = new SqlConnection(strConnstring);
            SqlCommand sqlCmd = new SqlCommand("SELECT UserId, Password, UserGuid FROM [Users] WHERE username=@username", sqlConn);
            sqlCmd.Parameters.AddWithValue("@username", strUserName);
            sqlConn.Open();
            SqlDataReader reader = sqlCmd.ExecuteReader();
            if (reader.Read())
            {
                strDBGUID = Convert.ToString(reader["UserGuid"]);
                strDBPass = Convert.ToString(reader["Password"]);
            }
            else
            {
                Login1.FailureText = "Username Does not exist. Please cehck and try again";
            }

            strPassword = Util.HashSHA1(strPassword + strDBGUID);
            if (strDBPass == strPassword)
            {

                //Create code to redirect to the home page based on access level. 

            }
        }
    }
}