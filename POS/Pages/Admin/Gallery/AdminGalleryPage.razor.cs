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
        protected bool _showAdd = false;
        protected bool _isButtonAddVisible = true;

        //Models
        protected Models.Gallery Model;
        protected List<Models.Gallery> Items;

        //Services
        private GalleryService _galleryService;


        protected override async Task OnInitializedAsync()
        {
            // return base.OnInitializedAsync();
            _galleryService = (GalleryService) ScopedServices.GetRequiredService(typeof(GalleryService));
            Items = await _galleryService.GetAllActiveGalleries().ToListAsync();
        }

        protected void Add()
        {
            Model = new Models.Gallery();
            Model.Images = new List<Image>();

            _showAdd = true;
            _isButtonAddVisible = false;
        }

        protected void Edit(Models.Gallery item)
        {
            _showAdd = true;
            _isButtonAddVisible = false;
            Model = item;
        }

        protected async Task Hide(Models.Gallery item)
        {
            await _galleryService.HideAsync(item.Id);
            await SaveAsync();
            StateHasChanged();
        }

        protected async Task ValidSubmit()
        {
            if (Model.Id == 0)
            {
                var result = await _galleryService.AddAsync(Model);
                await SaveAsync();
            }
            else
            {
                var result = await _galleryService.UpdateAsync(Model);
                await SaveAsync();
            }
        }

        private async Task SaveAsync()
        {
            Items = await _galleryService.GetAllActiveGalleries().ToListAsync();
            _showAdd = false;
        }

        protected void Close()
        {
            _showAdd = false;
            _isButtonAddVisible = true;
        }

        protected void DeleteImage(Image image)
        {
            Model.Images.Remove(image);
        }


        protected async Task OnInputFileChange(InputFileChangeEventArgs arg)
        {
            // Model=new Models.Gallery();
            var imagesDataUrls = await ImageUploadProcessor.GetDataUrlsFromUploadedImagesAsync(arg);
            imagesDataUrls.ForEach(x =>
            {
                Model.Images.Add(
                    new Image()
                    {
                        Path = x
                    }
                );
            });
        }
    }

}