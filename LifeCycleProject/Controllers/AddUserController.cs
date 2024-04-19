using Microsoft.AspNetCore.Mvc;

namespace LifeCycleProject.Controllers
{
    public class AddUserController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
