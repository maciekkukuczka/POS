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

        //Models
        protected Models.News Model;
        protected List<Models.News> Items;
        protected List<AppUser> AppUsers;
        protected List<GamesGroup> GamesGroups;

        //Services
        private NewsService _newsService;
        private AppUserService _appUserService;
        private GamesGroupService _gamesGroupService;


        protected async override Task OnInitializedAsync()
        {
            // return base.OnInitializedAsync();

            _newsService = (NewsService) ScopedServices.GetRequiredService(typeof(NewsService));
            _appUserService = (AppUserService) ScopedServices.GetRequiredService(typeof(AppUserService));
            _gamesGroupService = (GamesGroupService) ScopedServices.GetRequiredService(typeof(GamesGroupService));

            Items = await _newsService.GetAllActiveNews().ToListAsync();
            AppUsers = await _appUserService.GetAllActiveUsers().ToListAsync();
            GamesGroups = await _gamesGroupService.GetAllActiveGamesGroups().ToListAsync();


            // Model.AppUser = DataSeed.GetAppUsers().FirstOrDefault();
            // Items = DataSeed.GetNewses();
            // AppUsers = DataSeed.GetAppUsers();
        }

        protected void Add()
        {
            Model = new Models.News();

            // Model.AppUser = new AppUser();
            Model.GamesGroups = new List<GamesGroup>();

            _showAdd = true;
            _isButtonAddVisible = false;
        }

        protected void Edit(Models.News item)
        {
            _showAdd = true;
            _isButtonAddVisible = false;
            Model = item;
        }

        protected async Task ValidSubmit()
        {
            if (Model.Id == 0)
            {
                var id = await _newsService.AddAsync(Model);
                Items = await _newsService.GetAllActiveNews().ToListAsync();
                await Save();
            }
            else
            {
                var result = await _newsService.UpdateAsync(Model);
                await Save();
            }
        }

        private async Task Save()
        {
            Items = await _newsService.GetAllActiveNews().ToListAsync();
            _showAdd = false;
        }

        protected void Close()
        {
            _showAdd = false;
            _isButtonAddVisible = true;
        }

        protected void GamesGroupCheckboxOnChange(GamesGroup gamesGroup, ChangeEventArgs e)
        {
            if (!Model.GamesGroups.Contains(gamesGroup))
            {
                Model.GamesGroups.Add(gamesGroup);
            }
            else
            {
                Model.GamesGroups.Remove(gamesGroup);
            }
        }
    }

}