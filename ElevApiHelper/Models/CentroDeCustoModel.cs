using ElevApiHelper.Interfaces;

namespace ElevApiHelper.Models
{
    public class CentroDeCustoModel : ICentroDeCustoModel
    {
        public string? Nome { get; set; }
        public int Codigo { get; set; }
    }
}
