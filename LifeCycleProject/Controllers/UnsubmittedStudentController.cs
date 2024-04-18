using Microsoft.AspNetCore.Mvc;

namespace LifeCycleProject.Controllers
{
    public class UnsubmittedStudentController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
