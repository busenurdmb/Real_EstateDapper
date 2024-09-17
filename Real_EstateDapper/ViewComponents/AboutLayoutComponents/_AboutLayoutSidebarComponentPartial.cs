using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;

namespace Real_EstateDapper.ViewComponents.AboutLayoutComponents
{
	public class _AboutLayoutSidebarComponentPartial:ViewComponent
	{
		

		public IViewComponentResult Invoke()
		{
		   return View();
		}
	}
}
