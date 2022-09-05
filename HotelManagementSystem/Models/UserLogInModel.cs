using System.ComponentModel.DataAnnotations;

namespace HotelManagementSystem.Models
{
    public class UserLogInModel
    {
        [Required]
        public string Username { get; set; }
        [MinLength(10)]
        public string Password { get; set; }
        public bool RememberMe { get; set; }
    }
}
