using Real_EstateDapper.Dto.AboutUsDtos;
using Real_EstateDapper.Dto.CategoryDtos;

namespace Real_EstateDapper.Services.AboutUsService
{
    public interface IAboutUsService
    {
        Task<List<ResultAboutUsDtos>> GetAllAboutUsAsync();
    }
}
