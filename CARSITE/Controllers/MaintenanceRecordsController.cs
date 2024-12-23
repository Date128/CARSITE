using Microsoft.AspNetCore.Mvc;

namespace CARSITE.Controllers
{
    public class MaintenanceRecordsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
