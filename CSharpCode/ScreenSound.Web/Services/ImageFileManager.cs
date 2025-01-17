using Microsoft.AspNetCore.Components.Forms;

namespace ScreenSound.Web.Services
{
    public class ImageFileManager
    {
        public static async Task<Dictionary<string, string>> UploadFile(IBrowserFile file)
        {
            string? fileImage, fotoPerfil;
            long maxFileSize = 1024 * 1024 * 15;
            var format = "image/jpeg";
            var resizedImage = await file.RequestImageFileAsync(format, 200, 200);

            using var fileStream = resizedImage.OpenReadStream(maxFileSize);
            using var memoryStream = new MemoryStream();
            await fileStream.CopyToAsync(memoryStream);

            var imageUpload = Convert.ToBase64String(memoryStream.ToArray());
            fileImage = $"data:{format};base64,{imageUpload}";

            fotoPerfil = imageUpload;
            return new Dictionary<string, string>
            { 
                { "fileImage", fileImage },
                { "foto", fotoPerfil }
            };
        }
    }
}
