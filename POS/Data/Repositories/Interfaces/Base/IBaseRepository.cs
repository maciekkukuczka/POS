using System.Linq;
using System.Threading.Tasks;
using POS.Models.Base;


namespace POS.Repositories.Interfaces.Base
{

    public interface IBaseRepository<T> where T : BaseEntity
    {
        public IQueryable<T> GetAllActive();

        public Task<T> GetActiveById(int id);

        public Task<int> AddAsync(T entity);

        public Task<int> UpdateAsync(T entity);

        public Task DeleteAsync(int entityId);

        public Task HideAsync(int entityId);

        public Task ActivateAsync(int entityId);

        public Task SaveChangesAsync();
    }

}