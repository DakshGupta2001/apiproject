using System;
using System.Collections.Generic;

#nullable disable

namespace FirstApi.Models
{
    public partial class IBooking
    {
        public int BookingId { get; set; }
        public int UserId { get; set; }
        public int FlightId { get; set; }
        public string SeatNumber { get; set; }
        public DateTime BookingDate { get; set; }

        public virtual IFlight Flight { get; set; }
        public virtual IUser User { get; set; }
    }
}
