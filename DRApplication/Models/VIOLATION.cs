using System;
using System.Collections.Generic;

namespace DRApplication.Models
{
    public partial class VIOLATION
    {
        public VIOLATION()
        {
            this.DRs = new List<DR>();
        }

        public string VIO_CODE { get; set; }
        public string VIO_SHORT_DESC { get; set; }
        public string VIO_LONG_DESC { get; set; }
        public string VIO_R_FLAG { get; set; }
        public virtual ICollection<DR> DRs { get; set; }
    }
}
