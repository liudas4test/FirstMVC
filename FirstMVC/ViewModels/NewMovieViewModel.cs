using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using FirstMVC.Models;

namespace FirstMVC.ViewModels
{
    public class NewMovieViewModel
    {
        public IEnumerable<MovieGenre> MovieGenres { get; set; }
        public Movie Movie { get; set; }

    }
}