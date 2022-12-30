using System.ComponentModel.DataAnnotations;

namespace CinemaWeb.Models
{
    public class MovieDisplay
    {
        [Key]
        public int Id { get; set; }
        public Movie Movie { get; set; }
        public Room Room { get; set; }
        public DateTime Date { get; set; }
        public double Price { get; set; }

    }
}
