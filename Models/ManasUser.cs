using System;
using System.Collections.Generic;

#nullable disable

namespace FirstApi.Models
{
    public partial class ManasUser
    {
        public ManasUser()
        {
            ManasTickets = new HashSet<ManasTicket>();
        }

        public int Id { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public double Wallet { get; set; }

        public virtual ICollection<ManasTicket> ManasTickets { get; set; }
    }
}
