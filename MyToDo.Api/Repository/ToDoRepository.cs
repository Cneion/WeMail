using Microsoft.EntityFrameworkCore;
using MyToDo.Api.Model;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MyToDo.Api.Repository
{
    public class ToDoRepository : ITodoRepository<ToDo>
    {
        private readonly MyToDoDbContext dbctx;

        public ToDoRepository(MyToDoDbContext dbctx)
        {
            this.dbctx = dbctx;
        }

        public async Task<bool> CreateAsync(ToDo entity)
        {
            var todo = await dbctx.ToDos.AddAsync(entity);
            if (todo == null) return false;
            return await dbctx.SaveChangesAsync() > 0;
        }

        public async Task<bool> DeleteAsync(int id)
        {
            var todo = await dbctx.ToDos.FindAsync(id);
            var b = dbctx.ToDos.Remove(todo);
            //if (b == null) return false;
            return await dbctx.SaveChangesAsync() > 0;
        }

        public async Task<bool> EditAsync(int id, ToDo entity)
        {
            var todo = await dbctx.ToDos.FindAsync(id);
            if (todo == null) return false;
            todo.Title = entity.Title;
            todo.UpdateTime = DateTime.Now;
            todo.Status = entity.Status;
            todo.Content = entity.Content;
            dbctx.ToDos.Update(todo);
            return await dbctx.SaveChangesAsync() > 0;
        }

        public async Task<ToDo> GetByIdAsync(int id)
        {
            ToDo todo = await dbctx.ToDos.FindAsync(id);
            if (todo == null) return null;
            return todo;
        }
        public async Task<IEnumerable<ToDo>> GetAllAsync()
        {
            var todos = await dbctx.ToDos.ToListAsync();
            if (todos.Count == 0) return null;
            return todos;
        }
    }
}
