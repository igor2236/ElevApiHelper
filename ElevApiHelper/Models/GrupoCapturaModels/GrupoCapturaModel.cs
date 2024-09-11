using ElevApiHelper.Interfaces.GrupoDeCapturaInterfaces;

namespace ElevApiHelper.Models.GrupoCapturaModels
{
    internal class GrupoCapturaModel : IGrupoCapturaModel
    {
        public string? Nome { get; set; }
        public int Codigo { get; set; }
    }
}
