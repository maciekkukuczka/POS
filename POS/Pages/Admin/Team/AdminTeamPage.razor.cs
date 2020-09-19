using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Forms;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using POS.Logic.Gallery;
using POS.Models;
using POS.Services;


namespace POS.Pages.Admin.Team
{

    public class AdminTeamPageBase : OwningComponentBase

    {
        protected bool _showAdd = false;
        protected bool _isButtonAddVisible = true;

        //Models
        protected Models.News Model;
        protected List<Models.News> Items;
        protected List<AppUser> AppUsers;
        protected List<GamesGroup> GamesGroups;
        protected List<Image> Images;

        // protected List<string> ImageUrls=new List<string>();

        //Services
        private NewsService _newsService;
        private AppUserService _appUserService;
        private GamesGroupService _gamesGroupService;
        private ImageService _imageService;


        protected async override Task OnInitializedAsync()
        {
            // return base.OnInitializedAsync();

            _newsService = (NewsService) ScopedServices.GetRequiredService(typeof(NewsService));
            _appUserService = (AppUserService) ScopedServices.GetRequiredService(typeof(AppUserService));
            _gamesGroupService = (GamesGroupService) ScopedServices.GetRequiredService(typeof(GamesGroupService));
            _imageService = (ImageService) ScopedServices.GetRequiredService(typeof(ImageService));

            Items = await _newsService.GetAllActiveNews().ToListAsync();
            AppUsers = await _appUserService.GetAllActiveUsers().ToListAsync();
            GamesGroups = await _gamesGroupService.GetAllActiveGamesGroups().ToListAsync();
            Images = await _imageService.GetAllActive().ToListAsync();
        }

        protected void Add()
        {
            Model = new Models.News();

            // Model.AppUser = new AppUser();
            Model.GamesGroups = new List<GamesGroup>();
            Model.Images = new List<Image>();

            _showAdd = true;
            _isButtonAddVisible = false;
        }

        protected void Edit(Models.News item)
        {
            _showAdd = true;
            _isButtonAddVisible = false;
            Model = item;
        }

        protected async Task Hide(Models.News item)
        {
            await _newsService.HideAsync(item.Id);
            await SaveAsync();
            StateHasChanged();
        }

        protected async Task ValidSubmit()
        {
            if (Model.Id == 0)
            {
                var result = await _newsService.AddAsync(Model);
                await SaveAsync();
            }
            else
            {
                var result = await _newsService.UpdateAsync(Model);
                await SaveAsync();
            }
        }

        private async Task SaveAsync()
        {
            Items = await _newsService.GetAllActiveNews().ToListAsync();
            _showAdd = false;
        }

        protected void Close()
        {
            _showAdd = false;
            _isButtonAddVisible = true;
        }

        protected void DeleteImage(Image image)
        {
            Model.Images.Remove(image);
        }

        protected async Task OnInputFileChange(InputFileChangeEventArgs e)
        {
            var imagesDataUrls = await ImageUploadProcessor.GetDataUrlsFromUploadedImagesAsync(e);

            imagesDataUrls.ForEach(x =>
            {
                Model.Images.Add(
                    new Image()
                    {
                        Path = x
                    }
                );
            });
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