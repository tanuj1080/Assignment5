using Bookstore.Data;
using Bookstore.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;

namespace Bookstore.Controllers
{
    public class HomeController : Controller
    {
        private readonly bookstoreContext _context;
        public HomeController(bookstoreContext context)
        {
            _context = context;
        }
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

       public async Task<IActionResult> Reviews()
{
    try
    {
        var books = await _context.Books.Select(b => new { b.BookID, b.BookTitle }).ToListAsync();

        // Pass the books list to the view using ViewBag
        ViewBag.BookTitles = books;
        return View();
    }
    catch (Exception ex)
    {
        // Log the exception details here, you can use ILogger or any logging framework
        // For simplicity, this example just returns an error message
        ViewBag.ErrorMessage = "An error occurred while retrieving book data.";
        return View("Error"); // Redirect to an error view or return an error message view
    }
}

        public async Task<IActionResult> GetBookTitleByReviewId(int reviewId)
{
    var bookTitle = await _context.Review
                                  .Where(r => r.ReviewId == reviewId)
                                  .Select(r => r.Book.BookTitle)
                                  .FirstOrDefaultAsync();
    ViewBag.Reviewedbook = bookTitle;
    return View();
}

        public ActionResult Trending()
        {
            return View();
        }
    }
}
