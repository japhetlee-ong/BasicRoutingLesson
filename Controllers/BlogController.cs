using Microsoft.AspNetCore.Mvc;

namespace BasicRouting.Controllers
{
    public class BlogController : Controller
    {
        //http://localhost:5152/blog/2024/01/best-practices-for-url-design
        public IActionResult Index(int year,int month, string slug)
        {

            return Content($"The year of the blog is {year} and month is {month} and the slug is {slug}");
        }
    }
}
