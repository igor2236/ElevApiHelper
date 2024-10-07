using System.Text.Json.Serialization;

namespace ElevApiHelper.Models
{
    /// <summary>
    /// 
    /// </summary>
    public class FilaRequest
    {
        /// <summary>
        /// 
        /// </summary>
        [JsonPropertyName("nome")]
        public string? Nome { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonPropertyName("toques")]
        public int Toques { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonPropertyName("fk_categoria")]
        public int FkCategoria { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonPropertyName("fk_estrategia")]
        public int FkEstrategia { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonPropertyName("espera")]
        public int Espera { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonPropertyName("sla")]
        public int Sla { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonPropertyName("sla_desejado")]
        public int SlaDesejado { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonPropertyName("tamanho")]
        public int Tamanho { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonPropertyName("tempo_discagem")]
        public int TempoDiscagem { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonPropertyName("fk_cochicho")]
        public int FkCochicho { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonPropertyName("tocar_ocupado")]
        public bool TocarOcupado { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonPropertyName("tocar_anuncio")]
        public bool TocarAnuncio { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonPropertyName("fk_anuncio")]
        public int FkAnuncio { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonPropertyName("anuncio_frequencia")]
        public int AnuncioFrequencia { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonPropertyName("estatistica_posicao")]
        public bool EstatisticaPosicao { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonPropertyName("estatistica_tempo")]
        public int EstatisticaTempo { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonPropertyName("estatistica_espera")]
        public string? EstatisticaEspera { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonPropertyName("tocar")]
        public bool Tocar { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonPropertyName("fk_musiconhold")]
        public int FkMusiconhold { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonPropertyName("musica_ramal")]
        public bool MusicaRamal { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonPropertyName("restringir_entrada")]
        public bool RestringirEntrada { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonPropertyName("restricao_o")]
        public bool RestricaoO { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonPropertyName("restricao_p")]
        public bool RestricaoP { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonPropertyName("restricao_i")]
        public bool RestricaoI { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonPropertyName("restringir_tempo")]
        public bool RestringirTempo { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonPropertyName("limite_tempo")]
        public int LimiteTempo { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonPropertyName("pesquisa")]
        public bool Pesquisa { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonPropertyName("transferencia")]
        public string? Transferencia { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonPropertyName("fk_pesquisa")]
        public int FkPesquisa { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonPropertyName("comando")]
        public bool Comando { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonPropertyName("codigo")]
        public int Codigo { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonPropertyName("prioridade")]
        public int Prioridade { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonPropertyName("tipo")]
        public string? Tipo { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonPropertyName("callback")]
        public bool Callback { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonPropertyName("identificacao")]
        public bool Identificacao { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonPropertyName("fila_callback_combo")]
        public int FilaCallbackCombo { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonPropertyName("qtd_callback")]
        public int QtdCallback { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonPropertyName("intervalo_callback")]
        public int IntervaloCallback { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonPropertyName("prioriza_operador")]
        public bool PriorizaOperador { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonPropertyName("fk_ramal_id")]
        public int FkRamalId { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonPropertyName("fk_numero_id")]
        public int FkNumeroId { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonPropertyName("fk_audio_callback")]
        public int FkAudioCallback { get; set; }

    }
}
