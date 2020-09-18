using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using POS.Data;
using POS.Models;
using POS.Repositories.Base;


namespace POS.Services
{

    public class NewsService : BaseRepository<News>
    {
        public NewsService(AppDbContext db) : base(db)
        {
        }

        protected override DbSet<News> DbSet => _db.Newses;


        public IQueryable<News> GetAllActiveNews()
        {
            return DbSet.Where(x => x.IsActive)
                    .Include(x => x.AppUser)
                    .Include(x => x.GamesGroups)
                    .Include(x => x.Images)
                ;
        }

        public IQueryable<News> GetAllVisibleNews()
        {
            return DbSet.Where(x => x.IsActive && x.IsVisible)
                    .Include(x => x.AppUser)
                    .Include(x => x.GamesGroups)
                    .Include(x => x.Images)
                ;
        }

        public async Task<int> AddNewsAsync(News entity)
        {
            // var exist = _db.AppUsers.FirstOrDefault(x => x.Id == entity.AppUserID && x.IsActive);
            //
            // entity.AppUser = exist;
            await DbSet.AddAsync(entity);
            await SaveChangesAsync();

            return entity.Id;
        }
    }

}