﻿using FirstMVC.Models;
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
            var movies = _context.Movies.ToList();

            return View(movies);    
        }

        public ActionResult Details(int id)
        {
            var movie = _context.Movies.SingleOrDefault(c => c.Id == id);
            if (movie == null)
                return HttpNotFound();
            return View(movie);
        }

        public ActionResult New()
        {
            return View();
        }

        /*private IEnumerable<Movie> GetMovies()
        {
            return new List<Movie>
            {
                new Movie { Id = 1, Name = "Shrek" },
                new Movie { Id = 2, Name = "Wall-e" }
            };
        }*/

        // GET: Movies
        public ActionResult Random()
        {
            var movie = new Movie() {Name = "Shrek"};
            var customers = new List<Customer>
            {
                new Customer {Name = "Customer_1"},
                new Customer {Name = "Customer_2"}
            };

            var viewModel = new RandomMovieViewModel
            {
                Movie = movie,
                Customers = customers
            };

            return View(viewModel);
        }

       

        /*
        public ActionResult Edit(int id)
        {
            return Content("id=" + id);
        }

        public ActionResult Index(int? pageIndex, string sortBy)
        {
            if (!pageIndex.HasValue)
                pageIndex = 1;
            if (String.IsNullOrWhiteSpace(sortBy))
                sortBy = "Name";
            return Content(String.Format("pageIndex={0}&sortBy={1}", pageIndex, sortBy));
            
        }*/

        /*[Route("movies/released/{year}/{month:range(1,12)}")]

        public ActionResult ByReleaseDate(int year, int month)
        {
            return Content(year +"/"+ month);
        }*/
    }
}