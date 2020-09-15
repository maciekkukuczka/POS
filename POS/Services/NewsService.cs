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
    }

}