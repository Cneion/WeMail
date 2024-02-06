namespace MyToDo.Api.Repository
{
    public interface ITodoRepository<TEnity> : IBaseRepository<TEnity> where TEnity : class
    {
    }
}
