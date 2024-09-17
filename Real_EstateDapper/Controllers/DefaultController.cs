using Microsoft.AspNetCore.Mvc;
using Real_EstateDapper.Services.PropertyService;
using X.PagedList.Extensions;

namespace Real_EstateDapper.Controllers
{
    public class DefaultController : Controller
    {
        private readonly IPropertyService _propertyService;

        public DefaultController(IPropertyService propertyService)
        {
            _propertyService = propertyService;
        }

        public async Task<IActionResult> Index(int? page)
        {
            var values = await _propertyService.GetAllPropertyAsync();
            int pageNumber = page ?? 1;
            var pagedList = values.ToPagedList(pageNumber, 6);
            return View(pagedList);
        }
    }
}
