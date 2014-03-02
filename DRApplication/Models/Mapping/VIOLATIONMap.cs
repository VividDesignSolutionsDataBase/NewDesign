using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace DRApplication.Models.Mapping
{
    public class VIOLATIONMap : EntityTypeConfiguration<VIOLATION>
    {
        public VIOLATIONMap()
        {
            // Primary Key
            this.HasKey(t => t.VIO_CODE);

            // Properties
            this.Property(t => t.VIO_CODE)
                .IsRequired()
                .HasMaxLength(35);

            this.Property(t => t.VIO_SHORT_DESC)
                .HasMaxLength(75);

            this.Property(t => t.VIO_LONG_DESC)
                .HasMaxLength(155);

            this.Property(t => t.VIO_R_FLAG)
                .HasMaxLength(5);

            // Table & Column Mappings
            this.ToTable("VIOLATION");
            this.Property(t => t.VIO_CODE).HasColumnName("VIO_CODE");
            this.Property(t => t.VIO_SHORT_DESC).HasColumnName("VIO_SHORT_DESC");
            this.Property(t => t.VIO_LONG_DESC).HasColumnName("VIO_LONG_DESC");
            this.Property(t => t.VIO_R_FLAG).HasColumnName("VIO_R_FLAG");
        }
    }
}
