using Microsoft.AspNetCore.Mvc;

namespace Real_EstateDapper.ViewComponents.AboutLayoutComponents
{
	public class _AboutLayoutFooterComponentPartial:ViewComponent
	{
		public IViewComponentResult Invoke()
		{
			return View();
		}
	}
}
