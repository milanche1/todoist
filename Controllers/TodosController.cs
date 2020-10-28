using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using Todoist.Models;
using Todoist.Repository;

namespace Todoist.Controllers
{
    [Route("api/todos")]
    [ApiController]
    public class TodosController : ControllerBase
    {
        private readonly ITodoRepo _repository;

        public TodosController(ITodoRepo repository)
        {
            _repository = repository;
        }

        [HttpGet]
        public ActionResult<IEnumerable<Todo>> GetAllTodos()
        {
            var tasks = _repository.GetAllTodos();
            return Ok(tasks);
        }

        [HttpGet("{id}")]
        public ActionResult<Todo> GetTodo(int id)
        {
            var task = _repository.GetTodo(id);
            if (task != null)
            {
                return Ok(task);
            }

            return NotFound();
        }
    }
}