using System.ComponentModel.DataAnnotations;

namespace CinemaWeb.Models
{
    public class Order
    {
        [Key]
        public int Id { get; set; }
        public Ticket Tickets { get; set; }
        public double Price { get; set; }
    }
}
