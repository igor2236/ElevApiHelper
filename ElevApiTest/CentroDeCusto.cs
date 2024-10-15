using ElevApiHelper.Interfaces;
using ElevApiHelper.Models.CentroDeCusto;
using ElevApiHelper.Services;
using ElevApiHelper.Util;
using Microsoft.Extensions.Configuration;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text.Json.Nodes;
using System.Xml;

namespace ElevApiTest
{
    internal class CentroDeCusto
    {
        private ElevApiHelper.ElevApiHelper elevApiHelper { get; set; }
        private ICentroDeCustoService centroDeCustoServce { get; set; }

        [SetUp]
        public void CentroDeCustoSetUp()
        {
            IConfigurationBuilder configuration = new ConfigurationBuilder().AddJsonFile("C:\\ElevApiHelper\\ElevApiTest\\appsettings.json");
            IConfigurationRoot? configurationRoot = configuration.Build();

            ElevConfig? config = GetElevConfig(configurationRoot);
            elevApiHelper = new ElevApiHelper.ElevApiHelper(config);
            centroDeCustoServce = elevApiHelper.CreateCentroDeCustoService();
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

        [Test(Description = "Assert that result is not NULL")]
        public async Task AssertTypeOfCentroDeCustoIsNotNull()
        {
             var result = await centroDeCustoServce.GetCentroDeCustoById(1);
             Assert.That(result.Result, Is.Not.Null);
        }

        [Test(Description = "Assert that result is successful")]
        public async Task AssertTypeOfCentroDeCustoIsSuccess()
        {
            var result = await centroDeCustoServce.GetCentroDeCustoById(1);
            Assert.That(result.success,Is.True);
        }

        [Test(Description = "Assert that result is not successful")]
        public async Task AssertTypeOfCentroDeCustoIsNotSuccess()
        {
            var result = await centroDeCustoServce.GetCentroDeCustoById(2147483647);
            Assert.That(result.success, Is.False);
        }


        [Test(Description = "Assert that result has error description")]
        public async Task AssertTypeOfCentroDeCustoHasErrorDescription()
        {
            var result = await centroDeCustoServce.GetCentroDeCustoById(2147483647);
            Assert.That(result.Error.Message, Is.EqualTo("asdasdasdasdasd"));
        }
    }
}
