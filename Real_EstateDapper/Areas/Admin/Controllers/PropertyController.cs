using Microsoft.AspNetCore.Mvc;

namespace Real_EstateDapper.Areas.Admin.Controllers
{
	[Area("Admin")]
	[Route("Admin/Property")]
	public class PropertyController : Controller
	{
		[Route("Index")]

		public IActionResult Index()
		{
			return View();
		}
	}
}
