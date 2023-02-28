using System;
using System.Collections.Generic;

#nullable disable

namespace FirstApi.Models
{
    public partial class ManasPort
    {
        public ManasPort()
        {
            ManasFerryDestinations = new HashSet<ManasFerry>();
            ManasFerryOrigins = new HashSet<ManasFerry>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Image { get; set; }

        public virtual ICollection<ManasFerry> ManasFerryDestinations { get; set; }
        public virtual ICollection<ManasFerry> ManasFerryOrigins { get; set; }
    }
}
