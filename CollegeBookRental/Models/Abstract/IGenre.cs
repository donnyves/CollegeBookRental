using System.Collections.Generic;
using System;
using System.Linq;
using System.Web.Mvc;

using Moq;


namespace CollegeBookRental.Models.Abstract
{
    public interface IGenre
    {
        IEnumerable<Genre> Genres { get; }
    }
}



