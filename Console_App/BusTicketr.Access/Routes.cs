using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusTicketr.Access
{
    public class Routes
    {
        public void Insert()
        {
            
            SqlConnection sqlConnection = new SqlConnection(ConfigurationManager.ConnectionStrings["DefaultConnection"].ToString());

            // Generate Query
            string query = "Insert into Routes values (1,'ABC', 'Kathgodam' , 'Delhi' , '230 km' ,getDate())";

            //Create Command
            SqlCommand cmd = new SqlCommand(query, sqlConnection);

            sqlConnection.Open();
            int rowaffected = cmd.ExecuteNonQuery();

            sqlConnection.Close();
        }
        public void Update()
        {
            SqlConnection sqlConnection = new SqlConnection(ConfigurationManager.ConnectionStrings["DefaultConnection"].ToString());
            string query = "update Routes set origin ='Haldwani' where  route_id=1";
            SqlCommand command = new SqlCommand(query, sqlConnection);
            SqlCommand cmd = command;
            sqlConnection.Open();
            int row = cmd.ExecuteNonQuery();
            sqlConnection.Close();
        }

        public void Delete()
        {
            SqlConnection sqlConnection = new SqlConnection(ConfigurationManager.ConnectionStrings["DefaultConnection"].ToString());
            string query = "delete from Routes where  route_id=1 ";
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
