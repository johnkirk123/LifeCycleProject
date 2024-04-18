using Microsoft.AspNetCore.Mvc;

namespace LifeCycleProject.Controllers
{
    public class NotifcationsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
