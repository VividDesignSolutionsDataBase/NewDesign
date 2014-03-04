using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace DRApplication.Models.Mapping
{
    public class INCIDENTLOCATIONMap : EntityTypeConfiguration<INCIDENTLOCATION>
    {
        public INCIDENTLOCATIONMap()
        {
            // Primary Key
            this.HasKey(t => t.INC_LOC_CODE);

            // Properties
            this.Property(t => t.INC_LOC_CODE)
                .IsRequired()
                .HasMaxLength(35);

            this.Property(t => t.INC_LOC_DESC)
                .HasMaxLength(155);

            // Table & Column Mappings
            this.ToTable("INCIDENTLOCATION");
            this.Property(t => t.INC_LOC_CODE).HasColumnName("INC_LOC_CODE");
            this.Property(t => t.INC_LOC_DESC).HasColumnName("INC_LOC_DESC");
        }
    }
}
