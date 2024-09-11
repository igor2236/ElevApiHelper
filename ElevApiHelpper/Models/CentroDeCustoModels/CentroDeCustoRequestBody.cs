using ElevApiHelper.Interfaces.CentroDeCustoInterfaces;

namespace ElevApiHelper.Models.CentroDeCustoModels
{
    public class CentroDeCustoRequestBody : ICentroDeCustoRequestBody
    {
        public string? Nome { get; set; }
        public int Codigo { get; set; }
    }
}
