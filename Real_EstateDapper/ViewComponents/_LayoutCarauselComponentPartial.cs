using Microsoft.AspNetCore.Mvc;

namespace Real_EstateDapper.ViewComponents
{
    public class _LayoutCarauselComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
