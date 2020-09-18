using Microsoft.EntityFrameworkCore;
using POS.Data;
using POS.Models;
using POS.Repositories.Base;


namespace POS.Services
{

    public class ImageService : BaseRepository<Image>
    {
        public ImageService(AppDbContext db) : base(db)
        {
        }

        protected override DbSet<Image> DbSet => _db.Images;

        // public async Task<List<Image>> GetAllVisibleImagesAsync()
        // {
        //     return await DbSet.Where(x=>x.)
        // }
    }

}