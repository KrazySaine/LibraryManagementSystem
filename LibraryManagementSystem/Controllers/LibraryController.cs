using LibraryManagementSystem.Models;
using Microsoft.AspNetCore.Mvc;

namespace LibraryManagementSystem.Controllers
{
    public class LibraryController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public ActionResult displayBooks()
        {
            var model = new List< Book>();
            model.Add(new Book { Title = "" });
            model.Add(new Book { Author = "" });
            return View(model);

        }
    }
}
