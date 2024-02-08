using MyToDo.Api.Service;
using MyToDo.Shared.Contact;
using MyToDo.Shared.Parameters;
using System.Threading.Tasks;

namespace WeMail.Service
{
    public class BaseService<TEntity> : IBaseService<TEntity> where TEntity : class
    {
        private readonly HttpRestClient client;
        private readonly string serviceName;

        public BaseService(HttpRestClient client, string serviceName)
        {
            this.client = client;
            this.serviceName = serviceName;
        }

        public async Task<APIResult<TEntity>> AddAsync(TEntity entity)
        {
            BaseRequest request = new BaseRequest();
            request.Method = RestSharp.Method.POST;
            request.Route = $"api/{serviceName}/Add";
            request.Parameter = entity;
            return await client.ExcuteAsync<TEntity>(request);
        }

        public async Task<APIResult> DeleteAsync(int id)
        {
            BaseRequest request = new BaseRequest();
            request.Method = RestSharp.Method.DELETE;
            request.Route = $"api/{serviceName}/Delete?id={id}";
            return await client.ExcuteAsync(request);
        }

        public async Task<APIResult<PagedList<TEntity>>> GetAllAsync(QueryParameter parameter)
        {
            BaseRequest request = new BaseRequest();
            request.Method = RestSharp.Method.GET;
            request.Route = $"api/{serviceName}/GetAll?pageIndex={parameter.PageIndex}" + $"&pageSize={parameter.PageSize}" + $"&search={parameter.Search}";
            return await client.ExcuteAsync<PagedList<TEntity>>(request);
        }

        public async Task<APIResult<TEntity>> GetFirstOfDefaultAsync(int id)
        {
            BaseRequest request = new BaseRequest();
            request.Method = RestSharp.Method.GET;
            request.Route = $"api/{serviceName}/Get?id={id}";
            return await client.ExcuteAsync<TEntity>(request);
        }

        public async Task<APIResult<TEntity>> UpdateAsync(TEntity entity)
        {
            BaseRequest request = new BaseRequest();
            request.Method = RestSharp.Method.POST;
            request.Route = $"api/{serviceName}/Update";
            request.Parameter = entity;
            return await client.ExcuteAsync<TEntity>(request);
        }
    }
}
