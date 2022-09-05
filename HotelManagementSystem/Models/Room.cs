using System.ComponentModel.DataAnnotations;

namespace HotelManagementSystem.Models
{
    public class Room
    {
        [Key]
        [Required]
        [RegularExpression(@"R-[1-9]")]
        public string RoomName { get; set; }
        [Range(1, 4)]
        public int Capacity { get; set; }
        [RegularExpression(@"AC|Non-AC")]
        [MaxLength(6)]
        [Required]
        public string Type { get; set; }
        public int Fair { get; set; }
        [Required]
        public bool IsBooked { get; set; }
    }
}
