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
    public partial class Contact : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Utilities Util = new Utilities();
            string strUserName = UserName.Text;
            string strPassWord = Password.Text;
            string strRole = RoleList.Text;
            // First create a new Guid for the user. This will be unique for each user
            Guid userGuid = System.Guid.NewGuid();
            string strConnstring = Util.GetConnectionString();
            SqlConnection sqlConn = new SqlConnection(strConnstring);
            // Hash the password together with our unique userGuid
            string hashedPassword = Util.HashSHA1(strPassWord + userGuid.ToString());
            using (SqlCommand cmd = new SqlCommand("INSERT INTO [Users] VALUES (@username, @password, @userguid, @UserRole)", sqlConn))
            {
                cmd.Parameters.AddWithValue("@username", strUserName);
                cmd.Parameters.AddWithValue("@password", hashedPassword); // store the hashed value
                cmd.Parameters.AddWithValue("@userguid", userGuid); // store the Guid
                cmd.Parameters.AddWithValue("@UserRole", strRole); // store the Role

                sqlConn.Open();
                cmd.ExecuteNonQuery();
                sqlConn.Close();
            }
    }
}