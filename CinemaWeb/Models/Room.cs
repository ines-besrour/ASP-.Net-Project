using System.ComponentModel.DataAnnotations;

namespace CinemaWeb.Models
{
    public class Room
    {
        [Key]
        public int Id { get; set; }
        public int Capacity { get; set; }
    }
}
