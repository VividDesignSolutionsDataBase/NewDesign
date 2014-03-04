using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace DRApplication.Models.Mapping
{
    public class EMPLOYEEMap : EntityTypeConfiguration<EMPLOYEE>
    {
        public EMPLOYEEMap()
        {
            // Primary Key
            this.HasKey(t => t.EMP_ID);

            // Properties
            this.Property(t => t.EMP_ID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.USERNAME)
                .IsRequired()
                .HasMaxLength(25);

            this.Property(t => t.PASSWORD)
                .IsRequired()
                .HasMaxLength(25);

            this.Property(t => t.EMP_LAST_NAME)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.EMP_FIRST_NAME)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.EMP_ROLE)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.EMP_LOCATION)
                .IsRequired()
                .HasMaxLength(35);

            this.Property(t => t.OLDPASSWORD)
                .HasMaxLength(25);

            this.Property(t => t.NEWPASSWORD)
                .HasMaxLength(25);

            this.Property(t => t.CONFIRMPASSWORD)
                .HasMaxLength(25);

            // Table & Column Mappings
            this.ToTable("EMPLOYEE");
            this.Property(t => t.EMP_ID).HasColumnName("EMP_ID");
            this.Property(t => t.USERNAME).HasColumnName("USERNAME");
            this.Property(t => t.PASSWORD).HasColumnName("PASSWORD");
            this.Property(t => t.EMP_LAST_NAME).HasColumnName("EMP_LAST_NAME");
            this.Property(t => t.EMP_FIRST_NAME).HasColumnName("EMP_FIRST_NAME");
            this.Property(t => t.EMP_ROLE).HasColumnName("EMP_ROLE");
            this.Property(t => t.EMP_LOCATION).HasColumnName("EMP_LOCATION");
            this.Property(t => t.OLDPASSWORD).HasColumnName("OLDPASSWORD");
            this.Property(t => t.NEWPASSWORD).HasColumnName("NEWPASSWORD");
            this.Property(t => t.CONFIRMPASSWORD).HasColumnName("CONFIRMPASSWORD");
        }
    }
}
