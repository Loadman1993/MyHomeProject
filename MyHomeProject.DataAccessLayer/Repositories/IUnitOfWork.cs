

using MyHomeProject.DataAccessLayer.Models;


namespace MyHomeProject.DataAccessLayer.Repositories
{
    public interface IUnitOfWork : IDisposable
    {
        IRepository<EstimatedGFR> EstimatedGFR { get; }
        IRepository<PatientsAntropometrics> PatientsAntropometrics { get; }
        void Save();
    }

}
