using CollegeBookRental.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;

namespace CollegeBookRental.Controllers
{
    public class GenreController : Controller
    {
        //Create ApplicationDbContext object, so we can  connect to the database.
        //use CTRL + ., to get the references for ApplicationDbContext.

        private ApplicationDbContext db;

        //Create a constructor
        //ApplicationDbContext now has the object name db.

        public GenreController()
        {
            db = new ApplicationDbContext();
        }

        //We are retrieving Genres from the database and converting them into a list, and passing it to the view.
        //We have to make an action method for Create()
        //We also do not have to pass anything to the View(), because it creates a new Genre.
        //Create() is a Get Action, so we also need to create a Post action

        public ActionResult Index()
        {
            return View(db.Genres.ToList());
        }
        //Get Action
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Genre genre)
        {
            if (ModelState.IsValid)
            {
                db.Genres.Add(genre);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View();
        }
        //This is the Post action for Create, it passes in the Genre object.
        //I also need to validate my token in the Genre/Create.cshtml
        //if the token is validated, the genre object will be added to the database, that was passed from the view.
        //Add to the database by using db.Genres.Add(genre).
        //db.SaveChanges commits these changes.
        //Then we will return RedirectToAction to return the Index.
        //Then we want to display Index view with what was added.


            //Now I have to create an ActionResult named Details
            //if the id is null it will be a bad request,otherwise a new object Genre will be created.
            //if the genre object is null, return an HttpNotFound.  Otherwise return the object genre
            //to the view.
            public ActionResult Details(int? id)
        {
            if(id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Genre genre = db.Genres.Find(id);
            if(genre==null)
            {
                return HttpNotFound();
            }
            return View(genre);
        }



        //This is so I can delocate. 
        protected override void Dispose(bool disposing)
        {
            db.Dispose();
        }
    }
}