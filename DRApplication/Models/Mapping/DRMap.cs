using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace DRApplication.Models.Mapping
{
    public class DRMap : EntityTypeConfiguration<DR>
    {
        public DRMap()
        {
            // Primary Key
            this.HasKey(t => t.DR_REPORT_NUM);

            // Properties
            this.Property(t => t.DR_REPORT_NUM)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.DR_INM_VIOLATION_CODE)
                .IsRequired()
                .HasMaxLength(35);

            this.Property(t => t.DR_INM_JAIL_NUM)
                .IsRequired()
                .HasMaxLength(25);

            this.Property(t => t.DR_INM_LAST_NAME)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.DR_INM_FIRST_NAME)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.DR_INM_RACE)
                .IsRequired()
                .HasMaxLength(5);

            this.Property(t => t.DR_INM_SEX)
                .IsRequired()
                .HasMaxLength(3);

            this.Property(t => t.DR_INM_AGE)
                .IsRequired()
                .HasMaxLength(3);

            this.Property(t => t.DR_OFFICER_FACILITY)
                .IsRequired()
                .HasMaxLength(35);

            this.Property(t => t.DR_HOUSE_LOC)
                .IsRequired()
                .HasMaxLength(35);

            this.Property(t => t.DR_CMIS_CONT_LOG)
                .HasMaxLength(5);

            this.Property(t => t.DR_INCIDENT_LOCATION)
                .IsRequired()
                .HasMaxLength(35);

            this.Property(t => t.DR_STATE_FACTS)
                .IsRequired();

            this.Property(t => t.DR_INITSUB_COMP_FLAG)
                .HasMaxLength(5);

            this.Property(t => t.DR_FIRST_APPROVAL_FLAG)
                .HasMaxLength(5);

            this.Property(t => t.DR_FIRST_REJECT_FLAG)
                .HasMaxLength(5);

            this.Property(t => t.ViolationVIO_CODE)
                .IsRequired()
                .HasMaxLength(35);

            // Table & Column Mappings
            this.ToTable("DR");
            this.Property(t => t.DR_REPORT_NUM).HasColumnName("DR_REPORT_NUM");
            this.Property(t => t.DR_FIRST_APPROVAL_EMP_ID).HasColumnName("DR_FIRST_APPROVAL_EMP_ID");
            this.Property(t => t.DR_INM_VIOLATION_CODE).HasColumnName("DR_INM_VIOLATION_CODE");
            this.Property(t => t.DR_INM_JAIL_NUM).HasColumnName("DR_INM_JAIL_NUM");
            this.Property(t => t.DR_INM_LAST_NAME).HasColumnName("DR_INM_LAST_NAME");
            this.Property(t => t.DR_INM_FIRST_NAME).HasColumnName("DR_INM_FIRST_NAME");
            this.Property(t => t.DR_INM_RACE).HasColumnName("DR_INM_RACE");
            this.Property(t => t.DR_INM_SEX).HasColumnName("DR_INM_SEX");
            this.Property(t => t.DR_INM_AGE).HasColumnName("DR_INM_AGE");
            this.Property(t => t.DR_OFFICER_FACILITY).HasColumnName("DR_OFFICER_FACILITY");
            this.Property(t => t.DR_HOUSE_LOC).HasColumnName("DR_HOUSE_LOC");
            this.Property(t => t.DR_CMIS_CONT_LOG).HasColumnName("DR_CMIS_CONT_LOG");
            this.Property(t => t.DR_INCIDENT_DATE).HasColumnName("DR_INCIDENT_DATE");
            this.Property(t => t.DR_INCIDENT_TIME).HasColumnName("DR_INCIDENT_TIME");
            this.Property(t => t.DR_INCIDENT_LOCATION).HasColumnName("DR_INCIDENT_LOCATION");
            this.Property(t => t.DR_STATE_FACTS).HasColumnName("DR_STATE_FACTS");
            this.Property(t => t.DR_DATE_INIT_SUBMISSION_COMP).HasColumnName("DR_DATE_INIT_SUBMISSION_COMP");
            this.Property(t => t.DR_INITSUB_COMP_FLAG).HasColumnName("DR_INITSUB_COMP_FLAG");
            this.Property(t => t.DR_FIRST_APPROVAL_FLAG).HasColumnName("DR_FIRST_APPROVAL_FLAG");
            this.Property(t => t.DR_FIRST_REJECT_REASON).HasColumnName("DR_FIRST_REJECT_REASON");
            this.Property(t => t.DR_FIRST_REJECT_FLAG).HasColumnName("DR_FIRST_REJECT_FLAG");
            this.Property(t => t.DR_TIME_INIT_SUBMISSION_COMP).HasColumnName("DR_TIME_INIT_SUBMISSION_COMP");
            this.Property(t => t.EmployeeEMP_ID).HasColumnName("EmployeeEMP_ID");
            this.Property(t => t.ViolationVIO_CODE).HasColumnName("ViolationVIO_CODE");

            // Relationships
            this.HasRequired(t => t.EMPLOYEE)
                .WithMany(t => t.DRs)
                .HasForeignKey(d => d.EmployeeEMP_ID);
            this.HasRequired(t => t.VIOLATION)
                .WithMany(t => t.DRs)
                .HasForeignKey(d => d.ViolationVIO_CODE);

        }
    }
}
