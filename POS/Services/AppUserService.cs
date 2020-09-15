using Microsoft.EntityFrameworkCore;
using POS.Data;
using POS.Models;
using POS.Repositories.Base;


namespace POS.Services
{

    public class AppUserService : BaseRepository<AppUser>
    {
        public AppUserService(AppDbContext db) : base(db)
        {
        }

        protected override DbSet<AppUser> DbSet => _db.AppUsers;
    }

}