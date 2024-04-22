using Microsoft.AspNetCore.Mvc;

namespace LifeCycleProject.Controllers
{
    public class PendingStudentController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
