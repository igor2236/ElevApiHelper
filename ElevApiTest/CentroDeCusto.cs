using ElevApiHelper.Interfaces;
using ElevApiHelper.Services;
using ElevApiHelper.Util;
using Microsoft.Extensions.Configuration;

using System.Reflection;
using System.Runtime.CompilerServices;

namespace ElevApiTest
{
    internal class CentroDeCusto
    {
        private ElevApiHelper.ElevApiHelper elevApiHelper { get; set; }

        [SetUp]
        public void CentroDeCustoSetUp()
        {
            IConfigurationBuilder configuration = new ConfigurationBuilder().AddJsonFile("C:\\ElevApiHelper\\ElevApiTest\\appsettings.json");
            IConfigurationRoot? configurationRoot = configuration.Build();

            ElevConfig? config = GetElevConfig(configurationRoot);
            elevApiHelper = new ElevApiHelper.ElevApiHelper(config);
        }

        private ElevConfig GetElevConfig(IConfigurationRoot configurationRoot)
        {
            string uriString = !string.IsNullOrWhiteSpace(configurationRoot.GetValue<string?>("ElevAcsses:BaseAddres")) ?
            configurationRoot.GetValue<string>("ElevAcsses:BaseAddres")! :
            "";

            string apiKeyStirng = !string.IsNullOrWhiteSpace(configurationRoot.GetValue<string?>("ElevAcsses:Userstring")) ?
            configurationRoot.GetValue<string>("ElevAcsses:Userstring")! :
            "";

            ElevConfig config = new ElevConfig()
            {
                Uri = new Uri(uriString),
                ApiKey = apiKeyStirng
            };

            return config;
        }

        [Test]
        public void GetCentroDecusto()
        {
            ICentroDeCustoService centroDeCustoService = elevApiHelper.CreateCentroDeCustoService();
            var result = centroDeCustoService.GetCentroDeCustoById(1);
        }
    }
}
