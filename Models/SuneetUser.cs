using System;
using System.Collections.Generic;

#nullable disable

namespace FirstApi.Models
{
    public partial class SuneetUser
    {
        public int UserId { get; set; }
        public string Username { get; set; }
        public string Userpassword { get; set; }
        public bool? IsAdmin { get; set; }
    }
}
