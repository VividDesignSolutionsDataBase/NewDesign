namespace DRApplication
{
    using System;
    using System.Collections.Generic;

    public partial class EMPLOYEE
    {
        public EMPLOYEE()
        {
            this.DRs = new HashSet<DR>();
        }

        public int EMP_ID { get; set; }
        public string EMP_PASSW { get; set; }
        public string EMP_LAST_NAME { get; set; }
        public string EMP_FIRST_NAME { get; set; }
        public string EMP_ROLE { get; set; }
        public string EMP_LOCATION { get; set; }

        public virtual ICollection<DR> DRs { get; set; }
    }
}
