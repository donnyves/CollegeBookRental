using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CollegeBookRental.Models
{
    public class Book
    {
        //All the properties and atrribute of a book will be added.
        //[Required]is placed above the property that is essential.
        //To use [Required] you have to add using System.ComponentModel.DataAnnotations;
        [Required]
        public int Id { get; set; }
        [Required]
        public string ISBN { get; set; }
        [Required]
        public string Title { get; set; }
        [Required]
        public string Author { get; set; }
        [Required]
        public string Description { get; set; }

        [Required]
        //You have to use the Datatype class if you want to use a picture.
        //DataType.ImageUrl represents a URL to an image.
        [DataType(DataType.ImageUrl)]
        public string ImageUrl { get; set; }

        [Required]
        //Range of books will not be below zero.
        [Range(0, 1000)]
        public int Availbility { get; set; }

        [Required]
        //To display currency, use DataType.Currency
        [DataType(DataType.Currency)]
        public double Price { get; set; }

        [Required]
        //To make the date format is established.
        [DisplayFormat(DataFormatString = "{0: MMM dd yyyy}")]
        public DateTime? DateAdded { get; set; }

        [Required]
        public int GenreId { get; set; }


        public Genre Genre { get; set; }

        [Required]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0: MMM dd yyyy}")]
        public DateTime PublicationDate { get; set; }

        [Required]
        public int Pages { get; set; }

        [Required]
        public string ProductDimensions { get; set; }


        //I added a new field that will have to be incorporated into my application.
        //So now I have to do a "code first migration. (PM> add-migration AddPublisherToBookModel)then (PM> update-database)
        [Required]
        public string Publisher { get; set; }

    }
}