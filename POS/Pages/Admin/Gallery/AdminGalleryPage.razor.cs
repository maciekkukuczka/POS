using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Forms;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using POS.Logic.Gallery;
using POS.Models;
using POS.Services;


namespace POS.Pages.Admin.Gallery
{

    public class AdminGalleryPageBase : OwningComponentBase
    {
        //Models
        protected Models.Gallery Model = new Models.Gallery();
        protected List<Models.Gallery> Items;

        //Services
        private GalleryService _galleryService;


        protected override async Task OnInitializedAsync()
        {
            // return base.OnInitializedAsync();
            _galleryService = (GalleryService) ScopedServices.GetRequiredService(typeof(GalleryService));
            Items = await _galleryService.GetAllActiveGalleries().ToListAsync();
        }

        protected async Task OnInputFileChange(InputFileChangeEventArgs arg)
        {
            var imagesDataUrls = await ImageUploadProcessor.GetDataUrlsFromUploadedImagesAsync(arg);
        }

        protected Task DeleteImage(Image image)
        {
            return Task.CompletedTask;
        }

        //Data Seed
        void AddGallery()
        {
            var gallery = new Models.Gallery();
            gallery.Name = "Galeria 1";
            gallery.Images = new List<Image>();

            gallery.Images.Add(new Image()
            {
            });
        }
    }

}