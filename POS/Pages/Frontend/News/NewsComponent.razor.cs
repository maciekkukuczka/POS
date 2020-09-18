using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Components;
using Microsoft.EntityFrameworkCore;
using POS.Services;


namespace POS.Pages.Frontend.News
{

    public class NewsComponentBase : OwningComponentBase
    {
        //Models
        protected List<Models.News> Items;

        //Services
        private NewsService _newsService;

        protected async override Task OnInitializedAsync()
        {
            // return base.OnInitializedAsync();

            _newsService = (NewsService) ScopedServices.GetService(typeof(NewsService));
            Items = await _newsService.GetAllVisibleNews().ToListAsync();
        }
    }

}