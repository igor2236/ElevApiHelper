using ElevApiHelper.Interfaces.CentroDeCustoInterfaces;

namespace ElevApiHelper.Models.CentroDeCustoModels
{
    public class CentroDeCustoModel : ICentroDeCustoModel
    {
        public string? Nome { get; set; }
        public int Codigo { get; set; }
    }
}
