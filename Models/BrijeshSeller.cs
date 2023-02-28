﻿using System;
using System.Collections.Generic;

#nullable disable

namespace FirstApi.Models
{
    public partial class BrijeshSeller
    {
        public BrijeshSeller()
        {
            BrijeshProperties = new HashSet<BrijeshProperty>();
        }

        public int SellerId { get; set; }
        public string SellerName { get; set; }
        public string SellerPassword { get; set; }

        public virtual ICollection<BrijeshProperty> BrijeshProperties { get; set; }
    }
}
