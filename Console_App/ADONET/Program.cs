using BusTicketr.Access;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADONET
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //DA_Buses b = new DA_Buses();
            DA_Passengers p = new DA_Passengers();
              p.InsertPassengers();
         //   p.UpdatePassengers();

        }
    }
}