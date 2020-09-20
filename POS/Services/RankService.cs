using System.Linq;
using Microsoft.EntityFrameworkCore;
using POS.Data;
using POS.Models;
using POS.Repositories.Base;


namespace POS.Services
{

    public class RankService : BaseRepository<Rank>
    {
        public RankService(AppDbContext db) : base(db)
        {
        }

        protected override DbSet<Rank> DbSet => _db.Ranks;


        public IQueryable<Rank> GetRanks(bool isVisible = true, bool isActive = true)
        {
            return DbSet.Where(x => x.IsVisible == isVisible && x.IsActive == isActive)
                .AsQueryable();
        }
    }

}