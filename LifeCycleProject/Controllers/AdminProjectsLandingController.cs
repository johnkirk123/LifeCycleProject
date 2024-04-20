using Microsoft.AspNetCore.Mvc;

namespace LifeCycleProject.Controllers
{
    public class AdminProjectsLandingController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
