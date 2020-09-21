using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Components;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using POS.Services;


namespace POS.Pages.Admin.Blood
{

    public class AdminBloodComponentBase : OwningComponentBase

    {
        protected bool _showAdd = false;
        protected bool _isButtonAddVisible = true;

        //Models
        protected Models.Blood Model;
        protected List<Models.Blood> Items;

        //Services
        private BloodService _bloodService;

        //Parameters
        [Parameter] public int UserId { get; set; }

        protected async override Task OnInitializedAsync()
        {
            // return base.OnInitializedAsync();

            _bloodService = (BloodService) ScopedServices.GetRequiredService(typeof(BloodService));

            Items = await _bloodService.GetAllActive().ToListAsync();
        }

        protected void Add()
        {
            Model = new Models.Blood();

            _showAdd = true;
            _isButtonAddVisible = false;
        }

        protected void Edit(Models.Blood item)
        {
            _showAdd = true;
            _isButtonAddVisible = false;
            Model = item;
        }

        protected async Task Hide(Models.Blood item)
        {
            await _bloodService.HideAsync(item.Id);
            await SaveAsync();
            StateHasChanged();
        }

        protected async Task ValidSubmit()
        {
            if (Model.Id == 0)
            {
                var result = await _bloodService.AddAsync(Model);
                await SaveAsync();
            }
            else
            {
                var result = await _bloodService.UpdateAsync(Model);
                await SaveAsync();
            }
        }

        private async Task SaveAsync()
        {
            Items = await _bloodService.GetAllActive().ToListAsync();
            _showAdd = false;
        }

        protected void Close()
        {
            _showAdd = false;
            _isButtonAddVisible = true;
        }
    }

}