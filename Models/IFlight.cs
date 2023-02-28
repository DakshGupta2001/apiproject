using System;
using System.Collections.Generic;

#nullable disable

namespace FirstApi.Models
{
    public partial class IFlight
    {
        public IFlight()
        {
            IBookings = new HashSet<IBooking>();
        }

        public int FlightId { get; set; }
        public string FlightNumber { get; set; }
        public DateTime FlightDate { get; set; }
        public TimeSpan FlightTime { get; set; }
        public string Origin { get; set; }
        public string Destination { get; set; }
        public int AvailableSeats { get; set; }
        public int FlightPrice { get; set; }

        public virtual ICollection<IBooking> IBookings { get; set; }
    }
}
