using Microsoft.AspNetCore.Mvc;

namespace Real_EstateDapper.Areas.Admin.Controllers
{
	[Area("Admin")]
	[Route("Admin/_AdminLayout")]
	public class _AdminLayoutController : Controller
	{
		
		
		[Route("Index")]
        public IActionResult Index()
		{
			return View();
		}
	}
}
