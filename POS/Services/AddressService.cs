using System.Linq;
using Microsoft.EntityFrameworkCore;
using POS.Data;
using POS.Models;
using POS.Repositories.Base;


namespace POS.Services
{

    public class AddressService : BaseRepository<Address>
    {
        public AddressService(AppDbContext db) : base(db)
        {
        }

        protected override DbSet<Address> DbSet => _db.Addresses;


        public IQueryable<Address> GetAllActiveAddresses()
        {
            return DbSet.Where(x => x.IsActive)
                .AsQueryable();
        }

        public IQueryable<Address> GetAllActiveAddressesByUser(string id)
        {
            return DbSet.Where(x => x.IsActive && x.AppUserId == int.Parse(id))
                .AsQueryable();
        }

        public IQueryable<Address> GetAddresses(bool isVisible = false, bool isActive = true)
        {
            return DbSet.Where(x => x.IsVisible == isVisible && x.IsActive == isActive)
                .AsQueryable();
        }
    }

}