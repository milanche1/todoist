using AutoMapper;
using Todoist.Models;

namespace Todoist.Profiles
{
    public class TodosProfile : Profile
    {
        public TodosProfile()
        {
            CreateMap<Todo, TodoDto>();
        }
    }
}