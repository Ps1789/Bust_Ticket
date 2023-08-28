using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusTicketr.Access
{
    public class TicketCancellations
    {
        public void Insert()
        {

            SqlConnection sqlConnection = new SqlConnection(ConfigurationManager.ConnectionStrings["DefaultConnection"].ToString());

            // Generate Query
            string query = "Insert into TicketCancellations values (1,1,2002-12-12,'200.00',getDate())";

            //Create Command
            SqlCommand cmd = new SqlCommand(query, sqlConnection);

            sqlConnection.Open();
            int rowaffected = cmd.ExecuteNonQuery();

            sqlConnection.Close();
        }
        public void Update()
        {
            SqlConnection sqlConnection = new SqlConnection(ConfigurationManager.ConnectionStrings["DefaultConnection"].ToString());
            string query = "update TicketCancellations  set refund_amount ='210.00' where cancellation_id=1";
            SqlCommand command = new SqlCommand(query, sqlConnection);
            SqlCommand cmd = command;
            sqlConnection.Open();
            int row = cmd.ExecuteNonQuery();
            sqlConnection.Close();
        }

        public void Delete()
        {
            SqlConnection sqlConnection = new SqlConnection(ConfigurationManager.ConnectionStrings["DefaultConnection"].ToString());
            string query = "delete from TicketCancellations where cancellation_id=1 ";
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
