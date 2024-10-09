using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace WebApplication1.Models
{
    public class Task
    {
        public int TaskId { get; set; }

        [Required]
        [StringLength(100)]
        public string? Title { get; set; }

        public string? Description { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0: dd.MM.yy}")]
        public DateTime DueDate { get; set; }

        public bool IsCompleted { get; set; } = false;

        [DataType(DataType.Date)]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0: dd.MM.yy}")]
        public DateTime? UpdatedAt { get; set; }

        public int ProjectId { get; set; }
        public Project? Project { get; set; }

        public string? AssignedUserId { get; set; }
        public IdentityUser? AssignedUser { get; set; }
    }
}
