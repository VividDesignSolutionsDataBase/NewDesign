using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using DRApplication.Models.Mapping;

namespace DRApplication.Models
{
    public partial class JSOContext : DbContext
    {
        static JSOContext()
        {
            Database.SetInitializer<JSOContext>(null);
        }

        public JSOContext()
            : base("Name=JSOContext")
        {
        }

        public DbSet<DR> DRs { get; set; }
        public DbSet<DRHEARING> DRHEARINGs { get; set; }
        public DbSet<DRINVESTIGATION> DRINVESTIGATIONs { get; set; }
        public DbSet<DRTEMP> DRTEMPs { get; set; }
        public DbSet<EMPLOYEE> EMPLOYEEs { get; set; }
        public DbSet<HOUSINGLOCATION> HOUSINGLOCATIONs { get; set; }
        public DbSet<INCIDENTLOCATION> INCIDENTLOCATIONs { get; set; }
        public DbSet<LOCATION> LOCATIONs { get; set; }
        public DbSet<sysdiagram> sysdiagrams { get; set; }
        public DbSet<VIOLATION> VIOLATIONs { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new DRMap());
            modelBuilder.Configurations.Add(new DRHEARINGMap());
            modelBuilder.Configurations.Add(new DRINVESTIGATIONMap());
            modelBuilder.Configurations.Add(new DRTEMPMap());
            modelBuilder.Configurations.Add(new EMPLOYEEMap());
            modelBuilder.Configurations.Add(new HOUSINGLOCATIONMap());
            modelBuilder.Configurations.Add(new INCIDENTLOCATIONMap());
            modelBuilder.Configurations.Add(new LOCATIONMap());
            modelBuilder.Configurations.Add(new sysdiagramMap());
            modelBuilder.Configurations.Add(new VIOLATIONMap());
        }
    }
}
