using Microsoft.AspNetCore.Mvc;

namespace LifeCycleProject.Controllers
{
    public class AdminTeamController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
