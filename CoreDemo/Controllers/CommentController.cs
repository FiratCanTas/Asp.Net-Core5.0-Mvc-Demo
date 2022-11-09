using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace CoreDemo.Controllers
{
	public class CommentController : Controller
	{
        CommentManager cm = new CommentManager(new EfCommentRepository());
        public IActionResult Index()
		{
			return View();
		}

		public PartialViewResult AddCommentPartial()
		{
			return PartialView();
		}
        public PartialViewResult CommentListByBlogPartial(int id)
        {
			var values = cm.GetList(id);
            return PartialView(values);
        }
    }
}
