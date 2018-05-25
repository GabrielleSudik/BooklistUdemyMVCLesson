using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using BooklistUdemyMVCLesson.Models;

namespace BooklistUdemyMVCLesson.Controllers
{
    public class BooksController : Controller
    {

        private readonly ApplicationDbContext _db;

        public BooksController(ApplicationDbContext db)
        {
            _db = db;
        }

        public IActionResult Index()
        {
            return View(_db.Books.ToList());
        }

        protected override void Dispose (bool disposing)
        {
            if (disposing)
            {
                _db.Dispose();
            }
        }
    }
}