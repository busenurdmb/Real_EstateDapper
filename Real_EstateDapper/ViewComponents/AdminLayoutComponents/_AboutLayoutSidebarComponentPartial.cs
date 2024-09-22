using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;

namespace Real_EstateDapper.ViewComponents.AdminLayoutComponents
{
	public class _AdminLayoutSidebarComponentPartial : ViewComponent
	{
		

		public IViewComponentResult Invoke()
		{
		   return View();
		}
	}
}
