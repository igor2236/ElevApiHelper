using ElevApiHelper.Interfaces.DiscagemOnlineInterfaces;

namespace ElevApiHelper.Models.DiscagemOnlineModels
{
    internal class LoginRamalRequestBody : ILoginRamalRequestBody
    {
        public string? Ramal { get; set; }
        public int Posicao { get; set; }
        public string? SenhaRamal { get; set; }
    }
}