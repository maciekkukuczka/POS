using Microsoft.EntityFrameworkCore;
using POS.Data;
using POS.Models;
using POS.Repositories.Base;


namespace POS.Services
{

    public class ContactTypeService : BaseRepository<ContactType>
    {
        public ContactTypeService(AppDbContext db) : base(db)
        {
        }

        protected override DbSet<ContactType> DbSet => _db.ContactTypes;


        // public IQueryable<Contact> GetAllActiveContactTypes(int id)
        // {
        //     return DbSet.Where(x => x.IsActive && x.AppUserId == id)
        //         .AsQueryable();
        // }
    }

}