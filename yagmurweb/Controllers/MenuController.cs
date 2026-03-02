using Microsoft.AspNetCore.Mvc;

namespace yagmurweb.Controllers
{
    public class MenuController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
