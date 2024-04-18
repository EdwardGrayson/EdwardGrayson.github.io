using Microsoft.AspNetCore.Mvc;

namespace WebAPI.api.Controllers
{
    public class BaseController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
