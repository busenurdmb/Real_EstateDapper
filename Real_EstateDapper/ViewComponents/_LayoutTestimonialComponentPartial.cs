using Microsoft.AspNetCore.Mvc;
using Real_EstateDapper.Services.TestimonialService;

namespace Real_EstateDapper.ViewComponents
{
    public class _LayoutTestimonialComponentPartial : ViewComponent
    {
        private readonly ITestimonialService _testimonialService;

        public _LayoutTestimonialComponentPartial(ITestimonialService testimonialService)
        {
            _testimonialService = testimonialService;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var values=await _testimonialService.GetAllTestimonialAsync();
            return View(values);
        }
    }
}
