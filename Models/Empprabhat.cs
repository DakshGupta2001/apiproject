﻿using System;
using System.Collections.Generic;

#nullable disable

namespace FirstApi.Models
{
    public partial class Empprabhat
    {
        public int Eid { get; set; }
        public string Ename { get; set; }
        public int? Salary { get; set; }
        public DateTime? Doj { get; set; }
        public string City { get; set; }
    }
}
