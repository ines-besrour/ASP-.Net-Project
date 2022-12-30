using System.ComponentModel.DataAnnotations;

namespace CinemaWeb.Models
{
    public class Ticket
    {
        [Key]
        public int Id { get; set; }
        public MovieDisplay MovieDisplay { get; set; }
    }
}
