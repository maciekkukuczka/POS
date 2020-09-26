using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Components;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using POS.Services;


namespace POS.Pages.Admin.Address
{

    public class AdminAddressComponentBase : OwningComponentBase

    {
        protected bool _showAdd = false;
        protected bool _isButtonAddVisible = true;

        //Models
        protected Models.Address Model;
        protected List<Models.Address> Items;

        //Services
        private AddressService _addressService;

        //Parameters
        [Parameter] public string UserId { get; set; }

        protected async override Task OnInitializedAsync()
        {
            // return base.OnInitializedAsync();

            _addressService = (AddressService) ScopedServices.GetRequiredService(typeof(AddressService));

            Items = await _addressService.GetAllActiveAddressesByUser(UserId).ToListAsync();
        }

        protected void Add()
        {
            Model = new Models.Address();

            Model.AppUserId = UserId;
            _showAdd = true;
            _isButtonAddVisible = false;
        }

        protected void Edit(Models.Address item)
        {
            _showAdd = true;
            _isButtonAddVisible = false;
            Model = item;
        }

        protected async Task Hide(Models.Address item)
        {
            await _addressService.HideAsync(item.Id);
            await SaveAsync();
            StateHasChanged();
        }

        protected async Task ValidSubmit()
        {
            if (Model.Id == 0)
            {
                var result = await _addressService.AddAsync(Model);
                await SaveAsync();
            }
            else
            {
                var result = await _addressService.UpdateAsync(Model);
                await SaveAsync();
            }
        }

        private async Task SaveAsync()
        {
            Items = await _addressService.GetAllActiveAddressesByUser(UserId).ToListAsync();
            _showAdd = false;
        }

        protected void Close()
        {
            _showAdd = false;
            _isButtonAddVisible = true;
        }
    }

}