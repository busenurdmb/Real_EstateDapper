using Dapper;
using Real_EstateDapper.Context;
using Real_EstateDapper.Dto.CategoryDtos;
using Real_EstateDapper.Dto.ImagePropertyDtos;
using Real_EstateDapper.Services.ImagePropertyService;

namespace Real_EstateDapper.Services.ImagePropertyService
{
    public class ImagePropertyService : IImagePropertySevice
    {
        private readonly Real_EstateDapperContext _context;

        public ImagePropertyService(Real_EstateDapperContext context)
        {
            _context = context;
        }

        public async Task<List<ResultImagePropertyDto>> GetAllImagePropertyAsync()
        {
            string query = "Select * From PropertyImages";
            var connection = _context.CreateConnection();
            var values = await connection.QueryAsync<ResultImagePropertyDto>(query);
            return values.ToList();
        }

        public async Task<GetByIdImagePropertyDto> GetByPropertyIdImagePropertyAsync(int id)
        {
            string query = "select * from PropertyImages Where PropertyId=@PropertyId";
            var parameters = new DynamicParameters();
            parameters.Add("@PropertyId", id);
            var x = _context.CreateConnection();
            var values = await x.QueryFirstOrDefaultAsync<GetByIdImagePropertyDto>(query, parameters);
            return values;
        }
    }
}
