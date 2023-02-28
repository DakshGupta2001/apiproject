using System;
using System.Collections.Generic;

#nullable disable

namespace FirstApi.Models
{
    public partial class PlaceImage
    {
        public int ImageId { get; set; }
        public int PlaceId { get; set; }
        public string ImageUrl { get; set; }

        public virtual TouristPlace Place { get; set; }
    }
}
