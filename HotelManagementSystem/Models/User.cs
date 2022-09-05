using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace HotelManagementSystem.Models
{
    public class User : IdentityUser
    {
        [Required]
        public string Name { get; set; }
        [Required]
        public string IdProof { get; set; }
        [Required]
        public string Gender { get; set; }
    }
}
