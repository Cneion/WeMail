using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MyToDo.Api.Model;
using MyToDo.Api.Service;
using System.Threading.Tasks;

namespace MyToDo.Api.Controllers {
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class ToDoController : ControllerBase {
        private readonly IToDoService toDoService;

        public ToDoController(IToDoService toDoService) {
            this.toDoService = toDoService;
        }

        [HttpGet]
        public async Task<ActionResult<APIResult>> GetById(int id) => await toDoService.GetById(id);
        [HttpPost]
        public async Task<ActionResult<APIResult>> Create([FromBody] ToDo model) => await toDoService.Create(model);
        [HttpPut]
        public async Task<ActionResult<APIResult>> Edit(int id, [FromBody] ToDo model) => await toDoService.Edit(id, model);
        [HttpDelete]
        public async Task<ActionResult<APIResult>> Delete(int id) => await toDoService.Delete(id);
        [HttpGet]
        public async Task<ActionResult<APIResult>> GetAll() => await toDoService.GetAll();
    }
}
