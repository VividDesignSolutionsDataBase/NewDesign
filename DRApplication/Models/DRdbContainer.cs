namespace DRApplication
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;

    public partial class DRdbContainer : DbContext
    {
        public DRdbContainer()
            : base("name=DRdbContainer")
        {
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }

        public DbSet<DR> DR { get; set; }
        public DbSet<DRHEARING> DRHEARING { get; set; }
        public DbSet<DRINVESTIGATION> DRINVESTIGATION { get; set; }
        public DbSet<EMPLOYEE>EMPLOYEE { get; set; }
        public DbSet<HOUSINGLOCATION>HOUSINGLOCATIONs { get; set; }
        public DbSet<INCIDENTLOCATION>INCIDENTLOCATIONs { get; set; }
        public DbSet<LOCATION> LOCATION { get; set; }
        public DbSet<VIOLATION>VIOLATION { get; set; }
    }
}
