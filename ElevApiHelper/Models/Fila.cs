namespace ElevApiHelper.Models
{
    /// <summary>
    /// 
    /// </summary>
    public class Fila
    {
        /// <summary>
        /// 
        /// </summary>
        public string? Nome { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int Toques { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int FkCategoria { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int FkEstrategia { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int Espera { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int Sla { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int SlaDesejado { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int Tamanho { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int TempoDiscagem { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int FkCochicho { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public bool TocarOcupado { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public bool TocarAnuncio { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int FkAnuncio { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int AnuncioFrequencia { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public bool EstatisticaPosicao { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int EstatisticaTempo { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string? EstatisticaEspera { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public bool Tocar { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int FkMusiconhold { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public bool MusicaRamal { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public bool RestringirEntrada { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public bool RestricaoO { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public bool RestricaoP { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public bool RestricaoI { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public bool RestringirTempo { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int LimiteTempo { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public bool Pesquisa { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string? Transferencia { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int FkPesquisa { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public bool Comando { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int Codigo { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int Prioridade { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string? Tipo { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public bool Callback { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public bool Identificacao { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int FilaCallbackCombo { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int QtdCallback { get; set; }        
        /// <summary>
        /// 
        /// </summary>
        public int IntervaloCallback { get; set; }        
        /// <summary>
        /// 
        /// </summary>
        public bool PriorizaOperador { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int FkRamalId { get; set; }       
        /// <summary>
        /// 
        /// </summary>
        public int FkNumeroId { get; set; }        
        /// <summary>
        /// 
        /// </summary>
        public int FkAudioCallback { get; set; }

    }
}
