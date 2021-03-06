﻿using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Components;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using POS.Services;


namespace POS.Pages.Frontend.CMSPage
{

    public class CMSPageComponentBase : OwningComponentBase

    {
        protected bool _showAdd = false;
        protected bool _isButtonAddVisible = true;
        protected string Display;

        //Models
        protected Models.CMSPage Model = new Models.CMSPage();
        protected List<Models.CMSPage> Items;

        //Services
        private CMSPageService _cmsPageService;

        //Parameters
        [Parameter] public string PageRoute { get; set; }

        protected async override Task OnInitializedAsync()
        {
            // return base.OnInitializedAsync();

            _cmsPageService = (CMSPageService) ScopedServices.GetRequiredService(typeof(CMSPageService));

            Items = await _cmsPageService.GetAllActiveCmsPages().ToListAsync();
        }

        protected override void OnParametersSet()
        {
            base.OnParametersSet();

            foreach (var cmsPage in Items)
            {
                if (PageRoute == cmsPage.Name)
                {
                    Model = cmsPage;
                }
            }


            // StateHasChanged();
        }
    }

}