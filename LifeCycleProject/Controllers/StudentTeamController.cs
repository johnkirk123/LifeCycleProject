using Microsoft.AspNetCore.Mvc;

namespace LifeCycleProject.Controllers
{
    public class StudentTeamController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
