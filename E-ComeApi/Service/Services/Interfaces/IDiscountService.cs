using Service.Helper.DTOs.Discounts;

namespace Service.Services.Interfaces
{
    public interface IDiscountService
    {
        Task<IEnumerable<DiscountDto>> GetAllAsync();
        Task<DiscountDto> GetByIdAsync(int id);
        Task DeleteAsync(int id);
        Task CreateAsync(DiscountCreateDto discount);
        Task EditAsync(DiscountEditDto discount);
    }
}
