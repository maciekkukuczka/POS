// using System.Collections.Generic;
// using System.Threading.Tasks;
// using Microsoft.AspNetCore.Components;
// using Microsoft.EntityFrameworkCore;
// using Microsoft.Extensions.DependencyInjection;
// using POS.Services;
//
//
// namespace POS.Pages.Admin.Role
// {
//
//     public class AdminGamesGroupComponentBase : OwningComponentBase
//
//     {
//         protected bool _showAdd = false;
//         protected bool _isButtonAddVisible = true;
//
//         //Models
//         protected Models.GamesGroup Model;
//         protected List<Models.GamesGroup> Items;
//
//         //Services
//         private GamesGroupService _gamesGroupService;
//
//         //Parameters
//         [Parameter] public int UserId { get; set; }
//
//         protected async override Task OnInitializedAsync()
//         {
//             // return base.OnInitializedAsync();
//
//             _gamesGroupService = (GamesGroupService) ScopedServices.GetRequiredService(typeof(GamesGroupService));
//
//             Items = await _gamesGroupService.GetAllActive().ToListAsync();
//         }
//
//         protected void Add()
//         {
//             Model = new Models.GamesGroup();
//
//             _showAdd = true;
//             _isButtonAddVisible = false;
//         }
//
//         protected void Edit(Models.GamesGroup item)
//         {
//             _showAdd = true;
//             _isButtonAddVisible = false;
//             Model = item;
//         }
//
//         protected async Task Hide(Models.GamesGroup item)
//         {
//             await _gamesGroupService.HideAsync(item.Id);
//             await SaveAsync();
//             StateHasChanged();
//         }
//
//         protected async Task ValidSubmit()
//         {
//             if (Model.Id == 0)
//             {
//                 var result = await _gamesGroupService.AddAsync(Model);
//                 await SaveAsync();
//             }
//             else
//             {
//                 var result = await _gamesGroupService.UpdateAsync(Model);
//                 await SaveAsync();
//             }
//         }
//
//         private async Task SaveAsync()
//         {
//             Items = await _gamesGroupService.GetAllActive().ToListAsync();
//             _showAdd = false;
//         }
//
//         protected void Close()
//         {
//             _showAdd = false;
//             _isButtonAddVisible = true;
//         }
//     }
//
// }
