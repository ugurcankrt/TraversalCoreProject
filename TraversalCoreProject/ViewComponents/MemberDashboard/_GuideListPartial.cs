using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace TraversalCoreProject.ViewComponents.MemberDashboard
{
    public class _GuideListPartial : ViewComponent
    {
        GuideManager guideManager = new GuideManager(new EfGuideDal());

        public IViewComponentResult Invoke(int id)
        {
            var values = guideManager.TGetList();
            return View(values);
        }
    }
}
