using System.Linq;
using Microsoft.EntityFrameworkCore;
using POS.Data;
using POS.Models;
using POS.Repositories.Base;


namespace POS.Services
{

    public class GalleryService : BaseRepository<Gallery>
    {
        public GalleryService(AppDbContext db) : base(db)
        {
        }

        protected override DbSet<Gallery> DbSet => _db.Galleries;


        public IQueryable<Gallery> GetAllActiveGalleries()
        {
            return DbSet.Where(x => x.IsActive)
                .Include(x => x.Images)
                .AsQueryable();
        }
    }

}