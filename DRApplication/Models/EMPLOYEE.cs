using System;
using System.Collections.Generic;

namespace DRApplication.Models
{
    public partial class EMPLOYEE
    {
        public EMPLOYEE()
        {
            this.DRs = new List<DR>();
        }

        public int EMP_ID { get; set; }
        public string USERNAME { get; set; }
        public string PASSWORD { get; set; }
        public string EMP_LAST_NAME { get; set; }
        public string EMP_FIRST_NAME { get; set; }
        public string EMP_ROLE { get; set; }
        public string EMP_LOCATION { get; set; }
        public string OLDPASSWORD { get; set; }
        public string NEWPASSWORD { get; set; }
        public string CONFIRMPASSWORD { get; set; }
        public virtual ICollection<DR> DRs { get; set; }
    }
}
