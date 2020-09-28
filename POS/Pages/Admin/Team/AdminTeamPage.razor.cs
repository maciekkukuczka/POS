using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Forms;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.VisualStudio.Web.CodeGeneration;
using POS.Logic.Gallery;
using POS.Models;
using POS.Services;


namespace POS.Pages.Admin.Team
{

    public class AdminTeamPageBase : OwningComponentBase

    {
        [Inject] private UserManager<AppUser> _userManager { get; set; }

        protected bool _showAdd = false;
        protected bool _isButtonAddVisible = true;
        protected bool IsNew = false;

        //Logger
        public bool IsVisible = false;
        public bool IsSucceded = false;
        protected List<string> LogMessages;

        //Models
        protected AppUser Model;
        protected List<AppUser> Items;
        protected List<Models.Blood> Bloods;
        protected List<Models.Rank> Ranks;
        protected List<Models.GamesGroup> GamesGroups;


        // protected List<string> ImageUrls=new List<string>();

        //Services
        // private AppUserService _appUserService;
        private BloodService _bloodService;
        private RankService _rankService;
        private GamesGroupService _gamesGroupService;


        protected async override Task OnInitializedAsync()
        {
            // return base.OnInitializedAsync();

            // _appUserService = (AppUserService) ScopedServices.GetRequiredService(typeof(AppUserService));
            _bloodService = (BloodService) ScopedServices.GetRequiredService(typeof(BloodService));
            _rankService = (RankService) ScopedServices.GetRequiredService(typeof(RankService));
            _gamesGroupService = (GamesGroupService) ScopedServices.GetRequiredService(typeof(GamesGroupService));

            // Items = await _appUserService.GetAllActiveUsers().ToListAsync();
            Items = await GetAll();

            Bloods = await _bloodService.GetAllActive().ToListAsync();
            Ranks = await _rankService.GetAllActive().ToListAsync();
            GamesGroups = await _gamesGroupService.GetAllActiveGamesGroups().ToListAsync();
        }

        protected async Task<List<AppUser>> GetAll()
        {
            Items = await _userManager.Users.Where(x => x.IsActive)
                .Include(x => x.Blood)
                .Include(x => x.Rank)
                .Include(x => x.Avatar)
                .Include(x => x.Addresses)
                .Include(x => x.GamesGroups)
                .Include(x => x.Contacts)
                .ThenInclude(x => x.ContactType)
                .ToListAsync();

            return Items;
        }

        protected void Add()
        {
            IsNew = true;
            Model = new AppUser();

            // Model.Avatar = new Image();

            // Model.Blood = new Blood();
            // Model.Rank = new Models.Rank();
            Model.GamesGroups = new List<Models.GamesGroup>();
            Model.Addresses = new List<Models.Address>();

            // Model.Id = Model.Id.ToString();

            _showAdd = true;
            _isButtonAddVisible = false;
        }

        protected async Task Edit(AppUser item)
        {
            _showAdd = true;
            _isButtonAddVisible = false;
            Model = item;
        }

        protected async Task Hide(AppUser item)
        {
            // await _appUserService.HideAsync(item.Id);
            item.IsActive = false;
            var user = await _userManager.UpdateAsync(item);
            await SaveAsync();
            StateHasChanged();
        }

        protected async Task ValidSubmit()
        {
            IdentityResult result;

            if (IsNew)
            {
                if (string.IsNullOrWhiteSpace(Model.UserName))
                {
                    Model.UserName = Model.Email;
                }

                // var result = await _appUserService.AddAsync(Model);
                result = await _userManager.CreateAsync(Model);
            }
            else
            {
                // var result = await _appUserService.UpdateAsync(Model);
                result = await _userManager.UpdateAsync(Model);
            }

            // Log(result);
            await SaveAsync();
        }

        private async Task SaveAsync()
        {
            Items = await GetAll();
            _showAdd = false;
            IsNew = false;
        }

        protected void Close()
        {
            _showAdd = false;
            _isButtonAddVisible = true;
        }

        protected void DeleteImage(Image image)
        {
            Model.Avatar = new Image();
        }

        protected void AddAddress()
        {
        }

        void Log(IdentityResult result)
        {
            if (result != null)
            {
                IsSucceded = result.Succeeded;

                foreach (var error in result.Errors)
                {
                    LogMessages.Add($"{error.Code}: {error.Description}");
                }

                IsVisible = true;
            }
        }

        protected async Task OnInputFileChange(InputFileChangeEventArgs e)
        {
            Model.Avatar = new Image();
            var imagesDataUrls = await ImageUploadProcessor.GetDataUrlsFromUploadedImagesAsync(e);

            Model.Avatar.Path = imagesDataUrls.First();
        }

        protected void GamesGroupCheckboxOnChange(Models.GamesGroup gamesGroup, ChangeEventArgs e)
        {
            if (Model.GamesGroups == null) Model.GamesGroups = new List<Models.GamesGroup>();

            if ((bool) e.Value)
            {
                if (!Model.GamesGroups.Contains(gamesGroup))
                {
                    Model.GamesGroups.Add(gamesGroup);
                }
            }
            else
            {
                if (Model.GamesGroups.Contains(gamesGroup))
                {
                    Model.GamesGroups.Remove(gamesGroup);
                }
            }
        }
    }

}