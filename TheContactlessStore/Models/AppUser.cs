using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using TheContactlessStore.Models;

namespace TheContactlessStore.Models
{
    public class AppUser : IdentityUser
    {
        [Required]
        public string FirstName { get; set; } = string.Empty;
        [Required]
        public string LastName { get; set; } = string.Empty;
        
        [Required]
        [ForeignKey("UserType")]
        public int UserTypeID { get; set; }
        public UserType? TimeZone { get; set; }
    }
}
