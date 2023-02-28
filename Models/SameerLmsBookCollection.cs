using System;
using System.Collections.Generic;

#nullable disable

namespace FirstApi.Models
{
    public partial class SameerLmsBookCollection
    {
        public string BookName { get; set; }
        public string Isbn { get; set; }
        public string PublishDate { get; set; }
        public string Category { get; set; }
        public int Quantity { get; set; }
        public string AuthorName { get; set; }
    }
}
