using MyHomeProject.DataAccessLayer.Data;
using MyHomeProject.DataAccessLayer.Models;


namespace MyHomeProject.DataAccessLayer.Repositories
{
    public class EstimatedGFRRepository : IRepository<EstimatedGFR>
    {
        private ApplicationContext db;

        public EstimatedGFRRepository(ApplicationContext context)
        {
            this.db = context;
        }

        public async Task<IEnumerable<EstimatedGFR>> GetAllAsync()
        {
            return await db.EstimatedGFR.ToListAsync();
        }

        public async Task<EstimatedGFR> GetAsync(int id)
        {
            return await db.EstimatedGFR.FindAsync(id);
        }

        public async Task<IEnumerable<EstimatedGFR>> FindAsync(Expression<Func<EstimatedGFR, bool>> predicate)
        {
            return await db.EstimatedGFR.Where(predicate).ToListAsync();
        }

        public async Task CreateAsync(EstimatedGFR estimatedGFR)
        {
            await db.EstimatedGFR.AddAsync(estimatedGFR);
        }

        public async Task UpdateAsync(EstimatedGFR estimatedGFR)
        {
            db.Entry(estimatedGFR).State = EntityState.Modified;
        }

        public async Task DeleteAsync(int id)
        {
            EstimatedGFR estimatedGFR = await db.EstimatedGFR.FindAsync(id);
            if (estimatedGFR != null)
                db.EstimatedGFR.Remove(estimatedGFR);
        }
    }
}







