using CollegeBookRental.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CollegeBookRental.ViewModel
{
    public class BookViewModel
    {
        //The ViewBag for Genre will not be needed anymore because,
        //all the properties will come from the BookViewModel. 
        public IEnumerable<Genre> Genres { get; set; }
        public Book Book { get; set; }
    }
}