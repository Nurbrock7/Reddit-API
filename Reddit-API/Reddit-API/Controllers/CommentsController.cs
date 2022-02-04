using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Reddit_API.Models;
using Reddit_API.ViewModel;
using System.Linq;

namespace Reddit_API.Controllers
{
    public class CommentsController : Controller
    {
        private DbContext db = new DbContext();
        public IActionResult Index(int id)
        {
            var model = new CommentsViewModel();
            model.Comments = db.Comments.Include(comments => comments.Post).Where(posts => posts.PostId == id).ToList();
            return View(model);
        }

        [HttpPost]
        public IActionResult NewComment(string newText, string newUser, int PostId)
        {
            Post foundProduct = db.Posts.FirstOrDefault(model => model.PostId == PostId);
            comment newComment = new Comment(newText, newUser)
            {
                Post = foundProduct,
                PostId = PostId
            };

            db.Comments.Add(newComment);
            db.SaveChanges();
            return Json(newComment);
        }
    }
}
