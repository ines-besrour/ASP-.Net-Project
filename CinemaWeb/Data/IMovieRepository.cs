
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;
using CinemaWeb.Data;
using CinemaWeb.Models;

namespace CinemaWeb.Data
{
    public interface IMovieRepository<T> where T : class
    {
        T Get(int id); IEnumerable<T> GetAll();
        IEnumerable<T> Find(Expression<Func<T, bool>> predicate);
        IEnumerable<string> GetMovies();
    }
    public class MovieRepository : IMovieRepository<Movie>
    {
        private readonly CinemaContext cinemaContext;
        public MovieRepository(CinemaContext cinemaContext)
        {
            this.cinemaContext = cinemaContext;
        }

        public IEnumerable<Movie> Find(Expression<Func<Movie, bool>> predicate)
        {
            try
            {
                return cinemaContext.Set<Movie>().Where(predicate);

            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        public Movie Get(int id)
        {
            try
            {

                return cinemaContext.Set<Movie>().Find(id);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public IEnumerable<Movie> GetAll()
        {
            try
            {
                return cinemaContext.Set<Movie>().ToList();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        public IEnumerable<String> GetMovies()
        {
            return cinemaContext.Movie.Select(s => s.Name).Distinct().ToList();
        }
    }
}