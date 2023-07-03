using MyHomeProject.DataAccessLayer.Data;
using MyHomeProject.DataAccessLayer.Models;


namespace MyHomeProject.DataAccessLayer.Repositories
{
    public class PatientsAntropometricsRepository : IRepository<PatientsAntropometrics>
    {
        private ApplicationContext db;

        public PatientsAntropometricsRepository(ApplicationContext context)
        {
            this.db = context;
        }

        public async Task<IEnumerable<PatientsAntropometrics>> GetAllAsync()
        {
            return await db.PatientsAntropometrics.ToListAsync();
        }

        public async Task<PatientsAntropometrics> GetAsync(int id)
        {
            return await db.PatientsAntropometrics.FindAsync(id);
        }

        public async Task<IEnumerable<PatientsAntropometrics>> FindAsync(Expression<Func<PatientsAntropometrics, bool>> predicate)
        {
            return await db.PatientsAntropometrics.Where(predicate).ToListAsync();
        }

        public async Task CreateAsync(PatientsAntropometrics PatientsAntropometrics)
        {
            await db.PatientsAntropometrics.AddAsync(PatientsAntropometrics);
        }

        public async Task UpdateAsync(PatientsAntropometrics PatientsAntropometrics)
        {
            db.Entry(PatientsAntropometrics).State = EntityState.Modified;
        }

        public async Task DeleteAsync(int id)
        {
            PatientsAntropometrics PatientsAntropometrics = await db.PatientsAntropometrics.FindAsync(id);
            if (PatientsAntropometrics != null)
                db.PatientsAntropometrics.Remove(PatientsAntropometrics);
        }
    }
}
