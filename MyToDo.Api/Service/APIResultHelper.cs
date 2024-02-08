namespace MyToDo.Api.Service
{
    public static class APIResultHelper
    {
        public static APIResult Success(dynamic data)
        {
            return new APIResult
            {
                Status = 200,
                Data = data,
            };
        }
        public static APIResult Error(string message)
        {
            return new APIResult
            {
                Status = 400,
                Data = null,
                Message = message
            };
        }
    }
}
