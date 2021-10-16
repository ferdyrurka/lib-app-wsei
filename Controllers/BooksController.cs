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
        
        
        public IActionResult Edit(int id)
        {
            return Content("Book" + id);
        }
    }
}
