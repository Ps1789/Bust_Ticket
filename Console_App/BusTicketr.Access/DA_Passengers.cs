using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace BusTicketr.Access
{
    public class DA_Passengers
    {
        public void InsertPassengers()
        {
            // Create connection string and assing to class
            SqlConnection sqlConnection = new SqlConnection(ConfigurationManager.ConnectionStrings["DefaultConnection"].ToString());

            // Generate Query
            string query = "Insert into Passengers values (2,'Abhay', 'Singh' ,'abhaysingh@gmail.com','8986585665','1978-02-2',getDate())";

            //Create Command
            SqlCommand cmd = new SqlCommand(query, sqlConnection);

            sqlConnection.Open();
            int rowaffected = cmd.ExecuteNonQuery();

            sqlConnection.Close();
        }
        public void UpdatePassengers()
        {
            SqlConnection sqlConnection = new SqlConnection(ConfigurationManager.ConnectionStrings["DefaultConnection"].ToString());
            string query = "update Passengers set first_name='Arun' where passenger_id=1";
            SqlCommand command = new SqlCommand(query, sqlConnection);
            SqlCommand cmd = command;
            sqlConnection.Open();
            int row = cmd.ExecuteNonQuery();
            sqlConnection.Close();
        }

        public void DeletePassengers()
        {
            SqlConnection sqlConnection = new SqlConnection(ConfigurationManager.ConnectionStrings["DefaultConnection"].ToString());
            string query = "delete from Passengers where passenger_id=2 ";
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