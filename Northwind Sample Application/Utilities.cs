using System;
using System.Text;


namespace Northwind_Sample_Application
{
    public class Utilities
    {
        public string GetConnectionString()
        {
            System.Configuration.Configuration rootWebConfig = System.Web.Configuration.WebConfigurationManager.OpenWebConfiguration("/Northwind Sample Application");
            string ConnString = rootWebConfig.ConnectionStrings.ConnectionStrings["Conn_String"].ConnectionString;
            return ConnString;


        }
       public string HashSHA1(string value)
            {
                var sha1 = System.Security.Cryptography.SHA1.Create();
                var inputBytes = Encoding.ASCII.GetBytes(value);
                var hash = sha1.ComputeHash(inputBytes);

                var sb = new StringBuilder();
                for (var i = 0; i < hash.Length; i++)
                {
                    sb.Append(hash[i].ToString("X2"));
                }
                return sb.ToString();
            }
    }
}