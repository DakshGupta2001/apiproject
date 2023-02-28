using System;
using System.Collections.Generic;

#nullable disable

namespace FirstApi.Models
{
    public partial class Flightawa
    {
        public int Uid { get; set; }
        public string Uname { get; set; }
        public string Jfrom { get; set; }
        public string Jto { get; set; }
        public int Nticket { get; set; }
        public DateTime Doj { get; set; }
        public string Cid { get; set; }

        public virtual Companyawa CidNavigation { get; set; }
    }
}
