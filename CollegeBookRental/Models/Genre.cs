using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CollegeBookRental.Models
{
    public class Genre
    {
        //add System.ComponentModel.DataAnnotation to use [Required].
        [Required]
        public int Id { get; set; }

        [Required]
        //We have to add the System.ComponenModel for [DisplayName()] to Display Genre Name.
        [DisplayName("Genre Name")]
        public string Name { get; set; }

    }
}