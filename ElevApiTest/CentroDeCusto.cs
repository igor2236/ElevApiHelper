namespace ElevApiTest
{
    internal class CentroDeCusto
    {
        //TODO: Ver alguma forma de implementar DI
        private ElevApiHelper.ElevApiHelper elevApiHelper { get; set; }

        [SetUp]
        public void CentroDeCustoSetUp()
        {
            Uri uri = new Uri("");
            string apiKey = "";
            elevApiHelper = new ElevApiHelper.ElevApiHelper(uri, apiKey);
        }
    }
}
