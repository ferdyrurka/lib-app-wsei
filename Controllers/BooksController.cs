using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using lib_app_wsei.Models;

namespace lib_app_wsei.Controllers
{
    public class BooksController : Controller
    {
        public IActionResult Random()
        {
            Book firstBook = new Book() { Name = "English dictionary"};
            return View(firstBook);
        }
        
        
        public IActionResult Edit(int bookId)
        {
            return Content("BookId=" + bookId);
        }

        [Route("books/released/{year:regex(^\\d{{4}}$)}/{month:range(1, 12)}")]
        public IActionResult ByReleaseDate(int year, int month)
        {
            return Content(year + " / " + month);
        }
        
        public IActionResult Index(int? pageIndex, string sortBy)
        {
            if (!pageIndex.HasValue)
            {
                pageIndex = 1;
            }

            if (String.IsNullOrEmpty(sortBy))
            {
                sortBy = "Name";
            }

            return Content($"pageIndex={pageIndex}&sortBy={sortBy}");
        }
    }
}
