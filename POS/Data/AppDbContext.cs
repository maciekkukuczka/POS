using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using POS.Models;
using POS.Models.Base;
using POSMVC.Domain.Models;


namespace POS.Data
{

    public class AppDbContext : IdentityDbContext
    {
        public DbSet<BaseEntity> BaseEntity { get; set; }
        public DbSet<AuditableEntity> AuditableEntity { get; set; }

        public DbSet<Address> Addresses { get; set; }
        public DbSet<AppUser> AppUsers { get; set; }
        public DbSet<BlogPost> BlogPosts { get; set; }
        public DbSet<Blood> Bloods { get; set; }
        public DbSet<CMSPage> CmsPages { get; set; }
        public DbSet<Contact> Contacts { get; set; }
        public DbSet<ContactType> ContactTypes { get; set; }
        public DbSet<GamesGroup> GamesGroups { get; set; }
        public DbSet<Image> Images { get; set; }
        public DbSet<Rank> Ranks { get; set; }

        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options)
        {
        }
    }

}