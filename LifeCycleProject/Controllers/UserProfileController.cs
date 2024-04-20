using Microsoft.AspNetCore.Mvc;

namespace LifeCycleProject.Controllers
{
    public class UserProfileController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
