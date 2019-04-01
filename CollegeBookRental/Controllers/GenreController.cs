using CollegeBookRental.Models;
using System;
using System.Collections.Generic;
using System.Linq;
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
        public GenreController()
        {
            //ApplicationDbContext now has the object name db.
            db = new ApplicationDbContext();
        }
        // 
        public ActionResult Index()
        {
            //We are retrieving Genres from the database and converting them into a list, and passing it to the view.
            return View(db.Genres.ToList ());
        }
        //We have to make an action method for Create()
        //We also do not have to pass anything to the View(), because it's create a new Genre.
        public ActionResult Create()
        {
            return View();
        }


        protected override void Dispose(bool disposing)
        {
            db.Dispose();
        }
    }
}