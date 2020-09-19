using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Components;
using Microsoft.EntityFrameworkCore;
using POS.Services;


namespace POS.Pages.Frontend.News
{

    public class GalleryComponentBase : OwningComponentBase
    {
        protected bool isGalleryExpanded = false;

        //Models
        protected List<Models.Gallery> Items;

        //Services
        private GalleryService _galleryService;

        protected async override Task OnInitializedAsync()
        {
            // return base.OnInitializedAsync();

            _galleryService = (GalleryService) ScopedServices.GetService(typeof(GalleryService));
            Items = await _galleryService.GetGalleries(true).ToListAsync();
        }


        protected void ExpandGallery(Models.Gallery gallery)
        {
            gallery.Class = gallery.Class == "gallery-expanded" ? "" : "gallery-expanded";

            // isGalleryExpanded = !isGalleryExpanded;
        }
    }

}