using System.ComponentModel.DataAnnotations;

namespace CinemaWeb.Models
{
    public class Movie
    {
        [Key]
        public int Id { get; set; }

        public string Name { get; set; }
        public string Description { get; set; }
        public string ImageURL { get; set; }
        public MovieCategory MovieCategory { get; set; }

        //public MovieDisplay MovieDisplays { get; set; }
    }
}
