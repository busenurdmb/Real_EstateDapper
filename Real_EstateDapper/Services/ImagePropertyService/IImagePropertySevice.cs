using Real_EstateDapper.Dto.AboutUsDtos;
using Real_EstateDapper.Dto.ImagePropertyDtos;
using Real_EstateDapper.Dto.PropertyDtos;

namespace Real_EstateDapper.Services.ImagePropertyService
{
    public interface IImagePropertySevice
    {
        Task<List<ResultImagePropertyDto>> GetAllImagePropertyAsync();
        Task<GetByIdImagePropertyDto> GetByPropertyIdImagePropertyAsync(int id);

    }
}
