using Microsoft.AspNetCore.Http;

namespace Service.Helper.DTOs.Features
{
    public class FeatureCreateDto
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public IFormFile Photo { get; set; }
    }
}
