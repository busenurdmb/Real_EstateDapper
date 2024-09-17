using Microsoft.AspNetCore.Mvc;

namespace Real_EstateDapper.ViewComponents.AboutLayoutComponents
{
	public class _AboutLayoutNavbarComponentPartial : ViewComponent
	{
		public IViewComponentResult Invoke()
		{
			return View();
		}
	}
}
