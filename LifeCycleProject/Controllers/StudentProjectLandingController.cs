using Microsoft.AspNetCore.Mvc;

namespace LifeCycleProject.Controllers
{
    public class StudentProjectLandingController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
