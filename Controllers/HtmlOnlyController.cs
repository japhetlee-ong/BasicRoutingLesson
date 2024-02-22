using Microsoft.AspNetCore.Mvc;

namespace BasicRouting.Controllers
{
    public class HtmlOnlyController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
