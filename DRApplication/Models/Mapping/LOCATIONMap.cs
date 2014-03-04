using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace DRApplication.Models.Mapping
{
    public class LOCATIONMap : EntityTypeConfiguration<LOCATION>
    {
        public LOCATIONMap()
        {
            // Primary Key
            this.HasKey(t => t.LOC_CODE);

            // Properties
            this.Property(t => t.LOC_CODE)
                .IsRequired()
                .HasMaxLength(35);

            this.Property(t => t.LOC_DESC)
                .HasMaxLength(155);

            // Table & Column Mappings
            this.ToTable("LOCATION");
            this.Property(t => t.LOC_CODE).HasColumnName("LOC_CODE");
            this.Property(t => t.LOC_DESC).HasColumnName("LOC_DESC");
        }
    }
}
