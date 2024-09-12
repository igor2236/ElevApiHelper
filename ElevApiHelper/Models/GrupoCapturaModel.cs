using ElevApiHelper.Interfaces;

namespace ElevApiHelper.Models
{
    internal class GrupoCapturaModel : IGrupoCapturaModel
    {
        public string? Nome { get; set; }
        public int? Codigo { get; set; }
    }
}
