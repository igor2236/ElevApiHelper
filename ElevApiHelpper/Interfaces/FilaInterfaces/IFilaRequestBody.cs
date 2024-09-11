namespace ElevApiHelper.Models.FilaModels
{
    internal interface IFilaRequestBody
    {
        int AnuncioFrequencia { get; set; }
        bool Callback { get; set; }
        int Codigo { get; set; }
        bool Comando { get; set; }
        int Espera { get; set; }
        string? EstatisticaEspera { get; set; }
        bool EstatisticaPosicao { get; set; }
        int EstatisticaTempo { get; set; }
        int FilaCallbackCombo { get; set; }
        int FkAnuncio { get; set; }
        int FkAudioCallback { get; set; }
        int FkCategoria { get; set; }
        int FkCochicho { get; set; }
        int FkEstrategia { get; set; }
        int FkMusiconhold { get; set; }
        int FkNumeroId { get; set; }
        int FkPesquisa { get; set; }
        int FkRamalId { get; set; }
        bool Identificacao { get; set; }
        int IntervaloCallback { get; set; }
        int LimiteTempo { get; set; }
        bool MusicaRamal { get; set; }
        string? Nome { get; set; }
        bool Pesquisa { get; set; }
        int Prioridade { get; set; }
        bool PriorizaOperador { get; set; }
        int QtdCallback { get; set; }
        bool RestricaoI { get; set; }
        bool RestricaoO { get; set; }
        bool RestricaoP { get; set; }
        bool RestringirEntrada { get; set; }
        bool RestringirTempo { get; set; }
        int Sla { get; set; }
        int SlaDesejado { get; set; }
        int Tamanho { get; set; }
        int TempoDiscagem { get; set; }
        string? Tipo { get; set; }
        bool Tocar { get; set; }
        bool TocarAnuncio { get; set; }
        bool TocarOcupado { get; set; }
        int Toques { get; set; }
        string? Transferencia { get; set; }
    }
}