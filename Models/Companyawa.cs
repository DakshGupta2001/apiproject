using System;
using System.Collections.Generic;

#nullable disable

namespace FirstApi.Models
{
    public partial class Companyawa
    {
        public Companyawa()
        {
            Flightawas = new HashSet<Flightawa>();
        }

        public string Cid { get; set; }
        public string Cname { get; set; }

        public virtual ICollection<Flightawa> Flightawas { get; set; }
    }
}
