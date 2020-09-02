using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using Newtonsoft.Json;
using Sample.RP.RestApi.Configuration;
using Sample.RP.RestApi.Controllers.V1;
using System.Net.Http;
using System.Threading.Tasks;

namespace Sample.RP.RestApi.Services.Case
{
    public class CaseServiceClient : ICaseServiceClient
    {
        private readonly ILogger<CaseServiceClient> _logger;
        private readonly UrlsConfig _urls;

        public CaseServiceClient(ILogger<CaseServiceClient> logger, IOptions<UrlsConfig> config)
        {
            _logger = logger;
            _urls = config.Value;
        }

        public async Task<AllCasesItem> GetAllCases()
        {
            var _apiClient = new HttpClient();
            var url = _urls.CaseServiceURL + UrlsConfig.CaseServiceOperations.GetAllCases;
            var response = await _apiClient.GetAsync(url);
            
            response.EnsureSuccessStatusCode();

            var GetAllCasesResponseResponse = await response.Content.ReadAsStringAsync();

            return JsonConvert.DeserializeObject<AllCasesItem>(GetAllCasesResponseResponse);
        }
    }
}
