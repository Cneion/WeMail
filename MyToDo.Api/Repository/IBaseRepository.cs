using System.Collections.Generic;
using System.Threading.Tasks;

namespace MyToDo.Api.Repository
{
    public interface IBaseRepository<TEntity> where TEntity : class
    {
        Task<bool> CreateAsync(TEntity entity);
        Task<bool> DeleteAsync(int id);
        Task<TEntity> GetByIdAsync(int id);
        Task<bool> EditAsync(int id, TEntity entity);
        Task<IEnumerable<TEntity>> GetAllAsync();
    }
}
