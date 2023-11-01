using Microsoft.AspNetCore.Mvc;

namespace HotelProject.WebUI.Controllers
{
    public class AdminLayoutController : Controller
    {
        public IActionResult _AdminLayout()
        {
            return View();
        }
        public PartialViewResult HeadPartial()
        {
            return PartialView();
        }
        public PartialViewResult PreLoaderPartialPartial()
        {
            return PartialView();
        }
        public PartialViewResult NavHeaderPartialPartial()
        {
            return PartialView();
        }
        public PartialViewResult HeaderPartialPartial()
        {
            return PartialView();
        }
        public PartialViewResult SidebarPartialPartial()
        {
            return PartialView();
        }
        public PartialViewResult FooterPartialPartial()
        {
            return PartialView();
        }
        public PartialViewResult ScriptPartialPartial()
        {
            return PartialView();
        }
    }
}
