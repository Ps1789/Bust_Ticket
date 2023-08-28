using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusTicket.Model
{
    public class Routes
    {
       public int  route_id { get; set; }
       public String route_name { get; set; }

        public String origin { get; set;}
    
        public String destination { get; set;}

        public Decimal distance { get; set;}

    }
}
