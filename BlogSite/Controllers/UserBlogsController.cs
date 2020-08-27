using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using BlogSite.Models;
using BlogSite.ViewModels;
using System.Linq;

namespace BlogSite.Controllers
{
    public class UserBlogs : Controller
    {
        // create mock list of users from view model
        public UserList userList = new UserList();
        // landing page
        public IActionResult Index()
        {
            return View();
        }
        // pass mock list of users to specific view
        public IActionResult AllUsers()
        {
            ViewData["PageHeader"] = "All Users";
            return View("DisplayUsers", userList);
        }
        // pass filtered list of users to specific view
        public IActionResult HighlightedUsers()
        {
            ViewData["PageHeader"] = "Highlighted Users";

            // filter highlighted users from list of mock users
            List<User> filterHighlighted = userList.mockUsers.Where(user => user.highlighted == true).ToList();
            userList.mockUsers = filterHighlighted;

            return View("DisplayUsers", userList);
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