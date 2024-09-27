using Microsoft.AspNetCore.Mvc;

namespace BasicInventoryManagementSystem.Controllers.Dashboard
{
    public class DashboardController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
