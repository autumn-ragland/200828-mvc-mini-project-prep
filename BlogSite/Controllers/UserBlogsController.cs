using Microsoft.AspNetCore.Mvc;

namespace BlogSite.Controllers
{
    public class UserBlogs : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult AllUsers()
        {
            ViewData["PageHeader"] = "All Users";
            return View("DisplayUsers");
        }
        public IActionResult HighlightedUsers()
        {
            ViewData["PageHeader"] = "Highlighted Users";
            return View("DisplayUsers");
        }
        public IActionResult UserDetails()
        {
            return View();
        }
        public IActionResult BlogDetails()
        {
            return View();
        }
    }
}