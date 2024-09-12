namespace ElevApiHelper.Interfaces
{
    internal interface IFilaRamalModel
    {
        string? Acao { get; set; }
        int FkFila { get; set; }
        int FkRamal { get; set; }
    }
}