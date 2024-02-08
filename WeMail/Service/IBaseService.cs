
using MyToDo.Shared.Contact;
using MyToDo.Shared.Parameters;
using System.Threading.Tasks;

namespace WeMail.Service
{
    public interface IBaseService<TEntity> where TEntity : class
    {
        Task<ApiResponse<TEntity>> AddAsync(TEntity enity);
        Task<ApiResponse<TEntity>> UpdateAsync(TEntity enity);
        Task<ApiResponse> DeleteAsync(int id);
        Task<ApiResponse<TEntity>> GetFirstOfDefaultAsync(int id);
        Task<ApiResponse<PagedList<TEntity>>> GetAllAsync(QueryParameter parameter);
    }
}
