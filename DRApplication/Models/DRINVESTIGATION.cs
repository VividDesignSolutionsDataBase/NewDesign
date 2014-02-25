namespace DRApplication
{
    using System;
    using System.Collections.Generic;

    public partial class DRINVESTIGATION
    {
        public int DRDR_REPORT_NUM { get; set; }
        public int DR_INVEST_EMP_ID { get; set; }
        public System.DateTime DR_DATE_OF_INVEST { get; set; }
        public System.TimeSpan DR_TIME_OF_INVEST { get; set; }
        public System.DateTime DR_DATE_INVEST_COMP { get; set; }
        public System.TimeSpan DR_TIME_INVEST_COMP { get; set; }
        public string DR_INVEST_STATEMENT { get; set; }
        public string DR_INVEST_COMP_FLAG { get; set; }
        public string DR_INVEST_VOID_FLAG { get; set; }
        public string DR_INVEST_APPROVE_FLAG { get; set; }
        public string DR_INVEST_REJECT_FLAG { get; set; }
        public string DR_INVEST_REJ_REASON { get; set; }
        public string DR_INVEST_SUP_VOID_FLAG { get; set; }
        public int DR_INVEST_SUP_APPROVE_EMP_ID { get; set; }

        public virtual DR DR { get; set; }
        public virtual DRHEARING DRHEARING { get; set; }
    }
}
