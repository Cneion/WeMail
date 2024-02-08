using MyToDo.Api.Service;
using MyToDo.Shared.Contact;
using MyToDo.Shared.Parameters;
using System.Threading.Tasks;

namespace WeMail.Service
{
    public interface IBaseService<TEntity> where TEntity : class
    {
        Task<APIResult<TEntity>> AddAsync(TEntity enity);
        Task<APIResult<TEntity>> UpdateAsync(TEntity enity);
        Task<APIResult> DeleteAsync(int id);
        Task<APIResult<TEntity>> GetFirstOfDefaultAsync(int id);
        Task<APIResult<PagedList<TEntity>>> GetAllAsync(QueryParameter parameter);
    }
}
