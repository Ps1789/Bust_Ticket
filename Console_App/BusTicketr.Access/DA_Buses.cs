using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusTicketr.Access
{
    public class DA_Buses
    {
        public void Insert()
        {
            // Create connection string and assing to class
            SqlConnection sqlConnection = new SqlConnection(ConfigurationManager.ConnectionStrings["DefaultConnection"].ToString());

            // Generate Query
            string query = "Insert into Buses values (1,'UK06AD4587', '60' ,getDate())";

            //Create Command
            SqlCommand cmd = new SqlCommand(query, sqlConnection);

            sqlConnection.Open();
            int rowaffected = cmd.ExecuteNonQuery();

            sqlConnection.Close();
        }
        public void Update()
        {
            SqlConnection sqlConnection = new SqlConnection(ConfigurationManager.ConnectionStrings["DefaultConnection"].ToString());
            string query = "update Buses set bus_number ='UK06AD4587' where  bus_id=1";
            SqlCommand command = new SqlCommand(query, sqlConnection);
            SqlCommand cmd = command;
            sqlConnection.Open();
            int row = cmd.ExecuteNonQuery();
            sqlConnection.Close();
        }

        public void DeletePassengers()
        {
            SqlConnection sqlConnection = new SqlConnection(ConfigurationManager.ConnectionStrings["DefaultConnection"].ToString());
            string query = "delete from Buses where  bus_id=1 ";
            SqlCommand cmd = new SqlCommand(query, sqlConnection);
            sqlConnection.Open();
            int row = cmd.ExecuteNonQuery();
            sqlConnection.Close();
            if (row > 0)
            {
                Console.WriteLine("record deleted");
            }
        }
    }

}
