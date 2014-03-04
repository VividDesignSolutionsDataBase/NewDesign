using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace DRApplication.Models.Mapping
{
    public class DRINVESTIGATIONMap : EntityTypeConfiguration<DRINVESTIGATION>
    {
        public DRINVESTIGATIONMap()
        {
            // Primary Key
            this.HasKey(t => t.DRDR_REPORT_NUM);

            // Properties
            this.Property(t => t.DRDR_REPORT_NUM)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.DR_INVEST_STATEMENT)
                .IsRequired();

            this.Property(t => t.DR_INVEST_COMP_FLAG)
                .HasMaxLength(5);

            this.Property(t => t.DR_INVEST_VOID_FLAG)
                .HasMaxLength(5);

            this.Property(t => t.DR_INVEST_APPROVE_FLAG)
                .HasMaxLength(5);

            this.Property(t => t.DR_INVEST_REJECT_FLAG)
                .HasMaxLength(5);

            this.Property(t => t.DR_INVEST_SUP_VOID_FLAG)
                .HasMaxLength(5);

            // Table & Column Mappings
            this.ToTable("DRINVESTIGATION");
            this.Property(t => t.DRDR_REPORT_NUM).HasColumnName("DRDR_REPORT_NUM");
            this.Property(t => t.DR_INVEST_EMP_ID).HasColumnName("DR_INVEST_EMP_ID");
            this.Property(t => t.DR_DATE_OF_INVEST).HasColumnName("DR_DATE_OF_INVEST");
            this.Property(t => t.DR_TIME_OF_INVEST).HasColumnName("DR_TIME_OF_INVEST");
            this.Property(t => t.DR_DATE_INVEST_COMP).HasColumnName("DR_DATE_INVEST_COMP");
            this.Property(t => t.DR_TIME_INVEST_COMP).HasColumnName("DR_TIME_INVEST_COMP");
            this.Property(t => t.DR_INVEST_STATEMENT).HasColumnName("DR_INVEST_STATEMENT");
            this.Property(t => t.DR_INVEST_COMP_FLAG).HasColumnName("DR_INVEST_COMP_FLAG");
            this.Property(t => t.DR_INVEST_VOID_FLAG).HasColumnName("DR_INVEST_VOID_FLAG");
            this.Property(t => t.DR_INVEST_APPROVE_FLAG).HasColumnName("DR_INVEST_APPROVE_FLAG");
            this.Property(t => t.DR_INVEST_REJECT_FLAG).HasColumnName("DR_INVEST_REJECT_FLAG");
            this.Property(t => t.DR_INVEST_REJ_REASON).HasColumnName("DR_INVEST_REJ_REASON");
            this.Property(t => t.DR_INVEST_SUP_VOID_FLAG).HasColumnName("DR_INVEST_SUP_VOID_FLAG");
            this.Property(t => t.DR_INVEST_SUP_APPROVE_EMP_ID).HasColumnName("DR_INVEST_SUP_APPROVE_EMP_ID");

            // Relationships
            this.HasRequired(t => t.DR)
                .WithOptional(t => t.DRINVESTIGATION);

        }
    }
}
