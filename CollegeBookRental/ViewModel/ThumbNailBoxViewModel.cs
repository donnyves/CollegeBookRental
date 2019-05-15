using CollegeBookRental.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;


//The IEnumerable allow me to add more thumbnails. There will be a direct association with a view model with the view. 
namespace CollegeBookRental.ViewModel
{
    public class ThumbNailBoxViewModel
    {
        public IEnumerable <ThumbnailModel> Thumbnails { get; set; }
    }
}