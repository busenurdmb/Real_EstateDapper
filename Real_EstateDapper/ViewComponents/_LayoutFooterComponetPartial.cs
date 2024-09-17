using Microsoft.AspNetCore.Mvc;

namespace Real_EstateDapper.ViewComponents
{
    public class _LayoutFooterComponetPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
