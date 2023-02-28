using System;
using System.Collections.Generic;

#nullable disable

namespace FirstApi.Models
{
    public partial class HarshitEmpList
    {
        public HarshitEmpList()
        {
            HarshitEmpAbouts = new HashSet<HarshitEmpAbout>();
        }

        public int EId { get; set; }
        public string EName { get; set; }
        public string EAdd { get; set; }
        public string EPhone { get; set; }
        public string EDesg { get; set; }
        public DateTime EDoj { get; set; }

        public virtual ICollection<HarshitEmpAbout> HarshitEmpAbouts { get; set; }
    }
}
