﻿using System.Linq;
using Microsoft.EntityFrameworkCore;
using POS.Data;
using POS.Models;
using POS.Repositories.Base;


namespace POS.Services
{

    public class CMSPageService : BaseRepository<CMSPage>
    {
        public CMSPageService(AppDbContext db) : base(db)
        {
        }

        protected override DbSet<CMSPage> DbSet => _db.CmsPages;


        public IQueryable<CMSPage> GetAllActiveCmsPages()
        {
            return DbSet.Where(x => x.IsActive)
                .Include(x => x.AppUser)
                .AsQueryable();
        }

        // public IQueryable<Blood> GetBloods(bool isVisible = true, bool isActive = true)
        // {
        //     return DbSet.Where(x => x.IsVisible == isVisible && x.IsActive == isActive)
        //         .AsQueryable();
        // }
    }

}