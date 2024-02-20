using Microsoft.AspNetCore.Mvc;
using VueApp.Server.ViewModels;

namespace VueApp.Server.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TodoController : ControllerBase
    {
        private readonly ILogger<TodoController> _logger;

        public TodoController(ILogger<TodoController> logger)
        {
            _logger = logger;
        }

        [HttpGet(Name = "GetTodo")]
        public IEnumerable<TodoViewModel> Get()
        {
            return Enumerable.Range(1, 15).Select(index => new TodoViewModel
            {
                IsDeleted = false,
                Start = false,
                Description = "Cras justo odio, dapibus ac facilisis in, egestas eget quam. Donec id elit non mi porta gravida at eget metus. Nullam id dolor id nibh ultri...",
                ImagePath= "",
                Title = "Task title " + index
            }).ToArray();
        }
    }
}
