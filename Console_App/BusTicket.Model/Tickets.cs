using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusTicket.Model
{
    public class Tickets
    {
      public int ticket_id { get; set; }
      public int passenger_id { get; set; }
      public int bus_id { get; set; }
      public int route_id { get; set; }
      public string seat_number { get; set; }
      public Decimal fare { get; set; }
 
    }
}
