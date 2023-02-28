using System;
using System.Collections.Generic;

#nullable disable

namespace FirstApi.Models
{
    public partial class ServiceProvider
    {
        public ServiceProvider()
        {
            PlaceServiceProviders = new HashSet<PlaceServiceProvider>();
        }

        public int ProviderId { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public int Phone { get; set; }
        public string ProviderType { get; set; }
        public decimal ProviderRating { get; set; }

        public virtual ICollection<PlaceServiceProvider> PlaceServiceProviders { get; set; }
    }
}
