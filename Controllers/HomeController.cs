using Bookstore.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Bookstore.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            return View();
        }

        public ActionResult Books()
        {
            return View();
        }

        public ActionResult Reviews()
        {
            return View();
        }

        public ActionResult Trending()
        {
            return View();
        }
    }
}
