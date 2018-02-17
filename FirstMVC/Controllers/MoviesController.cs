using FirstMVC.Models;
using FirstMVC.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.Entity;


namespace FirstMVC.Controllers
{
    public class MoviesController : Controller
    {
        private ApplicationDbContext _context;

        public MoviesController()
        {
            _context = new ApplicationDbContext();
        }

        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }

        public ViewResult Index()
        {
            var movies = _context.Movies.Include(c => c.MovieGenre).ToList();

            return View(movies);    
        }

        public ActionResult Details(int id)
        {
            var movie = _context.Movies.Include(c => c.MovieGenre).SingleOrDefault(c => c.Id == id);
            if (movie == null)
                return HttpNotFound();
            return View(movie);
        }

        public ActionResult New()
        {
            var movieGenres = _context.MovieGenre.ToList();
            var viewModel = new NewMovieViewModel
            {
                MovieGenres = movieGenres
            };
            return View("New",viewModel);
        }

        [HttpPost]
        public ActionResult Save(Movie movie)
        {
            if (!ModelState.IsValid)
            {
                var viewModel = new NewMovieViewModel
                {
                    Movie = movie,
                    MovieGenres = _context.MovieGenre.ToList()
                };
                return View("New", viewModel);
            }
            if(movie.Id == 0)
                _context.Movies.Add(movie);
            else
            {
                var movieInDb = _context.Movies.Single(c => c.Id == movie.Id);
                movieInDb.Name = movie.Name;
                movieInDb.ReleaseDate = movie.ReleaseDate;
                movieInDb.DateAdded = movie.DateAdded;
                movieInDb.InStock = movie.InStock;
                movieInDb.MovieGenreId = movie.MovieGenreId;
            }
             _context.SaveChanges();

             return RedirectToAction("Index", "Movies");
            
        }

        public ActionResult Edit(int id)
        {
            var movie = _context.Movies.SingleOrDefault(c => c.Id == id);
            if (movie == null)
                return HttpNotFound();

            var viewModel = new NewMovieViewModel
            {
                Movie = movie,
                MovieGenres = _context.MovieGenre.ToList()
            };
            return View("New", viewModel);
        }

       
       

       

        
    }
}