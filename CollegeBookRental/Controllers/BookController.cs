using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using System.Web.Razor;
using CollegeBookRental.Models;
using CollegeBookRental.ViewModel;

namespace CollegeBookRental.Controllers
{
    public class BookController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: Book
        public ActionResult Index()
        {
            //db.Books.Include links the Genre and Book tables. They are connected by the Genre Id. 
            var books = db.Books.Include(b => b.Genre);
            //The books object is converting to a List and returning it to the view. 
            return View(books.ToList());
        }

        // GET: Book/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Book book = db.Books.Find(id);
            if (book == null)
            {
                return HttpNotFound();
            }

            //This will add the view model.
            var model = new BookViewModel
            {
                Book = book,
                Genres = db.Genres.ToList()
            };


            //Returns the model object to the view, which has all the Book and Genre properties. 
            return View(model);
        }

        // GET: Book/Create
        public ActionResult Create()
        {
            //The ViewBag.GenreId was deleted and replaced with the BookViewModel
            var genre = db.Genres.ToList();
            var model = new BookViewModel
            {
                Genres = genre
            };
            return View(model);
        }

        // POST: Book/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]

        //I deleted [Bind(Include = "Id,ISBN,Title,Author,Description,ImageUrl,Availability,Price,DateAdded,GenreId,PublicationDate,Pages,ProductDimensions")
        //because these properties should not be hard-coded. This was generated code. 
        //BookViewModel will be passed in, and create BookViewModel into an object. 
        public ActionResult Create(BookViewModel bookVM)
        {
            var book = new Book
            {
                Author = bookVM.Book.Author,
                Availbility = bookVM.Book.Availbility,
                DateAdded = bookVM.Book.DateAdded,
                Genre = bookVM.Book.Genre,
                GenreId = bookVM.Book.GenreId,
                ImageUrl = bookVM.Book.ImageUrl,
                ISBN = bookVM.Book.ISBN,
                Pages = bookVM.Book.Pages,
                Price = bookVM.Book.Price,
                ProductDimensions = bookVM.Book.ProductDimensions,
                Title = bookVM.Book.Title
            };

            if (ModelState.IsValid)
            {
                db.Books.Add(book);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            //I want to avoid ViewBags and replace them with ViewModels which is a collection of models, so that model can be associated with that view. 

            bookVM.Genres = db.Genres.ToList();
            return View(bookVM);
        }

        // GET: Book/Edit/5
        //
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Book book = db.Books.Find(id);
            if (book == null)
            {
                return HttpNotFound();
            }
            //I removed the ViewBag and replaced it with the book object.
            var model = new BookViewModel
            {
                Book = book,
                Genres = db.Genres.ToList()

            };
            return View(model);
        }

        // POST: Book/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(BookViewModel bookVM)
        {
            //I am converting BookViewModel into book.
            var book = new Book
            {
                //I need to include Id for the Edit message, so the new book has a unique Id.
                Id = bookVM.Book.Id,
                Author = bookVM.Book.Author,
                Availbility = bookVM.Book.Availbility,
                DateAdded = bookVM.Book.DateAdded,
                Genre = bookVM.Book.Genre,
                GenreId = bookVM.Book.GenreId,
                ImageUrl = bookVM.Book.ImageUrl,
                ISBN = bookVM.Book.ISBN,
                Pages = bookVM.Book.Pages,
                Price = bookVM.Book.Price,
                ProductDimensions = bookVM.Book.ProductDimensions,
                Title = bookVM.Book.Title
            };
            if (ModelState.IsValid)
            {
                db.Entry(book).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            //The ViewBag was deleted.
            //   bookVM.Genres = db.Genres.ToList(); will only be called if the ModelState is not Valid.
            bookVM.Genres = db.Genres.ToList();
            return View(book);
        }

        // GET: Book/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Book book = db.Books.Find(id);
            if (book == null)
            {
                return HttpNotFound();
            }
            var model = new BookViewModel
            {
                Book = book,
                Genres = db.Genres.ToList()

            };
            return View(model);
        }

        // POST: Book/Delete/5
        //The ActionName("Delete") is needed to avoid confusion by MVC. 
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Book book = db.Books.Find(id);
            db.Books.Remove(book);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
