using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Components;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using POS.Services;


namespace POS.Pages.Admin.Rank
{

    public class AdminRankComponentBase : OwningComponentBase

    {
        protected bool _showAdd = false;
        protected bool _isButtonAddVisible = true;

        //Models
        protected Models.Rank Model;
        protected List<Models.Rank> Items;

        //Services
        private RankService _rankService;
        private ContactTypeService _contactTypeService;

        //Parameters
        [Parameter] public int UserId { get; set; }

        protected async override Task OnInitializedAsync()
        {
            // return base.OnInitializedAsync();

            _rankService = (RankService) ScopedServices.GetRequiredService(typeof(RankService));

            Items = await _rankService.GetAllActive().ToListAsync();
        }

        protected void Add()
        {
            Model = new Models.Rank();

            _showAdd = true;
            _isButtonAddVisible = false;
        }

        protected void Edit(Models.Rank item)
        {
            _showAdd = true;
            _isButtonAddVisible = false;
            Model = item;
        }

        protected async Task Hide(Models.Rank item)
        {
            await _rankService.HideAsync(item.Id);
            await SaveAsync();
            StateHasChanged();
        }

        protected async Task ValidSubmit()
        {
            if (Model.Id == 0)
            {
                var result = await _rankService.AddAsync(Model);
                await SaveAsync();
            }
            else
            {
                var result = await _rankService.UpdateAsync(Model);
                await SaveAsync();
            }
        }

        private async Task SaveAsync()
        {
            Items = await _rankService.GetAllActive().ToListAsync();
            _showAdd = false;
        }

        protected void Close()
        {
            _showAdd = false;
            _isButtonAddVisible = true;
        }
    }

}