using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using POS.Data;
using POS.Models.Base;
using POS.Repositories.Interfaces.Base;


namespace POS.Repositories.Base
{

    // public abstract class BaseRepository<T> where T : BaseEntity, IBaseRepository<T>
    public abstract class BaseRepository<T> : IBaseRepository<T> where T : BaseEntity
    {
        protected readonly AppDbContext _db;
        protected abstract DbSet<T> DbSet { get; }


        public BaseRepository(AppDbContext db)
        {
            _db = db;
        }


        public IQueryable<T> GetAllActive()
        {
            return DbSet.Where(x => x.IsActive).AsQueryable();
        }


        public async Task<T> GetActiveById(int id)
        {
            // return await DbSet.FirstOrDefaultAsync(x => x.Id == id && x.IsActive);
            return await _db.Set<T>().FirstOrDefaultAsync(x => x.Id == id && x.IsActive);
        }


        public async Task<int> AddAsync(T entity)
        {
            await DbSet.AddAsync(entity);
            await SaveChangesAsync();

            return entity.Id;
        }


        public async Task<int> UpdateAsync(T entity)
        {
            var exist = await DbSet.FirstOrDefaultAsync(x => x.Id == entity.Id && x.IsActive);

            if (exist == null)
            {
                await DbSet.AddAsync(entity);
                await SaveChangesAsync();

                return entity.Id;
            }

            exist = entity;

            // DbSet.Update(exist);  
            await SaveChangesAsync();

            return exist.Id;
        }


        public async Task DeleteAsync(int entityId)
        {
            var exist = await DbSet.FirstOrDefaultAsync(x => x.Id == entityId);

            if (exist != null)
            {
                DbSet.Remove(exist);
            }

            await SaveChangesAsync();
        }


        public async Task HideAsync(int entityId)
        {
            var exist = DbSet.FirstOrDefault(x => x.Id == entityId);

            if (exist != null)
            {
                exist.IsActive = false;
            }

            await SaveChangesAsync();
        }

        public async Task ActivateAsync(int entityId)
        {
            var exist = DbSet.FirstOrDefault(x => x.Id == entityId);

            if (exist != null)
            {
                exist.IsActive = true;
            }

            await SaveChangesAsync();
        }

        public async Task SaveChangesAsync()
        {
            await _db.SaveChangesAsync();
        }
    }

}