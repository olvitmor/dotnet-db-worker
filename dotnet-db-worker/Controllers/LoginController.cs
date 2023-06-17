using dotnet_db_worker.Models;
using Microsoft.AspNetCore.Mvc;

namespace dotnet_db_worker.Controllers
{
    public class LoginController : Controller
    {
        #region Views
        private const string _indexView = "Index";
        #endregion

        #region Fields
        private ILogger<LoginController> _logger;
        #endregion

        #region Constructor
        public LoginController(ILogger<LoginController> logger)
        {
            _logger = logger;
        }
        #endregion

        #region Actions
        public IActionResult Index()
        {
            return View(_indexView);
        }

        [HttpPost]
        public IActionResult Login(LoginModel data)
        {
            return RedirectToAction("Index");
        }

        public IActionResult LoginFailed()
        {
            return View(_indexView);
        }
        #endregion
    }
}
