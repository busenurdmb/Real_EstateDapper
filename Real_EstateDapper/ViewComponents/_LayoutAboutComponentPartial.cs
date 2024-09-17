using Microsoft.AspNetCore.Mvc;
using Real_EstateDapper.Services.AboutUsService;
using Real_EstateDapper.Services.PropertyService;

namespace Real_EstateDapper.ViewComponents
{
    public class _LayoutAboutComponentPartial : ViewComponent
    {
        private readonly IAboutUsService _aboutService;

        public _LayoutAboutComponentPartial(IAboutUsService aboutService)
        {
            _aboutService = aboutService;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var values =await _aboutService.GetAllAboutUsAsync();
            return View(values);
        }
    }
}
