using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusTicketr.Access
{
    public class Tickets
    {
        public void Insert()
        {

            SqlConnection sqlConnection = new SqlConnection(ConfigurationManager.ConnectionStrings["DefaultConnection"].ToString());

            // Generate Query
            string query = "Insert into Tickets values (1,1,1,1,'20',230.00,getDate())";

            //Create Command
            SqlCommand cmd = new SqlCommand(query, sqlConnection);

            sqlConnection.Open();
            int rowaffected = cmd.ExecuteNonQuery();

            sqlConnection.Close();
        }
        public void Update()
        {
            SqlConnection sqlConnection = new SqlConnection(ConfigurationManager.ConnectionStrings["DefaultConnection"].ToString());
            string query = "update Tickets set seat_number ='Haldwani' where ticket_id=1";
            SqlCommand command = new SqlCommand(query, sqlConnection);
            SqlCommand cmd = command;
            sqlConnection.Open();
            int row = cmd.ExecuteNonQuery();
            sqlConnection.Close();
        }

        public void Delete()
        {
            SqlConnection sqlConnection = new SqlConnection(ConfigurationManager.ConnectionStrings["DefaultConnection"].ToString());
            string query = "delete from Tickets where ticket_id=1 ";
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
