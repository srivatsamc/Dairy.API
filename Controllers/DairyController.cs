using Microsoft.AspNetCore.Mvc;

namespace Dairy.API.Controllers
{
    public class DairyController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
