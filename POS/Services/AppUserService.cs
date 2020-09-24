namespace POS.Services
{

    // public class AppUserService : BaseRepository<AppUser>
    // {
    //     public AppUserService(AppDbContext db) : base(db)
    //     {
    //     }
    //
    //     protected override DbSet<AppUser> DbSet => _db.AppUsers;
    //
    //
    //     public IQueryable<AppUser> GetAllActiveUsers()
    //     {
    //         return DbSet.Where(x => x.IsActive)
    //             .Include(x => x.Blood)
    //             .Include(x => x.Rank)
    //             .Include(x => x.Avatar)
    //             .Include(x => x.Addresses)
    //             .Include(x => x.GamesGroups)
    //             .Include(x => x.Contacts)
    //             .ThenInclude(x => x.ContactType)
    //             .AsQueryable();
    //     }
    //
    //     public IQueryable<AppUser> GetUsers(bool isVisible = false, bool isActive = true)
    //     {
    //         return DbSet.Where(x => x.IsVisible == isVisible && x.IsActive == isActive)
    //             .Include(x => x.Blood)
    //             .Include(x => x.Rank)
    //             .AsQueryable();
    //     }
    // }

}