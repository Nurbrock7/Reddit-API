using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Reddit_API.Models;
using Reddit_API.ViewModel;
using System.Linq;
using DbContext = Reddit_API.Models.DbContext;

namespace Reddit_API.Controllers
{
    public class PostsController : Controller
    {
        private DbContext db = new DbContext();
        public IActionResult Index(int id)
        {
            var model = new PostViewModel();
            model.topic = db.Topics.FirstOrDefault(topic => topic.TopicId == id);
            model.Posts = db.Posts.Include(posts => posts.TopicId).Where(topics => topics.TopicId == id).ToList();
            return View(model);
        }

        [Authorize]
        public IActionResult Create()
        {
            ViewBag.TopicId = new SelectList(db.Topics, "TopicId", "Name");
            return View();
        }

        [HttpPost]
        public IActionResult Create(Post post)
        {
            db.Posts.Add(post);
            db.SaveChanges();
            return RedirectToAction("Create");
        }
    }
}
