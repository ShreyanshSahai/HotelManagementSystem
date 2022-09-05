using System.ComponentModel.DataAnnotations;

namespace HotelManagementSystem.Models
{
    public class UserSignUpModel
    {
        [EmailAddress]
        public string Email { get; set; }
        [Required]
        public string Name { get; set; }
        [Range(7006000000, 9999999999)]
        public string MobileNumber { get; set; }
        [Required]
        public string Username { get; set; }
        [Required]

        public string Password { get; set; }
        [Required]
        public string IdProof { get; set; }
        [Required]
        public string Gender { get; set; }
    }
}
