using Microsoft.AspNetCore.Mvc;

namespace Real_EstateDapper.ViewComponents.AdminLayoutComponents
{
	public class _AdminLayoutScriptComponentPartial : ViewComponent
	{
		public IViewComponentResult Invoke()
		{
			return View();
		}
	}
}
