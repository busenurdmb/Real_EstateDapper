using Microsoft.AspNetCore.Mvc;
using Real_EstateDapper.Services.PropertyService;
using X.PagedList.Extensions;

namespace Real_EstateDapper.ViewComponents
{
    public class _LayoutPropertyListComponetPartial : ViewComponent
    {
        private readonly IPropertyService _propertyService;

        public _LayoutPropertyListComponetPartial(IPropertyService propertyService)
        {
            _propertyService = propertyService;
        }

        public async Task<IViewComponentResult> InvokeAsync(int? page)
        {
            var values =await _propertyService.GetAllPropertyAsync();
            int pageNumber = page ?? 1;
            var pagedList = values.ToPagedList(pageNumber, 6);
            return View(pagedList);
        }
    }
}
