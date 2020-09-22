using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Components;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using POS.Services;


namespace POS.Pages.Admin.CMSPage
{

    public class AdminCMSPageComponentBase : OwningComponentBase

    {
        protected bool _showAdd = false;
        protected bool _isButtonAddVisible = true;

        //Models
        protected Models.CMSPage Model;
        protected List<Models.CMSPage> Items;
        protected List<Models.AppUser> Users;

        //Services
        private CMSPageService _cmsPageService;
        private AppUserService _appUserService;


        protected async override Task OnInitializedAsync()
        {
            // return base.OnInitializedAsync();

            _cmsPageService = (CMSPageService) ScopedServices.GetRequiredService(typeof(CMSPageService));
            _appUserService = (AppUserService) ScopedServices.GetRequiredService(typeof(AppUserService));

            Items = await _cmsPageService.GetAllActive().ToListAsync();
            Users = await _appUserService.GetAllActive().ToListAsync();
        }

        protected void Add()
        {
            Model = new Models.CMSPage();

            _showAdd = true;
            _isButtonAddVisible = false;
        }

        protected void Edit(Models.CMSPage item)
        {
            _showAdd = true;
            _isButtonAddVisible = false;
            Model = item;
        }

        protected async Task Hide(Models.CMSPage item)
        {
            await _cmsPageService.HideAsync(item.Id);
            await SaveAsync();
            StateHasChanged();
        }

        protected async Task ValidSubmit()
        {
            if (Model.Id == 0)
            {
                var result = await _cmsPageService.AddAsync(Model);
                await SaveAsync();
            }
            else
            {
                var result = await _cmsPageService.UpdateAsync(Model);
                await SaveAsync();
            }
        }

        private async Task SaveAsync()
        {
            Items = await _cmsPageService.GetAllActive().ToListAsync();
            _showAdd = false;
        }

        protected void Close()
        {
            _showAdd = false;
            _isButtonAddVisible = true;
        }
    }

}