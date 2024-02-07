using Mango.Web.Models;
using Mango.Web.Service.IService;
using Newtonsoft.Json;

namespace Mango.Web.Service
{
    public class BaseService : IBaseService
    {
        private readonly IHttpClientFactory _httpClientFactory;
        public BaseService(IHttpClientFactory httpClientFactory) 
        {
            _httpClientFactory = httpClientFactory;
        }
        public async Task<ResponseDto?> SendAsync(RequestDto requestDto)
        {
            HttpClient client = _httpClientFactory.CreateClient("MangoAPI");
            HttpRequestMessage message = new();
            message.Headers.Add("Accept", "application/json");
            //token here

            message.RequestUri = new Uri(requestDto.Url);
            if (requestDto.Data != null) 
            { 
                message.Content = new StringContent(JsonConvert)
            }
        }
    }
}
