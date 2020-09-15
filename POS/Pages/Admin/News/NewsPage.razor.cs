using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Components;
using Microsoft.Extensions.DependencyInjection;
using POS.Data;
using POS.Models;
using POS.Services;


namespace POS.Pages.Admin.News
{

    public class NewsPageBase : OwningComponentBase
    {
        protected bool _showAdd = false;

        protected Models.News Model;
        protected List<Models.News> Items;
        protected List<AppUser> AppUsers;

        private NewsService _newsService;
        private AppUserService _appUserService;

        protected int testID;

        protected async override Task OnInitializedAsync()
        {
            // return base.OnInitializedAsync();

            _newsService = (NewsService) ScopedServices.GetRequiredService(typeof(NewsService));
            _appUserService = (AppUserService) ScopedServices.GetRequiredService(typeof(AppUserService));

            // Items = await _newsService.GetAllActive().ToListAsync();
            Items = DataSeed.GetNewses();

            //  Model = Items.FirstOrDefault();
            // Model.AppUser = DataSeed.GetAppUsers().FirstOrDefault();
            // AppUsers = await _appUserService.GetAllActive().ToListAsync();
            AppUsers = DataSeed.GetAppUsers();
        }

        protected void Add()
        {
            Model = new Models.News();
            Model.AppUser = new AppUser();

            // Model.AppUser = DataSeed.GetAppUsers().FirstOrDefault();
            _showAdd = true;
        }

        protected async Task ValidSubmit()
        {
            var id = await _newsService.AddAsync(Model);
            _showAdd = false;
        }
    }

}