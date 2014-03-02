using System;
using System.Collections.Generic;

namespace DRApplication.Models
{
    public partial class DR
    {
        public int DR_REPORT_NUM { get; set; }
        public int DR_FIRST_APPROVAL_EMP_ID { get; set; }
        public string DR_INM_VIOLATION_CODE { get; set; }
        public string DR_INM_JAIL_NUM { get; set; }
        public string DR_INM_LAST_NAME { get; set; }
        public string DR_INM_FIRST_NAME { get; set; }
        public string DR_INM_RACE { get; set; }
        public string DR_INM_SEX { get; set; }
        public string DR_INM_AGE { get; set; }
        public string DR_OFFICER_FACILITY { get; set; }
        public string DR_HOUSE_LOC { get; set; }
        public string DR_CMIS_CONT_LOG { get; set; }
        public System.DateTime DR_INCIDENT_DATE { get; set; }
        public System.TimeSpan DR_INCIDENT_TIME { get; set; }
        public string DR_INCIDENT_LOCATION { get; set; }
        public string DR_STATE_FACTS { get; set; }
        public Nullable<System.DateTime> DR_DATE_INIT_SUBMISSION_COMP { get; set; }
        public string DR_INITSUB_COMP_FLAG { get; set; }
        public string DR_FIRST_APPROVAL_FLAG { get; set; }
        public string DR_FIRST_REJECT_REASON { get; set; }
        public string DR_FIRST_REJECT_FLAG { get; set; }
        public Nullable<System.TimeSpan> DR_TIME_INIT_SUBMISSION_COMP { get; set; }
        public int EmployeeEMP_ID { get; set; }
        public string ViolationVIO_CODE { get; set; }
        public virtual DRINVESTIGATION DRINVESTIGATION { get; set; }
        public virtual EMPLOYEE EMPLOYEE { get; set; }
        public virtual VIOLATION VIOLATION { get; set; }
    }
}
