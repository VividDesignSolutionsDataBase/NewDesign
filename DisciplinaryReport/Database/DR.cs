//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DisciplinaryReport.Database
{
    using System;
    using System.Collections.Generic;
    
    public partial class DR
    {
        public DR()
        {
            this.DRInvestigations = new HashSet<DRInvestigation>();
        }
    
        public int DR_REPORT_NUM { get; set; }
        public string DR_FIRST_APPROVAL_EMP_ID { get; set; }
        public string EmployeeEMP_ID { get; set; }
        public string DR_INM_VIOLATION_CODE { get; set; }
        public string DR_INM_LAST_NAME { get; set; }
        public string DR_INM_FIRST_NAME { get; set; }
        public string DR_INM_RACE { get; set; }
        public string DR_INM_SEX { get; set; }
        public string DR_INM_AGE { get; set; }
        public string DR_FACILITY { get; set; }
        public string DR_FAC_LOCATION { get; set; }
        public string DR_INM_CONT_LOG { get; set; }
        public System.DateTime DR_INCIDENT_DATE { get; set; }
        public System.TimeSpan DR_INCIDENT_TIME { get; set; }
        public string DR_INCIDENT_LOCATION { get; set; }
        public string DR_STATE_FACTS { get; set; }
        public string DR_DATE_INTISUB_COMP { get; set; }
        public string DR_INITSUB_COMP { get; set; }
        public string DR_FIRST_APPROVAL_FLAG { get; set; }
        public string DR_FIRST_REJECT_REASON { get; set; }
        public string DR_FIRST_REJECT_FLAG { get; set; }
        public string LocationLOC_FAC_CODE { get; set; }
        public string ViolationVIO_CODE { get; set; }
    
        public virtual Employee Employee { get; set; }
        public virtual Location Location { get; set; }
        public virtual Violation Violation { get; set; }
        public virtual ICollection<DRInvestigation> DRInvestigations { get; set; }
    }
}