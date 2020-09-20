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

        public IQueryable<Gallery> GetVisibleGalleries()
        {
            return DbSet.Where(x => x.IsActive && x.IsVisible)
                .Include(x => x.Images)
                .AsQueryable();
        }

        public IQueryable<Gallery> GetGalleries(bool isVisible = true, bool isActive = true)
        {
            return DbSet.Where(x => x.IsVisible == isVisible && x.IsActive == isActive)
                .Include(x => x.Images)
                .AsQueryable();
        }
    }

}