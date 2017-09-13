using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ComicBookGallery2.Data;
using ComicBookGallery2.Models;

namespace ComicBookGallery2.Controllers
{
    public class ComicBookController : Controller
    {
        private ComicBooksRepository _comicBookRepository = null;

        public ComicBookController()
        {
            _comicBookRepository = new ComicBooksRepository();
        }

        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return HttpNotFound();
            }
            var comicBook = _comicBookRepository.GetComicBook((int)id);
            return View(comicBook);
        }
    }
}