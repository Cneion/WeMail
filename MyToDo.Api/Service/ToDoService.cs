using MyToDo.Api.Model;
using MyToDo.Api.Repository;
using System.Threading.Tasks;

namespace MyToDo.Api.Service
{
    public class ToDoService : IToDoService
    {
        private ITodoRepository<ToDo> todoRepository;

        public ToDoService(ITodoRepository<ToDo> todoRepository)
        {
            this.todoRepository = todoRepository;
        }

        public async Task<APIResult> Create(ToDo entity)
        {
            var b = await todoRepository.CreateAsync(entity);
            if (!b) return APIResultHelper.Error("创建失败");
            return APIResultHelper.Success(entity);
        }

        public async Task<APIResult> Delete(int id)
        {
            var b = await todoRepository.DeleteAsync(id);
            if (!b) return APIResultHelper.Error("删除失败");
            return APIResultHelper.Success(null);
        }

        public async Task<APIResult> Edit(int id, ToDo entity)
        {
            var b = await todoRepository.EditAsync(id, entity);
            if (!b) return APIResultHelper.Error("修改失败");
            return APIResultHelper.Success(entity);
        }

        public async Task<APIResult> GetAll()
        {
            var all = await todoRepository.GetAllAsync();
            if (all == null) return APIResultHelper.Error("获取全部失败");
            return APIResultHelper.Success(all);
        }

        public Task GetAllAsync()
        {
            throw new System.NotImplementedException();
        }

        public async Task<APIResult> GetById(int id)
        {
            var b = await todoRepository.GetByIdAsync(id);
            if (b == null) return APIResultHelper.Error("查找失败");
            return APIResultHelper.Success(b);
        }
    }
}
