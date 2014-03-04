using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace DRApplication.Models.Mapping
{
    public class DRHEARINGMap : EntityTypeConfiguration<DRHEARING>
    {
        public DRHEARINGMap()
        {
            // Primary Key
            this.HasKey(t => t.DRInvestigationDRDR_REPORT_NUM);

            // Properties
            this.Property(t => t.DRInvestigationDRDR_REPORT_NUM)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.DR_HEAR_INM_PLEA)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.DR_HEAR_WIT_REQ)
                .HasMaxLength(25);

            this.Property(t => t.DR_HEAR_NUM_DISC_REPORTS)
                .HasMaxLength(10);

            this.Property(t => t.DR_HEAR_DECISION)
                .IsRequired()
                .HasMaxLength(75);

            this.Property(t => t.DR_HEAR_APPEAL)
                .HasMaxLength(75);

            this.Property(t => t.DR_HEAR_DAYS_DISC_CONFINEMENT)
                .HasMaxLength(75);

            this.Property(t => t.DR_HEAR_WKS_LOSS_COMMIS)
                .HasMaxLength(75);

            this.Property(t => t.DR_HEAR_DAYS_LOSS_GAINTIME)
                .HasMaxLength(75);

            this.Property(t => t.DR_HEAR_REVISED_TENTATIVE_REL_DATE)
                .HasMaxLength(75);

            this.Property(t => t.DR_HEAR_INM_INSTRULES_ACK)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.DR_HEAR_INM_WITNESS_JAIL_NUM)
                .HasMaxLength(25);

            this.Property(t => t.DR_HEAR_CHIEF_AGREE_FLAG)
                .HasMaxLength(5);

            this.Property(t => t.DR_HEAR_CHIEF_REDUCE_FLAG)
                .HasMaxLength(5);

            this.Property(t => t.DR_HEAR_APPROVE_FLAG)
                .HasMaxLength(5);

            this.Property(t => t.DR_HEAR_VOID_FLAG)
                .HasMaxLength(5);

            // Table & Column Mappings
            this.ToTable("DRHEARING");
            this.Property(t => t.DRInvestigationDRDR_REPORT_NUM).HasColumnName("DRInvestigationDRDR_REPORT_NUM");
            this.Property(t => t.DR_HEAR_CHIEF_ID).HasColumnName("DR_HEAR_CHIEF_ID");
            this.Property(t => t.DR_HEAR_INM_PLEA).HasColumnName("DR_HEAR_INM_PLEA");
            this.Property(t => t.DR_HEAR_WIT_REQ).HasColumnName("DR_HEAR_WIT_REQ");
            this.Property(t => t.DR_HEAR_NUM_DISC_REPORTS).HasColumnName("DR_HEAR_NUM_DISC_REPORTS");
            this.Property(t => t.DR_HEAR_DATE).HasColumnName("DR_HEAR_DATE");
            this.Property(t => t.DR_HEAR_DECISION).HasColumnName("DR_HEAR_DECISION");
            this.Property(t => t.DR_HEAR_APPEAL).HasColumnName("DR_HEAR_APPEAL");
            this.Property(t => t.DR_HEAR_DAYS_DISC_CONFINEMENT).HasColumnName("DR_HEAR_DAYS_DISC_CONFINEMENT");
            this.Property(t => t.DR_HEAR_WKS_LOSS_COMMIS).HasColumnName("DR_HEAR_WKS_LOSS_COMMIS");
            this.Property(t => t.DR_HEAR_DAYS_LOSS_GAINTIME).HasColumnName("DR_HEAR_DAYS_LOSS_GAINTIME");
            this.Property(t => t.DR_HEAR_REVISED_TENTATIVE_REL_DATE).HasColumnName("DR_HEAR_REVISED_TENTATIVE_REL_DATE");
            this.Property(t => t.DR_HEAR_COMMENT).HasColumnName("DR_HEAR_COMMENT");
            this.Property(t => t.DR_HEAR_INM_INSTRULES_ACK).HasColumnName("DR_HEAR_INM_INSTRULES_ACK");
            this.Property(t => t.DR_HEAR_COM_CHAIR_ID).HasColumnName("DR_HEAR_COM_CHAIR_ID");
            this.Property(t => t.DR_HEAR_INM_WITNESS_JAIL_NUM).HasColumnName("DR_HEAR_INM_WITNESS_JAIL_NUM");
            this.Property(t => t.DR_HEAR_CHIEF_AGREE_FLAG).HasColumnName("DR_HEAR_CHIEF_AGREE_FLAG");
            this.Property(t => t.DR_HEAR_CHIEF_REDUCE_FLAG).HasColumnName("DR_HEAR_CHIEF_REDUCE_FLAG");
            this.Property(t => t.DR_HEAR_APPROVE_FLAG).HasColumnName("DR_HEAR_APPROVE_FLAG");
            this.Property(t => t.DR_HEAR_VOID_FLAG).HasColumnName("DR_HEAR_VOID_FLAG");
            this.Property(t => t.DR_HEAR_REDUCT_AMEND).HasColumnName("DR_HEAR_REDUCT_AMEND");

            // Relationships
            this.HasRequired(t => t.DRINVESTIGATION)
                .WithOptional(t => t.DRHEARING);

        }
    }
}
