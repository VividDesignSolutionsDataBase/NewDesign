using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace DRApplication.Models.Mapping
{
    public class DRTEMPMap : EntityTypeConfiguration<DRTEMP>
    {
        public DRTEMPMap()
        {
            // Primary Key
            this.HasKey(t => t.DR_TEMP_REPT_NUM);

            // Properties
            this.Property(t => t.DR_TEMP_REPT_NUM)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            // Table & Column Mappings
            this.ToTable("DRTEMP");
            this.Property(t => t.DR_TEMP_REPT_NUM).HasColumnName("DR_TEMP_REPT_NUM");
        }
    }
}
