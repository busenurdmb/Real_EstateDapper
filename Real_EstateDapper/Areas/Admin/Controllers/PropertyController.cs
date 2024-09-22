using Microsoft.AspNetCore.Mvc;
using Real_EstateDapper.Dto.PropertyDtos;
using Real_EstateDapper.Services.CategoryService;
using Real_EstateDapper.Services.PropertyService;

namespace Real_EstateDapper.Areas.Admin.Controllers
{
	[Area("Admin")]
	[Route("Admin/Property")]
	public class PropertyController : Controller
	{
        private readonly IPropertyService _propertyService;
        private readonly ICategoryService _categoryService;

        public PropertyController(IPropertyService propertyService, ICategoryService categoryService)
        {
            _propertyService = propertyService;
            _categoryService = categoryService;
        }

        [Route("Index")]
        public async Task<IActionResult> Index()
		{
            var values=await _propertyService.GetAllPropertyAsync();
          
            return View(values);
		}

        [Route("Create")]
        [HttpGet]
        public async Task<IActionResult> Create()
        {
            var categories = await _categoryService.GetAllCategoryAsync();
            ViewBag.Categories = categories;

            return View();
        }

        [Route("Create")]
        [HttpPost]
        public async Task<IActionResult> Create(CreatePropertyDto createPropertyDto)
        {;
            createPropertyDto.ImagePropertyId = 3;
          await  _propertyService.CreatePropertyAsync(createPropertyDto);
            return RedirectToAction("Index", "Property", new { area = "Admin" });
        }

        [Route("Update/{id}")]
        [HttpGet]
        public async Task<IActionResult> Update(int id)
        {
            var values= await _propertyService.GetByIdPropertyAsync(id);
            
            var categories = await _categoryService.GetAllCategoryAsync();
            ViewBag.Categories = categories;

            return View(values);
        }

        [Route("Update")]
        public async Task<IActionResult> Update(UpdatePropertyDto updatePropertyDto)
        {
            await _propertyService.UpdatePropertyAsync(updatePropertyDto);
            return RedirectToAction("Index", "Property", new { area = "Property" });
        }

        [Route("Delete/{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            await _propertyService.DeletePropertyAsync(id);

            return RedirectToAction("Index", "Property", new { area = "Property" });
        }
    }
}
