using System.Collections.Generic;
namespace BlogSite.Models
{
    public class User
    {
        public string fName;
        public string LName;
        public string userName;
        public string bio;
        public bool highlighted;
        public List<Blog> blogs = new List<Blog>();
        public User(string fName, string LName, string userName, string bio, List<Blog> blogs, bool highlighted)
        {
            this.fName = fName;
            this.LName = LName;
            this.userName = userName;
            this.bio = bio;
            this.blogs = blogs;
            this.highlighted = highlighted;
        }
    }
}