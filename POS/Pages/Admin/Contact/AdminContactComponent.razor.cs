using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Components;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using POS.Services;


namespace POS.Pages.Admin.Contact
{

    public class AdminContactComponentBase : OwningComponentBase

    {
        protected bool _showAdd = false;
        protected bool _isButtonAddVisible = true;

        //Models
        protected Models.Contact Model;
        protected List<Models.Contact> Items;
        protected List<Models.ContactType> ContactTypes;

        //Services
        private ContactService _contactService;
        private ContactTypeService _contactTypeService;

        //Parameters
        [Parameter] public string UserId { get; set; }

        protected async override Task OnInitializedAsync()
        {
            // return base.OnInitializedAsync();

            _contactService = (ContactService) ScopedServices.GetRequiredService(typeof(ContactService));
            _contactTypeService = (ContactTypeService) ScopedServices.GetRequiredService(typeof(ContactTypeService));

            Items = await _contactService.GetAllActiveContactsByUser(int.Parse(UserId)).ToListAsync();
            ContactTypes = await _contactTypeService.GetAllActive().ToListAsync();
        }

        protected void Add()
        {
            Model = new Models.Contact();

            Model.AppUserId = int.Parse(UserId);
            _showAdd = true;
            _isButtonAddVisible = false;
        }

        protected void Edit(Models.Contact item)
        {
            _showAdd = true;
            _isButtonAddVisible = false;
            Model = item;
        }

        protected async Task Hide(Models.Contact item)
        {
            await _contactService.HideAsync(item.Id);
            await SaveAsync();
            StateHasChanged();
        }

        protected async Task ValidSubmit()
        {
            if (Model.Id == 0)
            {
                var result = await _contactService.AddAsync(Model);
                await SaveAsync();
            }
            else
            {
                var result = await _contactService.UpdateAsync(Model);
                await SaveAsync();
            }
        }

        private async Task SaveAsync()
        {
            Items = await _contactService.GetAllActiveContactsByUser(int.Parse(UserId)).ToListAsync();
            _showAdd = false;
        }

        protected void Close()
        {
            _showAdd = false;
            _isButtonAddVisible = true;
        }
    }

}