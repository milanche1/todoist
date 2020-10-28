using System.ComponentModel.DataAnnotations;

namespace Todoist
{
    public class TodoDto
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Task { get; set; }
    }
}