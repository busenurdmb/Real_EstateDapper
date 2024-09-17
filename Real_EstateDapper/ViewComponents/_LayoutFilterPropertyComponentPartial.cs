using Microsoft.AspNetCore.Mvc;
using Real_EstateDapper.Services.CategoryService;
using Real_EstateDapper.Services.PropertyService;

namespace Real_EstateDapper.ViewComponents
{
    public class _LayoutFilterPropertyComponentPartial : ViewComponent
    {
        private readonly IPropertyService _propertyService;
        private readonly ICategoryService _categoryService;

        public _LayoutFilterPropertyComponentPartial(IPropertyService propertyService, ICategoryService categoryService)
        {
            _propertyService = propertyService;
            _categoryService = categoryService;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var categories = await _categoryService.GetAllCategoryAsync();
            var addresses = await _propertyService.GetAllPropertyAddressAsync();

            ViewBag.Categories = categories;
            ViewBag.Addresses = addresses;
            return View();
        }
    }
}
