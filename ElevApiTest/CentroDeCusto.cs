namespace ElevApiTest
{
    internal class CentroDeCusto
    {
        //TODO: Ver alguma forma de implementar DI
        private ElevApiHelper.ElevApiHelper elevApiHelper { get; set; }

        [SetUp]
        public void CentroDeCustoSetUp()
        {
            var ElevConfig = new ElevApiHelper.Util.ElevConfig() { Uri = new Uri(""), ApiKey = ""};
            elevApiHelper = new ElevApiHelper.ElevApiHelper(ElevConfig);
        }
    }
}
