using Real_EstateDapper.Dto.PropertyDtos;

namespace Real_EstateDapper.Services.PropertyService
{
    public interface IPropertyService
    {
        Task<List<ResultPropertyDto>> GetAllPropertyAsync();
        Task<List<ResultPropertyWithCategoryDto>> GetAllPropertyWithCategoryAsync();
        //Task<List<ResultPropertyWithCategoryDto>> GetAllPropertyWithCategoryrProcedureAsync();
        Task CreatePropertyAsync(CreatePropertyDto createPropertyDto);
        Task UpdatePropertyAsync(UpdatePropertyDto updatePropertyDto);
        Task DeletePropertyAsync(int id);
        Task<GetByIdPropertyDto> GetByIdPropertyAsync(int id);
    }
}
