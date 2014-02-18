using DisciplinaryReport.Models;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace DisciplinaryReport.Form
{
    public class DRdb : DbContext
    {

        public DbSet<FormModel> Forms { get; set; }
        public DbSet<DRHearingModel> DRHearings { get; set; }
        public DbSet<DRInvestigationModel> DRInvestigations { get; set; }
        public DbSet<LocationModel> Locations { get; set; }
        public DbSet<ViolationModel> Violations { get; set; }
        public DbSet<EmployeeModel> Employees { get; set; }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}