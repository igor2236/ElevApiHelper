using ElevApiHelper.Services;
using ElevApiHelper.Util;
using System.Diagnostics;
using ElevApiHelper.Interfaces;
using System.IO;
using System.Net.Http;
using System;

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
            _httpClient = new HttpClient() { BaseAddress = config.Uri};
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
