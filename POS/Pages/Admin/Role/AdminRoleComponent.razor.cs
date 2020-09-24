using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using POS.Models;


namespace POS.Pages.Admin.Role
{

    public class AdminGamesGroupComponentBase : OwningComponentBase

    {
        [Inject] private RoleManager<IdentityRole> _roleManager { get; set; }
        [Inject] private UserManager<AppUser> _userManager { get; set; }

        [CascadingParameter] private Task<AuthenticationState> _authState { get; set; }

        protected bool _showAdd = false;
        protected bool _isButtonAddVisible = true;

        //Models
        protected IdentityRole Model;
        protected List<IdentityRole> Items = new List<IdentityRole>();

        protected async override Task OnInitializedAsync()
        {
            // return base.OnInitializedAsync();
            Items = await _roleManager.Roles.ToListAsync();
        }

        protected async Task Add()
        {
            Model = new IdentityRole();
            Model.Id = "0";

            _showAdd = true;
            _isButtonAddVisible = false;
        }

        protected void Edit(IdentityRole item)
        {
            _showAdd = true;
            _isButtonAddVisible = false;
            Model = item;
        }

        protected async Task Delete(IdentityRole item)
        {
            var roleExist = await _roleManager.FindByNameAsync(item.Name);

            if (roleExist != null)
            {
                await _roleManager.DeleteAsync(item);
            }

            await SaveAsync();
            StateHasChanged();
        }

        protected async Task ValidSubmit()
        {
            if (Model.Id == "0")
            {
                var roleExist = await _roleManager.FindByNameAsync(Model.Name);

                if (roleExist == null)
                {
                    // Model.Id = Model.Name;
                    await _roleManager.CreateAsync(new IdentityRole(Model.Name));
                    await SaveAsync();
                }
                else
                {
                    var error = "Rola już istnieje!";
                }
            }
            else
            {
                var result = await _roleManager.UpdateAsync(Model);
                await SaveAsync();
            }
        }

        private async Task SaveAsync()
        {
            Items = await _roleManager.Roles.ToListAsync();
            _showAdd = false;
        }

        protected void Close()
        {
            _showAdd = false;
            _isButtonAddVisible = true;
        }
    }

}