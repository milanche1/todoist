using System.Collections.Generic;
using Todoist.Models;
using Todoist.Repository;

namespace Todoist
{
    public class MockTodoRepo : ITodoRepo
    {
        public IEnumerable<Todo> GetAllTodos()
        {
            var tasks = new List<Todo>
            {
                new Todo {Id=0, Task="Get a job"},
                new Todo {Id=1, Task="Get a degree"},
                new Todo {Id=2, Task="Learn C#"}
            };

            return tasks;
        }

        public Todo GetTodo(int id)
        {
            return new Todo { Id = 2, Task = "Learn C#" };

        }
    }
}