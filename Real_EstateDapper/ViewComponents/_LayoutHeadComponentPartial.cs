﻿using Microsoft.AspNetCore.Mvc;

namespace Real_EstateDapper.ViewComponents
{
    public class _LayoutHeadComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
