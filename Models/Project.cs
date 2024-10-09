using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;

namespace WebApplication1.Models
{
    public class Project
    {
        [HiddenInput]
        public int ProjectId { get; set; }

        [Required]
        [StringLength(100)]
        public string? Name { get; set; }

        public string? Description { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0: dd.MM.yy}")]
        public DateTime CreatedAt { get; set; } = DateTime.Now;

        [DataType(DataType.Date)]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0: dd.MM.yy}")]
        public DateTime? UpdatedAt { get; set; }
        public string? OwnerId { get; set; }
        public IdentityUser? Owner { get; set; }

        public ICollection<Task> Tasks { get; set; } = new List<Task>();
    }
}
