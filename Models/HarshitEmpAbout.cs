using System;
using System.Collections.Generic;

#nullable disable

namespace FirstApi.Models
{
    public partial class HarshitEmpAbout
    {
        public int AId { get; set; }
        public string EName { get; set; }
        public string EDept { get; set; }
        public string ESdept { get; set; }
        public string EQual { get; set; }
        public string EHobbies { get; set; }
        public int EmpId { get; set; }

        public virtual HarshitEmpList Emp { get; set; }
    }
}
