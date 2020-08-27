using System.Collections.Generic;
using BlogSite.Models;
namespace BlogSite.ViewModels
{
    public class UserList
    {
        public List<User> mockUsers = new List<User> ();
        public UserList()
        {
            this.mockUsers.Add(new User("User", "One", "user1", "This is User One!", new List<Blog>(){new Blog("My First Blog Post", "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua.")}, true));

            this.mockUsers.Add(new User("User", "Two", "user2", "This is User Two!", new List<Blog>(){new Blog("Welcome to My Blog", " Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat.")}, false));
        }
    }
}