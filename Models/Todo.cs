using System.ComponentModel.DataAnnotations;

namespace Todoist.Models
{
    public class Todo
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Task { get; set; }
    }
}