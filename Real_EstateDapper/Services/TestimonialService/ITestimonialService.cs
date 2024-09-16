using Real_EstateDapper.Dto.TestimonialDtos;

namespace Real_EstateDapper.Services.TestimonialService
{
    public interface ITestimonialService
    {
        Task<List<ResultTestimonialDtos>> GetAllTestimonialAsync();
    }
}
