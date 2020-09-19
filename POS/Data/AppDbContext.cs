using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using POS.Models;


namespace POS.Data
{

    public class AppDbContext : IdentityDbContext
    {
        // public DbSet<BaseEntity> BaseEntity { get; set; }
        // public DbSet<AuditableEntity> AuditableEntity { get; set; }

        public DbSet<Address> Addresses { get; set; }
        public DbSet<AppUser> AppUsers { get; set; }
        public DbSet<News> Newses { get; set; }
        public DbSet<Blood> Bloods { get; set; }
        public DbSet<CMSPage> CmsPages { get; set; }
        public DbSet<Contact> Contacts { get; set; }
        public DbSet<ContactType> ContactTypes { get; set; }
        public DbSet<GamesGroup> GamesGroups { get; set; }
        public DbSet<Image> Images { get; set; }
        public DbSet<Rank> Ranks { get; set; }
        public DbSet<Gallery> Galleries { get; set; }

        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options)
        {
        }


        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            // builder.Entity<Image>()
            //     . (c => c.News)
            //     .WithMany()
            //     .WillCascadeOnDelete(false);

            // builder.Entity<Image>()
            //     .HasOne(x => x.AppUser)
            //     .WithOne(x => x.Avatar)
            //     .OnDelete(DeleteBehavior.Restrict);
        }
    }

}