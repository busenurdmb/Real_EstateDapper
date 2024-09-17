using Microsoft.AspNetCore.Mvc;

namespace Real_EstateDapper.ViewComponents.AboutLayoutComponents
{
    public class _AboutLayoutHeaderPartialComponent:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
