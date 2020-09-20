using System.Linq;
using Microsoft.EntityFrameworkCore;
using POS.Data;
using POS.Models;
using POS.Repositories.Base;


namespace POS.Services
{

    public class BloodService : BaseRepository<Blood>
    {
        public BloodService(AppDbContext db) : base(db)
        {
        }

        protected override DbSet<Blood> DbSet => _db.Bloods;


        public IQueryable<Blood> GetBloods(bool isVisible = true, bool isActive = true)
        {
            return DbSet.Where(x => x.IsVisible == isVisible && x.IsActive == isActive)
                .AsQueryable();
        }
    }

}