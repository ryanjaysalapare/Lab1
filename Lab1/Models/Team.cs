using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Runtime.InteropServices;

namespace Lab1.Models
{
    public class Team
    {
        [Key]
        public Guid Id { get; set; }

        [Required]
        public string TeamName { get; set; } = String.Empty;

        [Required]
        public string Email { get; set; } = String.Empty;

        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:yyyy/MM/dd}")]
        public DateTimeOffset? EstablishedDate { get; set; } = DateTimeOffset.Now;
    }
}