using MyHomeProject.DataAccessLayer.Data;
using MyHomeProject.DataAccessLayer.Models;

namespace MyHomeProject.DataAccessLayer.Repositories
{
    public class EFUnitOfWork : IUnitOfWork
    {
        private ApplicationContext db;
        private EstimatedGFRRepository estimatedGFRRepository;
        private PatientsAntropometricsRepository patientsAntropometricsRepository;

        public EFUnitOfWork(string connectionString)
        {
            db = new ApplicationContext(connectionString);
        }

        public IRepository<EstimatedGFR> EstimatedGFR
        {
            get
            {
                if (estimatedGFRRepository == null)
                    estimatedGFRRepository = new EstimatedGFRRepository(db);
                return estimatedGFRRepository;
            }
        }

        public IRepository<PatientsAntropometrics> PatientsAntropometrics
        {
            get
            {
                if (patientsAntropometricsRepository == null)
                    patientsAntropometricsRepository = new PatientsAntropometricsRepository(db);
                return patientsAntropometricsRepository;
            }
        }

        public void Save()
        {
            db.SaveChanges();
        }

        private bool disposed = false;

        public virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    db.Dispose();
                }
                this.disposed = true;
            }
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }

}
