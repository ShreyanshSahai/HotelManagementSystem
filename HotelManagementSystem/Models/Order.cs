using System.ComponentModel.DataAnnotations;

namespace HotelManagementSystem.Models
{
    public class Order
    {
        [Key]
        public int OrderId { get; set; }
        public int TotalFair { get; set; }

        public string Email { get; set; }
        public User User { get; set; }

        public string RoomName { get; set; }
        public Room Room { get; set; }

        public DateTime CheckIn { get; set; }
        public DateTime CheckOut { get; set; }
    }
}
