using System;
using System.Collections.Generic;

#nullable disable

namespace FirstApi.Models
{
    public partial class Review
    {
        public int ReviewId { get; set; }
        public int Userid { get; set; }
        public int VehicleId { get; set; }
        public string Review1 { get; set; }

        public virtual Customer User { get; set; }
        public virtual Vehicle Vehicle { get; set; }
    }
}
