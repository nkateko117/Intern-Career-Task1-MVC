using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace TheContactlessStore.Models
{
    public class UserType
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int UserTypeId { get; set; }
        [Required]
        public string UserTypeName { get; set; } = string.Empty;
    }
}