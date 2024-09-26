using ElevApiHelper.Interfaces;
using ElevApiHelper.Services;
using ElevApiHelper.Util;

namespace ElevApiTest
{
    internal class CentroDeCusto
    {
        private ElevApiHelper.ElevApiHelper elevApiHelper { get; set; }

        [SetUp]
        public void CentroDeCustoSetUp()
        {
            ElevApiHelper.Util.ElevConfig config = new ElevApiHelper.Util.ElevConfig() { Uri = new Uri(""), ApiKey = ""};
            elevApiHelper = new ElevApiHelper.ElevApiHelper(config);
        }

        [Test]
        public void GetCentroDecusto1()
        {
            ICentroDeCustoService centroDeCustoService = elevApiHelper.CreateCentroDeCustoService();
            centroDeCustoService.GetCentroDeCustoById(12);
        }
    }
}
