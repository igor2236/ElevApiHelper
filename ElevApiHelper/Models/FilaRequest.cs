using Newtonsoft.Json;
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
        [JsonProperty("nome")]
        public string? Nome { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("toques")]
        public int Toques { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("fk_categoria")]
        public int FkCategoria { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("fk_estrategia")]
        public int FkEstrategia { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("espera")]
        public int Espera { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("sla")]
        public int Sla { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("sla_desejado")]
        public int SlaDesejado { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("tamanho")]
        public int Tamanho { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("tempo_discagem")]
        public int TempoDiscagem { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("fk_cochicho")]
        public int FkCochicho { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("tocar_ocupado")]
        public bool TocarOcupado { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("tocar_anuncio")]
        public bool TocarAnuncio { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("fk_anuncio")]
        public int FkAnuncio { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("anuncio_frequencia")]
        public int AnuncioFrequencia { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("estatistica_posicao")]
        public bool EstatisticaPosicao { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("estatistica_tempo")]
        public int EstatisticaTempo { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("estatistica_espera")]
        public string? EstatisticaEspera { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("tocar")]
        public bool Tocar { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("fk_musiconhold")]
        public int FkMusiconhold { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("musica_ramal")]
        public bool MusicaRamal { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("restringir_entrada")]
        public bool RestringirEntrada { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("restricao_o")]
        public bool RestricaoO { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("restricao_p")]
        public bool RestricaoP { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("restricao_i")]
        public bool RestricaoI { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("restringir_tempo")]
        public bool RestringirTempo { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("limite_tempo")]
        public int LimiteTempo { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("pesquisa")]
        public bool Pesquisa { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("transferencia")]
        public string? Transferencia { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("fk_pesquisa")]
        public int FkPesquisa { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("comando")]
        public bool Comando { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("codigo")]
        public int Codigo { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("prioridade")]
        public int Prioridade { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("tipo")]
        public string? Tipo { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("callback")]
        public bool Callback { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("identificacao")]
        public bool Identificacao { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("fila_callback_combo")]
        public int FilaCallbackCombo { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("qtd_callback")]
        public int QtdCallback { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("intervalo_callback")]
        public int IntervaloCallback { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("prioriza_operador")]
        public bool PriorizaOperador { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("fk_ramal_id")]
        public int FkRamalId { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("fk_numero_id")]
        public int FkNumeroId { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("fk_audio_callback")]
        public int FkAudioCallback { get; set; }

    }
}
