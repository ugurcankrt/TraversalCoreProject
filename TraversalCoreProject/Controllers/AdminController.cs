using Microsoft.AspNetCore.Mvc;

namespace TraversalCoreProject.Controllers
{
    public class AdminController : Controller
    {
        public PartialViewResult HeaderPartial()
        {
            return PartialView();
        }

        public PartialViewResult AppBrandDemoPartial()
        {
            return PartialView();
        } 
        
        public PartialViewResult SidebarPartial()
        {
            return PartialView();
        }

        public PartialViewResult NavbarPartial()
        {
            return PartialView();
        }

        public PartialViewResult FooterPartial()
        {
            return PartialView();
        }

        public PartialViewResult ScriptsPartial()
        {
            return PartialView();
        }
    }
}
