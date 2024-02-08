using MyToDo.Api.Service;
using Newtonsoft.Json;
using RestSharp;
using System;
using System.Threading.Tasks;

namespace WeMail.Service
{
    public class HttpRestClient
    {
        private readonly string apiurl;
        protected readonly RestClient client;

        public HttpRestClient(string apiurl)
        {
            this.apiurl = apiurl;
            client = new RestClient();
        }
        public async Task<APIResult> ExcuteAsync(BaseRequest baseRequest)
        {
            var request = new RestRequest(apiurl + baseRequest.Route,baseRequest.Method);
            request.AddHeader("Content-type", baseRequest.ContentType);
            if (baseRequest.Parameter != null)
            {
                request.AddParameter("param", JsonConvert.SerializeObject(baseRequest.Parameter), ParameterType.RequestBody);
            }
            client.BaseUrl = new Uri(apiurl + baseRequest.Route);
            var response = await client.ExecuteAsync(request);
            return JsonConvert.DeserializeObject<APIResult>(response.Content);
        }

        public async Task<APIResult<T>> ExcuteAsync<T>(BaseRequest baseRequest)
        {
            var request = new RestRequest(apiurl + baseRequest.Route,baseRequest.Method);
            request.AddHeader("Content-type", baseRequest.ContentType);
            if (baseRequest.Parameter != null)
            {
                request.AddParameter("param", JsonConvert.SerializeObject(baseRequest.Parameter), ParameterType.RequestBody);
            }
            client.BaseUrl = new Uri(apiurl + baseRequest.Route);
            var response = await client.ExecuteAsync(request);
            return JsonConvert.DeserializeObject<APIResult<T>>(response.Content);
        }

    }
}
