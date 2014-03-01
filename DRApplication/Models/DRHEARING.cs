using System;
using System.ComponentModel.DataAnnotations;

namespace DRApplication.Models
{
    public partial class DRHEARING
    {
        [Key]
        public int DRInvestigationDRDR_REPORT_NUM { get; set; }
        public int DR_HEAR_CHIEF_ID { get; set; }
        public string DR_HEAR_INM_PLEA { get; set; }
        public string DR_HEAR_WIT_REQ { get; set; }
        public string DR_HEAR_NUM_DISC_REPORTS { get; set; }
        public System.DateTime DR_HEAR_DATE { get; set; }
        public string DR_HEAR_DECISION { get; set; }
        public string DR_HEAR_APPEAL { get; set; }
        public string DR_HEAR_DAYS_DISC_CONFINEMENT { get; set; }
        public string DR_HEAR_WKS_LOSS_COMMIS { get; set; }
        public string DR_HEAR_DAYS_LOSS_GAINTIME { get; set; }
        public string DR_HEAR_REVISED_TENTATIVE_REL_DATE { get; set; }
        public string DR_HEAR_COMMENT { get; set; }
        public string DR_HEAR_INM_INSTRULES_ACK { get; set; }
        public int DR_HEAR_COM_CHAIR_ID { get; set; }
        public string DR_HEAR_INM_WITNESS_JAIL_NUM { get; set; }
        public string DR_HEAR_CHIEF_AGREE_FLAG { get; set; }
        public string DR_HEAR_CHIEF_REDUCE_FLAG { get; set; }
        public string DR_HEAR_APPROVE_FLAG { get; set; }
        public string DR_HEAR_VOID_FLAG { get; set; }
        public string DR_HEAR_REDUCT_AMEND { get; set; }

        public virtual DRINVESTIGATION DRINVESTIGATION { get; set; }
    }
}
