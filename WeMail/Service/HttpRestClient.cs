using MyToDo.Api.Service;
using MyToDo.Shared.Contact;
using Newtonsoft.Json;
using RestSharp;
using RestSharp.Authenticators;
using System;
using System.Threading.Tasks;
using ApiResponse = MyToDo.Shared.Contact.ApiResponse;

namespace WeMail.Service {
    public class HttpRestClient {
        private readonly string apiurl;
        protected readonly RestClient client;

        public HttpRestClient(string apiurl) {
            this.apiurl = apiurl;
            client = new RestClient();
        }
        public async Task<ApiResponse> ExcuteAsync(BaseRequest baseRequest) {
            var request = new RestRequest(baseRequest.Method);
            request.AddHeader("Content-type", baseRequest.ContentType);
            if (baseRequest.Parameter != null) {
                request.AddParameter("param", JsonConvert.SerializeObject(baseRequest.Parameter), ParameterType.RequestBody);
            }
            client.BaseUrl = new Uri(apiurl + baseRequest.Route);
            var response = await client.ExecuteAsync(request);
            return JsonConvert.DeserializeObject<ApiResponse>(response.Content);
        }

        public async Task<ApiResponse<T>> ExecuteAsync<T>(BaseRequest baseRequest) {
            var request = new RestRequest(baseRequest.Method);
            request.AddHeader("Content-type", baseRequest.ContentType);
            if (baseRequest.Parameter != null) {
                request.AddParameter("param", JsonConvert.SerializeObject(baseRequest.Parameter), ParameterType.RequestBody);
            }
            client.BaseUrl = new Uri(apiurl + baseRequest.Route);
            var response = await client.ExecuteAsync(request);
            return JsonConvert.DeserializeObject<ApiResponse<T>>(response.Content);
        }
    }
 }
