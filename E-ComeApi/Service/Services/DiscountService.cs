using Service.Helper.DTOs.Discounts;
using Service.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Services
{
    public class DiscountService : IDiscountService
    {
        public Task CreateAsync(DiscountCreateDto discount)
        {
            throw new NotImplementedException();
        }

        public Task DeleteAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task EditAsync(DiscountEditDto discount)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<DiscountDto>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<DiscountDto> GetByIdAsync(int id)
        {
            throw new NotImplementedException();
        }
    }
}
