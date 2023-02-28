using System;
using System.Collections.Generic;

#nullable disable

namespace FirstApi.Models
{
    public partial class TouristPlace
    {
        public TouristPlace()
        {
            PlaceImages = new HashSet<PlaceImage>();
            PlaceServiceProviders = new HashSet<PlaceServiceProvider>();
        }

        public int PlaceId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Country { get; set; }
        public decimal PlaceRating { get; set; }

        public virtual ICollection<PlaceImage> PlaceImages { get; set; }
        public virtual ICollection<PlaceServiceProvider> PlaceServiceProviders { get; set; }
    }
}
