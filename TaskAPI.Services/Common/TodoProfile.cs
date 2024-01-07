using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskAPI.Models;
using TaskAPI.Services.Model;

namespace TaskAPI.Services
{
    public class TodoProfile : Profile
    {
        public TodoProfile()
        {
            CreateMap<Todo, TodoDto>();
            CreateMap<CreateTodoDto, Todo>().ReverseMap();
        }
    }
}
