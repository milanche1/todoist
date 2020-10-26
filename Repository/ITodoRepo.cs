using System.Collections.Generic;
using Todoist.Models;

namespace Todoist.Repository
{
    public interface ITodoRepo
    {
        IEnumerable<Todo> GetAllTodos();
        Todo GetTodo(int id);
    }
}