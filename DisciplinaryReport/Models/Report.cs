using System.ComponentModel.DataAnnotations;


namespace DisciplinaryReport.Models
{
    public enum Status
    {
        A, B, C
    }

    public class Report
    {
        [Key]
        public int DR_REPORT_NUM { get; set; }
        public string EMP_ID { get; set; }
        public int DR_INM_LAST_NAME { get; set; }
        public int DR_INM_FIRST_NAME { get; set; }
        public Status? Status { get; set; }

        //public virtual FormModel Form { get; set; }
        //public virtual EmployeeModel Employee { get; set; }
       
        


    }
}