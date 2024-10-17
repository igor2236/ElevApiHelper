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
using ElevApiTest.Util;

namespace ElevApiTest
{
    internal class CentroDeCusto
    {
        private ElevApiHelper.ElevApiHelper elevApiHelper { get; set; }
        private ICentroDeCustoService centroDeCustoServce { get; set; }

        [SetUp]
        public void CentroDeCustoSetUp()
        {
            ElevConfig? config = ElevConfigHelper.GetElevConfig();
            elevApiHelper = new ElevApiHelper.ElevApiHelper(config);
            centroDeCustoServce = elevApiHelper.CreateCentroDeCustoService();
        }

        #region GetCentroDeCustoById
        #endregion
        [Test(Description = "Assert that result is Success")]
        [Category("Param: 1")]
        public async Task AssertCentroDeCustoIsSuccess()
        {
            Wrapper<GetCentroDeCustoByIdResponse> result = await centroDeCustoServce.GetCentroDeCustoById(1);
            Assert.That(result.Result, Is.Not.Null);
            Assert.That(result.Result.GetType(), Is.EqualTo(typeof(GetCentroDeCustoByIdResponse)));
            Assert.That(result.success, Is.True);
            Assert.That(result.Error, Is.Null);
        }

        [Test(Description = "Assert that result has correct error object")]
        [Category("param: 2147483647")]
        public async Task AssertCentroDeCustoReturnsErrorObject()
        {
            Wrapper<GetCentroDeCustoByIdResponse> result = await centroDeCustoServce.GetCentroDeCustoById(2147483647);
            Assert.That(result.success, Is.False);
            Assert.That(result.Error!.GetType(), Is.EqualTo(typeof(ErrorResponse)));
            Assert.That(result.Error!.Message, Is.EqualTo("Centro de custo não encontrado"));
            Assert.That(result.Error!.HttpStatus, Is.EqualTo(HttpStatusCode.NotFound));
        }

        [Test(Description = "Assert that result has error object with corretc null return pattern")]
        [Category("param: -1")]
        public async Task AssertCentroDeCustoRetunsNothingInErrorObject()
        {
            Wrapper<GetCentroDeCustoByIdResponse> result = await centroDeCustoServce.GetCentroDeCustoById(-1);
            Assert.That(result.success, Is.False);
            Assert.That(result.Error!.GetType(), Is.EqualTo(typeof(ErrorResponse)));
            Assert.That(result.Error!.Message, Is.EqualTo("Nothing was returned by api."));
            Assert.That(result.Error!.HttpStatus, Is.EqualTo(HttpStatusCode.NotFound));
        }
    }
}
