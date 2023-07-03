
using MyHomeProject.DataAccessLayer.Models;
using System.Numerics;
using static MyHomeProject.DataAccessLayer.Models.PatientsAntropometrics;

namespace MyHomeProject.DataAccessLayer.Data
{
    public class ApplicationContext : DbContext
    {
        private string connectionString;

        public DbSet<EstimatedGFR> EstimatedGFR { get; set; }
        public DbSet<PatientsAntropometrics> PatientsAntropometrics { get; set; }

        public ApplicationContext(DbContextOptions<ApplicationContext> options)
        : base(options)
        {
            Database.EnsureCreated();   
        }

        public ApplicationContext(string connectionString)
        {
            this.connectionString = connectionString;
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<PatientsAntropometrics>().HasData(
                  
                new PatientsAntropometrics { Id = 1, Height = 100, Age = 10, Gender = Gender.Male, BUN = 1, SCreatinine = 11, SCystatinC = 1 },
                    new PatientsAntropometrics { Id = 2, Height = 200, Age = 20, BUN = 2, SCreatinine = 22, SCystatinC = 2 }
            );
        }
    }
}
