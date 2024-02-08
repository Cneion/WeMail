namespace MyToDo.Api.Service
{
    public class APIResult
    {
        public string Message { get; set; }
        public int Status { get; set; }
        public dynamic Data { get; set; }
    }
    public class APIResult<T>
    {
        public string Message { get; set; }
        public int Status { get; set; }
        public T Data { get; set; }
    }
}
