using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Components;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using POS.Services;


namespace POS.Pages.Admin.Address
{

    public class AdminContactTypeComponentBase : OwningComponentBase

    {
        protected bool _showAdd = false;
        protected bool _isButtonAddVisible = true;

        //Models
        protected Models.ContactType Model;
        protected List<Models.ContactType> Items;

        //Services
        private ContactService _contactService;
        private ContactTypeService _contactTypeService;

        //Parameters
        [Parameter] public int UserId { get; set; }

        protected async override Task OnInitializedAsync()
        {
            // return base.OnInitializedAsync();

            _contactTypeService = (ContactTypeService) ScopedServices.GetRequiredService(typeof(ContactTypeService));

            Items = await _contactTypeService.GetAllActive().ToListAsync();
        }

        protected void Add()
        {
            Model = new Models.ContactType();

            _showAdd = true;
            _isButtonAddVisible = false;
        }

        protected void Edit(Models.ContactType item)
        {
            _showAdd = true;
            _isButtonAddVisible = false;
            Model = item;
        }

        protected async Task Hide(Models.ContactType item)
        {
            await _contactService.HideAsync(item.Id);
            await SaveAsync();
            StateHasChanged();
        }

        protected async Task ValidSubmit()
        {
            if (Model.Id == 0)
            {
                var result = await _contactTypeService.AddAsync(Model);
                await SaveAsync();
            }
            else
            {
                var result = await _contactTypeService.UpdateAsync(Model);
                await SaveAsync();
            }
        }

        private async Task SaveAsync()
        {
            Items = await _contactTypeService.GetAllActive().ToListAsync();
            _showAdd = false;
        }

        protected void Close()
        {
            _showAdd = false;
            _isButtonAddVisible = true;
        }
    }

}