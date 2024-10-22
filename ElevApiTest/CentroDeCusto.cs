﻿using ElevApiHelper.Interfaces;
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
using ElevApiHelper.Models.ControDeCusto;
using ElevApiTest.Util.CentroDeCusto;

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

        [Test(Description = "Assert that result is Success")]
        [Category("Param: 1")]
        public async Task AssertGetCentroDeCustoByIdIsSuccess()
        {
            Wrapper<CentroDeCustoResponse> result = await centroDeCustoServce.GetCentroDeCustoById(1);
            Assert.That(result.Result, Is.Not.Null);
            Assert.That(result.Result.GetType(), Is.EqualTo(typeof(CentroDeCustoResponse)));
            Assert.That(result.success, Is.True);
            Assert.That(result.Error, Is.Null);
        }

        [Test(Description = "Assert that result has correct error object")]
        [Category("param: 2147483647")]
        public async Task AssertGetCentroDeCustoByIdReturnsErrorObject()
        {
            Wrapper<CentroDeCustoResponse> result = await centroDeCustoServce.GetCentroDeCustoById(2147483647);
            Assert.That(result.success, Is.False);
            Assert.That(result.Error!.GetType(), Is.EqualTo(typeof(ErrorResponse)));
            Assert.That(result.Error!.Message, Is.EqualTo("Centro de custo não encontrado"));
            Assert.That(result.Error!.HttpStatus, Is.EqualTo(HttpStatusCode.NotFound));
        }

        [Test(Description = "Assert that result has error object with corretc null return pattern")]
        [Category("param: -1")]
        public async Task AssertGetCentroDeCustoByIdRetunsNothingInErrorObject()
        {
            Wrapper<CentroDeCustoResponse> result = await centroDeCustoServce.GetCentroDeCustoById(-1);
            Assert.That(result.success, Is.False);
            Assert.That(result.Error!.GetType(), Is.EqualTo(typeof(ErrorResponse)));
            Assert.That(result.Error!.Message, Is.EqualTo("Nothing was returned by api."));
            Assert.That(result.Error!.HttpStatus, Is.EqualTo(HttpStatusCode.NotFound));
        }
        #endregion

        #region GetCentroDeCusto
        [Test(Description = "Assert that result is Success")]
        [Category("Param: 1")]
        public async Task AssertGetCentrosDeCustoIsSuccess()
        {
            GetCentrosDeCustoParams getCentroDeCustoParams = GetCentrosDeCustoParamsModels.GetModelPageZero();

            Wrapper<GetCentrosDeCustoResponse> result = await centroDeCustoServce.GetCentrosDeCusto(getCentroDeCustoParams);
            Assert.That(result.Result, Is.Not.Null);
            Assert.That(result.Result.GetType(), Is.EqualTo(typeof(GetCentrosDeCustoResponse)));
            Assert.That(result.success, Is.True);
            Assert.That(result.Error, Is.Null);
        }

        [Test(Description = "Assert that result has correct error object")]
        [Category("Param: 1")]
        public async Task AssertGetCentrosDeCustoReturnsErrorObject()
        {
            GetCentrosDeCustoParams getCentroDeCustoParams = GetCentrosDeCustoParamsModels.GetModelPageZero();

            Wrapper<GetCentrosDeCustoResponse> result = await centroDeCustoServce.GetCentrosDeCusto(getCentroDeCustoParams);
            Assert.That(result.Result, Is.Not.Null);
            Assert.That(result.Result.GetType(), Is.EqualTo(typeof(GetCentrosDeCustoResponse)));
            Assert.That(result.success, Is.True);
            Assert.That(result.Error, Is.Null);
        }
        #endregion
    }
}
