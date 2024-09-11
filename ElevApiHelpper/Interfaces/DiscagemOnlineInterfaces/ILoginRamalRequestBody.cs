namespace ElevApiHelper.Interfaces.DiscagemOnlineInterfaces
{
    internal interface ILoginRamalRequestBody
    {
        string? Ramal { get; set; }
        int Posicao { get; set; }
        string? SenhaRamal { get; set; }
    }
}