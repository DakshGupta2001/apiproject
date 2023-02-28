using System;
using System.Collections.Generic;

#nullable disable

namespace FirstApi.Models
{
    public partial class RahulUser
    {
        public RahulUser()
        {
            RahulBookings = new HashSet<RahulBooking>();
        }

        public int Userid { get; set; }
        public string Username { get; set; }
        public string Userpassword { get; set; }
        public bool IsAdmin { get; set; }

        public virtual ICollection<RahulBooking> RahulBookings { get; set; }
    }
}
