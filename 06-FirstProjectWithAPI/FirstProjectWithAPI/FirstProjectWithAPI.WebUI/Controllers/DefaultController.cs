using Microsoft.AspNetCore.Mvc;

namespace FirstProjectWithAPI.WebUI.Controllers
{
    public class DefaultController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
