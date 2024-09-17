using Microsoft.AspNetCore.Mvc;

namespace Real_EstateDapper.ViewComponents
{
    public class _LayoutNavbarComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
