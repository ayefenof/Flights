using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Notifications.Data
{
    public class Flight
    {
        public int Id { get; set; }

        public int AirlineId { get; set; }
        public int Price { get; set; } // defined as int to simplify the code
        public Location Destination { get; set; }
        public Location Source { get; set; }

        public DateTime FlightTime { get; set; }

        public DateTime LandingTime { get; set; }
    }
}
