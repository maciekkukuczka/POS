﻿using System.Collections.Generic;
using System.Linq;
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
        protected AppUser Model;
        protected List<AppUser> Items;
        protected List<Models.Blood> Bloods;
        protected List<Models.Rank> Ranks;
        protected List<Models.GamesGroup> GamesGroups;


        // protected List<string> ImageUrls=new List<string>();

        //Services
        private AppUserService _appUserService;
        private BloodService _bloodService;
        private RankService _rankService;
        private GamesGroupService _gamesGroupService;


        protected async override Task OnInitializedAsync()
        {
            // return base.OnInitializedAsync();

            _appUserService = (AppUserService) ScopedServices.GetRequiredService(typeof(AppUserService));
            _bloodService = (BloodService) ScopedServices.GetRequiredService(typeof(BloodService));
            _rankService = (RankService) ScopedServices.GetRequiredService(typeof(RankService));
            _gamesGroupService = (GamesGroupService) ScopedServices.GetRequiredService(typeof(GamesGroupService));

            Items = await _appUserService.GetAllActiveUsers().ToListAsync();
            Bloods = await _bloodService.GetAllActive().ToListAsync();
            Ranks = await _rankService.GetAllActive().ToListAsync();
            GamesGroups = await _gamesGroupService.GetAllActiveGamesGroups().ToListAsync();
        }

        protected void Add()
        {
            Model = new AppUser();

            // Model.Avatar = new Image();

            // Model.Blood = new Blood();
            // Model.Rank = new Models.Rank();
            Model.GamesGroups = new List<Models.GamesGroup>();
            Model.Addresses = new List<Models.Address>();

            _showAdd = true;
            _isButtonAddVisible = false;
        }

        protected void Edit(AppUser item)
        {
            _showAdd = true;
            _isButtonAddVisible = false;
            Model = item;
        }

        protected async Task Hide(AppUser item)
        {
            await _appUserService.HideAsync(item.Id);
            await SaveAsync();
            StateHasChanged();
        }

        protected async Task ValidSubmit()
        {
            if (Model.Id == 0)
            {
                var result = await _appUserService.AddAsync(Model);
                await SaveAsync();
            }
            else
            {
                var result = await _appUserService.UpdateAsync(Model);
                await SaveAsync();
            }
        }

        private async Task SaveAsync()
        {
            Items = await _appUserService.GetAllActiveUsers().ToListAsync();
            _showAdd = false;
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

        protected async Task OnInputFileChange(InputFileChangeEventArgs e)
        {
            Model.Avatar = new Image();
            var imagesDataUrls = await ImageUploadProcessor.GetDataUrlsFromUploadedImagesAsync(e);

            Model.Avatar.Path = imagesDataUrls.First();
        }

        protected void GamesGroupCheckboxOnChange(Models.GamesGroup gamesGroup, ChangeEventArgs e)
        {
            if (Model.GamesGroups == null) Model.GamesGroups = new List<Models.GamesGroup>();

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