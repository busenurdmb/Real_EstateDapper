using Microsoft.AspNetCore.Mvc;

namespace Real_EstateDapper.ViewComponents.AdminLayoutComponents
{
    public class _AdminLayoutHeaderPartialComponent : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
