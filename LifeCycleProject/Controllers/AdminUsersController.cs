using Microsoft.AspNetCore.Mvc;

namespace LifeCycleProject.Controllers
{
    public class AdminUsersController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
