using Dapper;
using Real_EstateDapper.Context;
using Real_EstateDapper.Dto.PropertyDtos;
using Real_EstateDapper.Dto.TestimonialDtos;

namespace Real_EstateDapper.Services.TestimonialService
{
    public class TestimonialService : ITestimonialService
    {
        private readonly Real_EstateDapperContext _context;

        public TestimonialService(Real_EstateDapperContext context)
        {
            _context = context;
        }

        public async Task<List<ResultTestimonialDtos>> GetAllTestimonialAsync()
        {
            const string query = "SELECT * FROM Testimonials";

            using var connection = _context.CreateConnection();
            var properties = await connection.QueryAsync<ResultTestimonialDtos>(query);
            return properties.ToList();
        }
    }
}
