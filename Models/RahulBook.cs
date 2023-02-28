using System;
using System.Collections.Generic;

#nullable disable

namespace FirstApi.Models
{
    public partial class RahulBook
    {
        public RahulBook()
        {
            RahulBookings = new HashSet<RahulBooking>();
        }

        public int BookId { get; set; }
        public string BookName { get; set; }
        public string BookAuthor { get; set; }
        public int BookQty { get; set; }

        public virtual ICollection<RahulBooking> RahulBookings { get; set; }
    }
}
