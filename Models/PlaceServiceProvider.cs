using System;
using System.Collections.Generic;

#nullable disable

namespace FirstApi.Models
{
    public partial class PlaceServiceProvider
    {
        public int PlaceId { get; set; }
        public int ProviderId { get; set; }

        public virtual TouristPlace Place { get; set; }
        public virtual ServiceProvider Provider { get; set; }
    }
}
