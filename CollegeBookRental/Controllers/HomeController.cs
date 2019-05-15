using CollegeBookRental.Extensions;
using CollegeBookRental.Models;
using CollegeBookRental.ViewModel;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;

namespace CollegeBookRental.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index(string search = null)
        {
            IEnumerable<ThumbnailModel> thumbnails = new List<ThumbnailModel>().GetBookThumbnail(ApplicationDbContext.Create(), search);
            int count = thumbnails.Count() / 4;
            List<ThumbNailBoxViewModel> model = new List<ThumbNailBoxViewModel>();

            for (int i = 0; i <= count; i++)
            {
                //(i*4) will take a count of 4 Thumbnails and add them to the model which is passed into the view. 
                model.Add(new ThumbNailBoxViewModel
                {
                    Thumbnails = thumbnails.Skip(i * 4).Take(4)
                });


            }

            return View(model);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}