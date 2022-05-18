using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using Npgsql;

namespace UnsaveWebsiteLogin
{
    public class UserInfo
    {
        private string connectionString =
            "Server=localhost;Database=UnsaveWebsiteLogin;User Id=postgres;  Password=Kode1234";
            
        public string GetUser(string username, string passwords)
        {
            using (NpgsqlConnection connection = new NpgsqlConnection(connectionString))
            {
                connection.Open();
                string query = $"SELECT Username FROM Users WHERE Username = '{username}' AND Password = '{passwords}'";
                NpgsqlCommand command = new NpgsqlCommand(query, connection);
                
                var test = command.ExecuteReader();
                while (test.Read())
                {
                    return (string)test["Username"];
                }

            }

            return null;
        }
    }
}