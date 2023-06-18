using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using TrophyPrints.Models;

namespace TrophyPrints.Services
{
    public class UsersDAO
    {
        string connectionString = @"Data Source = (LocalDB)\MSSQLLocalDB;Initial Catalog = TrophyUsers; Integrated Security = True; Connect Timeout = 30; Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";


        public bool VerifyUsersNandDOB(UserModel user)
        {

            bool success = false;
            string sqlStatement = "SELECT * FROM dbo.userTable WHERE Username = @username and Password = @password";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(sqlStatement, connection);
                command.Parameters.Add("@username", System.Data.SqlDbType.VarChar, 40).Value = user.UserName;
                command.Parameters.Add("@password", System.Data.SqlDbType.VarChar, 40).Value = user.Password;

                try
                {
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();
                    if (reader.HasRows)
                    {
                        success = true;
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                
                }
                return success;
            }
        }
    }
}
