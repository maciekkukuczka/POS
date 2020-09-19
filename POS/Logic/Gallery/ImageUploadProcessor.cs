using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Components.Forms;


namespace POS.Logic.Gallery
{

    public static class ImageUploadProcessor
    {
        public static async Task<List<string>> GetDataUrlsFromUploadedImagesAsync(InputFileChangeEventArgs e)
        {
            var imageUrls = new List<string>();

            var imagefiles = e.GetMultipleFiles();

            var format = "image/png";

            foreach (var imagefile in imagefiles)
            {
                var resizedImageFile = await imagefile.RequestImageFileAsync(format, 200, 200);
                var buffer = new byte[resizedImageFile.Size];

                await resizedImageFile.OpenReadStream().ReadAsync(buffer);

                var imageDataUrl = $"data:{format};base64,{Convert.ToBase64String(buffer)}";

                imageUrls.Add(imageDataUrl);
            }

            return imageUrls;
        }
    }

}