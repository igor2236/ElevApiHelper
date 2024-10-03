using ElevApiHelper.Services;
using ElevApiHelper.Util;
using ElevApiHelper.Interfaces;
using System.Net.Http;
using System.Net.Http.Headers;

namespace ElevApiHelper
{
    /// <summary>
    /// 
    /// </summary>
    public class ElevApiHelper
    {
        private readonly ElevConfig _config;
        private readonly HttpClient _httpClient;
        /// <summary>
        /// 
        /// </summary>
        /// <param name="config"></param>
        public ElevApiHelper(ElevConfig config)
        {
            _config = config;

            _httpClient = new HttpClient() 
            {
                BaseAddress = config.Uri,
            };

            _httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue(config.ApiKey);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public ICentroDeCustoService CreateCentroDeCustoService()
        {
            return new CentroDeCustoService(_config,_httpClient);
        }
    }
}
