using System;
using System.Data;
using System.Data.SqlClient;

namespace ATM_Simulation
{
    public class SqlHelper
    {
        private readonly string connectionString = "Server=DESKTOP-O3E79VF;Database=ATM_DB;Trusted_Connection=True;";

        public bool AuthenticateUser(int customerId, int pin)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "SELECT COUNT(*) FROM Customers WHERE CustomerID = @CustomerID AND PIN = @PIN";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@CustomerID", customerId);
                cmd.Parameters.AddWithValue("@PIN", pin);

                conn.Open();
                int count = (int)cmd.ExecuteScalar();
                return count > 0;
            }
        }
    }
}
