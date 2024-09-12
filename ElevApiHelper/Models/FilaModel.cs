using ElevApiHelper.Interfaces;

namespace ElevApiHelper.Models
{
    internal class FilaModel : IFilaModel
    {
        public string? Nome { get; set; }
        public int Toques { get; set; }
        public int FkCategoria { get; set; }
        public int FkEstrategia { get; set; }
        public int Espera { get; set; }
        public int Sla { get; set; }
        public int SlaDesejado { get; set; }
        public int Tamanho { get; set; }
        public int TempoDiscagem { get; set; }
        public int FkCochicho { get; set; }
        public bool TocarOcupado { get; set; }
        public bool TocarAnuncio { get; set; }
        public int FkAnuncio { get; set; }
        public int AnuncioFrequencia { get; set; }
        public bool EstatisticaPosicao { get; set; }
        public int EstatisticaTempo { get; set; }
        public string? EstatisticaEspera { get; set; }
        public bool Tocar { get; set; }
        public int FkMusiconhold { get; set; }
        public bool MusicaRamal { get; set; }
        public bool RestringirEntrada { get; set; }
        public bool RestricaoO { get; set; }
        public bool RestricaoP { get; set; }
        public bool RestricaoI { get; set; }
        public bool RestringirTempo { get; set; }
        public int LimiteTempo { get; set; }
        public bool Pesquisa { get; set; }
        public string? Transferencia { get; set; }
        public int FkPesquisa { get; set; }
        public bool Comando { get; set; }
        public int Codigo { get; set; }
        public int Prioridade { get; set; }
        public string? Tipo { get; set; }
        public bool Callback { get; set; }
        public bool Identificacao { get; set; }
        public int FilaCallbackCombo { get; set; }
        public int QtdCallback { get; set; }
        public int IntervaloCallback { get; set; }
        public bool PriorizaOperador { get; set; }
        public int FkRamalId { get; set; }
        public int FkNumeroId { get; set; }
        public int FkAudioCallback { get; set; }
    }
}
