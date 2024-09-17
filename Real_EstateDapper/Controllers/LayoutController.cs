using Microsoft.AspNetCore.Mvc;

namespace Real_EstateDapper.Controllers
{
    public class LayoutController : Controller
    {
        public IActionResult _Layout()
        {
            return View();
        }
    }
}
