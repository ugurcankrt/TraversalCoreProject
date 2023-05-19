using Microsoft.AspNetCore.Mvc;

namespace TraversalCoreProject.ViewComponents.MemberDashboard
{
    public class _PlatformSettingsPartial:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
