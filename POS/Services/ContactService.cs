using System.Linq;
using Microsoft.EntityFrameworkCore;
using POS.Data;
using POS.Models;
using POS.Repositories.Base;


namespace POS.Services
{

    public class ContactService : BaseRepository<Contact>
    {
        public ContactService(AppDbContext db) : base(db)
        {
        }

        protected override DbSet<Contact> DbSet => _db.Contacts;


        public IQueryable<Contact> GetAllActiveContactsByUser(string id)
        {
            return DbSet.Where(x => x.IsActive && x.AppUserId == id)
                .Include(x => x.ContactType)
                .AsQueryable();
        }
    }

}