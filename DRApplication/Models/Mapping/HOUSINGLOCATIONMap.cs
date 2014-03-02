using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace DRApplication.Models.Mapping
{
    public class HOUSINGLOCATIONMap : EntityTypeConfiguration<HOUSINGLOCATION>
    {
        public HOUSINGLOCATIONMap()
        {
            // Primary Key
            this.HasKey(t => t.HOUSE_LOC_CODE);

            // Properties
            this.Property(t => t.HOUSE_LOC_CODE)
                .IsRequired()
                .HasMaxLength(35);

            this.Property(t => t.HOUSE_LOC_DESC)
                .HasMaxLength(155);

            // Table & Column Mappings
            this.ToTable("HOUSINGLOCATION");
            this.Property(t => t.HOUSE_LOC_CODE).HasColumnName("HOUSE_LOC_CODE");
            this.Property(t => t.HOUSE_LOC_DESC).HasColumnName("HOUSE_LOC_DESC");
        }
    }
}
