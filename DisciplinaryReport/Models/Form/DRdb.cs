    using DisciplinaryReport.Database;
using System;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;

namespace DisciplinaryReport.Form
{
      public class DRdbContainer(): base("name=DRdbContainer")
     
      

        public virtual DbSet<DRHearing> DRHearings { get; set; }
        public virtual DbSet<DRInvestigation> DRInvestigations { get; set; }
        public virtual DbSet<DR> DRs { get; set; }
        public virtual DbSet<Location> Locations { get; set; }
        public virtual DbSet<Violation> Violations { get; set; }
        public virtual DbSet<Employee> Employees { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    }

}
    
