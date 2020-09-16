using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Components;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using POS.Models;
using POS.Services;


namespace POS.Pages.Admin.News
{

    public class NewsPageBase : OwningComponentBase
    {
        protected bool _showAdd = false;
        protected bool _isButtonAddVisible = true;

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

            Items = await _newsService.GetAllActiveNews().ToListAsync();

            // Items = DataSeed.GetNewses();

            //  Model = Items.FirstOrDefault();
            // Model.AppUser = DataSeed.GetAppUsers().FirstOrDefault();
            AppUsers = await _appUserService.GetAllActiveUsers().ToListAsync();

            // AppUsers = DataSeed.GetAppUsers();
        }

        protected void Add()
        {
            Model = new Models.News();
            Model.AppUser = new AppUser();

            _showAdd = true;
            _isButtonAddVisible = false;
        }

        protected async Task ValidSubmit()
        {
            // Model.AppUser = DataSeed.GetAppUsers().FirstOrDefault();
            // Model.AppUser.Blood=new Blood(){ Name = "duupa"};
            var id = await _newsService.AddNewsAsync(Model);

            _showAdd = false;
        }

        protected void Close()
        {
            _showAdd = false;
            _isButtonAddVisible = true;
        }
    }

}