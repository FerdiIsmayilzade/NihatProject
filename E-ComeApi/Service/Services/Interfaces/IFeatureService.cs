using Service.Helper.DTOs.Features;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Services.Interfaces
{
    public interface IFeatureService
    {
        Task<FeatureDto> GetBtIdAsync(int id);
        Task<IEnumerable<FeatureDto>> GetAllAsync();
        Task CreateAsync(FeatureCreateDto feature);
    }
}
