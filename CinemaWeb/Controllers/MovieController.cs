using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using CinemaWeb.Data;
using CinemaWeb.Models;
using CinemaWeb.Data;

namespace CinemaWeb.Controllers
{
    public class MovieController : Controller
    {
        public IActionResult Index()
        {
            CinemaContext cinemaContext = CinemaContext.Instantiate_CinemaContext();
            MovieRepository movieRepository = new MovieRepository(cinemaContext);
            foreach (String s in movieRepository.GetMovies())
                Debug.WriteLine(s);

            return View(movieRepository.GetMovies());
        }

/*        public IActionResult GetMovie(string id)
        {
            CinemaContext cinemaContext = CinemaContext.Instantiate_CinemaContext();
            MovieRepository movieRepository = new MovieRepository(cinemaContext);
            IEnumerable<Movie> res = (IEnumerable<Movie>)movieRepository.Find(v => v.Name.ToLower() == id.ToLower());

            if (res.Count() != 0) ViewBag.Id = res.First().Name;
            return View(res);
        } */

    }
}
