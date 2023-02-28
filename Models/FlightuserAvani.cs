using System;
using System.Collections.Generic;

#nullable disable

namespace FirstApi.Models
{
    public partial class FlightuserAvani
    {
        public FlightuserAvani()
        {
            FlightbookingAvanis = new HashSet<FlightbookingAvani>();
        }

        public int Userid { get; set; }
        public string Username { get; set; }
        public string Userpass { get; set; }

        public virtual ICollection<FlightbookingAvani> FlightbookingAvanis { get; set; }
    }
}
