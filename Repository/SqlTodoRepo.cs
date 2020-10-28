using Todoist.Models;
using System.Linq;
using System.Collections.Generic;

namespace Todoist.Repository
{
    public class SqlTodoRepo : ITodoRepo
    {
        private readonly TodoContext _context;

        public SqlTodoRepo(TodoContext context)
        {
            _context = context;
        }

        public IEnumerable<Todo> GetAllTodos()
        {
            return _context.Todos.ToList();
        }

        public Todo GetTodo(int id)
        {
            return _context.Todos.FirstOrDefault(p => p.Id == id);

        }
    }
}