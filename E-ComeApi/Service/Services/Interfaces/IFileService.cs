using Microsoft.AspNetCore.Http;
using Service.Helper.Response;

namespace Service.Services.Interfaces
{
    public interface IFileService
    {
        Task<UploadResponse> UploadAsync(IFormFile file);
        void Delete(string fileName);
    }
}
