using Microsoft.AspNetCore.Mvc;

namespace dotnet_db_learning.Controllers
{
    public class MainController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
