using Dapper;
using Real_EstateDapper.Context;
using Real_EstateDapper.Dto.AboutUsDtos;
using Real_EstateDapper.Dto.CategoryDtos;

namespace Real_EstateDapper.Services.AboutUsService
{
    public class AboutUsService:IAboutUsService
    {
        private readonly Real_EstateDapperContext _context;

        public AboutUsService(Real_EstateDapperContext context)
        {
            _context = context;
        }

        public async Task<List<ResultAboutUsDtos>> GetAllAboutUsAsync()
        {
            string query = "Select * From AboutUs";
            var connection = _context.CreateConnection();
            var values = await connection.QueryAsync<ResultAboutUsDtos>(query);
            return values.ToList();
        }

    
    }
}
