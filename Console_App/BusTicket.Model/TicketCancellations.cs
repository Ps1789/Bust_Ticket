using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusTicket.Model
{
    public class TicketCancellations
    {
      public int  cancellation_id { get; set; }                                 
      public int ticket_id { get; set; }
        public DateTime cancellation_date { get; set; }
      public Decimal refund_amount { get; set; }
    }
}
