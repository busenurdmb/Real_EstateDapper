using Microsoft.AspNetCore.Mvc;
using Real_EstateDapper.Services.CategoryService;
using Real_EstateDapper.Services.PropertyService;
using X.PagedList.Extensions;

namespace Real_EstateDapper.Controllers
{
    public class PropertyController : Controller
    {
        private readonly IPropertyService _propertyService;
        private readonly ICategoryService _categoryService;

        public PropertyController(IPropertyService propertyService, ICategoryService categoryService)
        {
            _propertyService = propertyService;
            _categoryService = categoryService;
        }

        public async Task<IActionResult> LayoutPropertyList(int? page, string offerType, string city, int? categoryId)
        {
            // Kategoriler ve adresler için verileri al
            var categories = await _categoryService.GetAllCategoryAsync();
            var addresses = await _propertyService.GetAllPropertyAddressAsync();

            ViewBag.Categories = categories;
            ViewBag.Addresses = addresses;

            // Tüm mülkleri al
            var allProperties = await _propertyService.GetFilteredProperties(categoryId, offerType, city);

            //// Filtreleme işlemleri
            //if (!string.IsNullOrEmpty(offerType))
            //{
            //    allProperties = allProperties.Where(p => p.OfferType == offerType).ToList();
            //}
            //if (!string.IsNullOrEmpty(city))
            //{
            //    allProperties = allProperties.Where(p => p.Adreess == city).ToList();
            //}
            //if (categoryId.HasValue)
            //{
            //    allProperties = allProperties.Where(p => p.CategoryId == categoryId.Value).ToList();
            //}

            // Sayfalama işlemi
            int pageNumber = page ?? 1;
            var pagedList = allProperties.ToPagedList(pageNumber, 9);

            return View(pagedList);
        }

        public async Task<IActionResult> PropertyDetail(int id)
        {
            var values =await _propertyService.GetByIdPropertyAsync(id);
            return View(values);
        }
    }
}
