using BasicRouting.Models;
using Microsoft.AspNetCore.Mvc;

namespace BasicRouting.Controllers
{
    public class TodoController : Controller
    {
        public IActionResult Index()
        {
            // Create a list of items
            var items = new List<TodoModel>
            {
                new TodoModel { Name = "Item 1" },
                new TodoModel { Name = "Item 2" },
                new TodoModel { Name = "Item 3" }
            };

            // Pass the list to the view
            return View(items);
        }
    }
}
