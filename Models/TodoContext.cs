using Microsoft.EntityFrameworkCore;

namespace Todoist.Models
{
    public class TodoContext : DbContext
    {
        public TodoContext(DbContextOptions<TodoContext> opt) : base(opt)
        {

        }

        public DbSet<Todo> Todos { get; set; }
    }
}