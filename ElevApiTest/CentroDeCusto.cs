using ElevApiHelper.Interfaces;
using ElevApiHelper.Models.CentroDeCusto;
using ElevApiHelper.Services;
using ElevApiHelper.Util;
using Microsoft.Extensions.Configuration;
using System.Diagnostics;
using System.Net;
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
        [Category("Param: 1")]
        public async Task AssertTypeOfCentroDeCustoIsNotNull()
        {
            Wrapper<GetCentroDeCustoByIdResponse> result = await centroDeCustoServce.GetCentroDeCustoById(1);
            Assert.That(result.Result, Is.Not.Null);
        }

        [Test(Description = "Assert that result is successful")]
        [Category("Param: 1")]
        public async Task AssertTypeOfCentroDeCustoIsSuccess()
        {
            Wrapper<GetCentroDeCustoByIdResponse> result = await centroDeCustoServce.GetCentroDeCustoById(1);
            Assert.That(result.success, Is.True);
        }

        [Test(Description = "Assert that result has no error object in wrapper")]
        [Category("Param: 1")]
        public async Task AssertTypeOfCentroDeCustoHasNoErrorInWarapper()
        {
            Wrapper<GetCentroDeCustoByIdResponse> result = await centroDeCustoServce.GetCentroDeCustoById(1);
            Assert.That(result.Error, Is.Null);
        }


        [Test(Description = "Assert that result is not successful")]
        [Category("param: 2147483647")]
        public async Task AssertTypeOfCentroDeCustoIsNotSuccess()
        {
            Wrapper<GetCentroDeCustoByIdResponse> result = await centroDeCustoServce.GetCentroDeCustoById(2147483647);
            Assert.That(result.success, Is.False);
        }


        [Test(Description = "Assert that result has error description")]
        [Category("param: 2147483647")]
        public async Task AssertTypeOfCentroDeCustoHasErrorDescription()
        {
            Wrapper<GetCentroDeCustoByIdResponse> result = await centroDeCustoServce.GetCentroDeCustoById(2147483647);
            Assert.That(result.Error!.Message, Is.EqualTo("Centro de custo não encontrado"));
        }

        [Test(Description = "Assert that result has error HttpStatusCode")]
        [Category("param: 2147483647")]
        public async Task AssertTypeOfCentroDeCustoHasErroHttpStatusCode()
        {
            Wrapper<GetCentroDeCustoByIdResponse> result = await centroDeCustoServce.GetCentroDeCustoById(2147483647);
            Assert.That(result.Error!.HttpStatus, Is.EqualTo(HttpStatusCode.NotFound));
        }
    }
}
