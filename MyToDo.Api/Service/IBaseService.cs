using System.Threading.Tasks;

namespace MyToDo.Api.Service
{
    public interface IBaseService<TEntity> where TEntity : class
    {
        Task<APIResult> Create(TEntity entity);
        Task<APIResult> Delete(int id);
        Task<APIResult> Edit(int id, TEntity entity);
        Task<APIResult> GetById(int id);
        Task<APIResult> GetAll();
    }
}
