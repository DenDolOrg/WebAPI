using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebAPI_test.Models.Abstract;
using WebAPI_test.Models;

namespace WebAPI_test.Controllers
{
    public class HomeController : Controller
    {
        private ICommentRepository _repository;

        public HomeController(ICommentRepository repository)
        {
            _repository = repository;
        }
        public ActionResult Index()
        {
            int count = _repository.CommentList.Count() + 1;
            _repository.AddComment(new Comment()
            {
                Autor = "Autor" + count,
                Text = "Text" + +count
            });

            ViewBag.Title = "Home Page";
            return View(_repository.CommentList.AsEnumerable());
        }
    }
}
