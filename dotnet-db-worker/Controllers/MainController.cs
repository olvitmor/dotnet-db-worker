using Microsoft.AspNetCore.Mvc;

namespace dotnet_db_worker.Controllers
{
    public class MainController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
