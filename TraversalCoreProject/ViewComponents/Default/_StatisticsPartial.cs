﻿using DataAccessLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace TraversalCoreProject.ViewComponents.Default
{
    public class _StatisticsPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            using var c=new Context();
            ViewBag.v1 = c.Destinations.Count();
            ViewBag.v2=c.Guides.Count();
            ViewBag.v3 = "500";
            return View();
        }
    }
}
