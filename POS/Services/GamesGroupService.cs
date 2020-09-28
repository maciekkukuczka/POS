using System.Linq;
using Microsoft.EntityFrameworkCore;
using POS.Data;
using POS.Models;
using POS.Repositories.Base;


namespace POS.Services
{

    public class GamesGroupService : BaseRepository<GamesGroup>
    {
        public GamesGroupService(AppDbContext db) : base(db)
        {
        }

        protected override DbSet<GamesGroup> DbSet => _db.GamesGroups;


        public IQueryable<GamesGroup> GetAllActiveGamesGroups()
        {
            return DbSet.Where(x => x.IsActive)
                .Include(x => x.AppUsers);
        }
    }

}