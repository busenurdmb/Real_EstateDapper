using Microsoft.AspNetCore.Mvc;
using Real_EstateDapper.Services.ImagePropertyService;

namespace Real_EstateDapper.ViewComponents
{
    public class _PropertyDetailGaleryComponentPartial : ViewComponent
    {
        private readonly IImagePropertySevice _ımagePropertySevice;

        public _PropertyDetailGaleryComponentPartial(IImagePropertySevice ımagePropertySevice)
        {
            _ımagePropertySevice = ımagePropertySevice;
        }

        public async Task<IViewComponentResult> InvokeAsync(int id)
        {
            var values = await _ımagePropertySevice.GetByPropertyIdImagePropertyAsync(id);
            return View(values);
        }
    }
}
