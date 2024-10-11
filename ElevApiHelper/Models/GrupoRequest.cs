using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace ElevApiHelper.Models
{
    /// <summary>
    /// 
    /// </summary>
    public class GrupoRequest
    {
        /// <summary>
        /// 
        /// </summary>
        [JsonPropertyName("nome")]
        public string? Nome { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonPropertyName("fk_classe")]
        public int? FkClasse { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonPropertyName("chamada_tempo")] 
        public bool? ChamadaTempo { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonPropertyName("limite_tempo")]
        public int? LimiteTempo { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonPropertyName("pausa_supervisor")]
        public bool? PausaSupervisor { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonPropertyName("entrar_pausa_supervisor")]
        public bool? EntrarPausaSupervisor { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonPropertyName("fk_grupo_supervisor")]
        public int? FkGrupoSupervisor { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonPropertyName("pesquisa")]
        public bool? Pesquisa { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonPropertyName("transferencia")]
        public string? Transferencia { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonPropertyName("fk_pesquisa")]
        public int? FkPesquisa { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonPropertyName("bloquear_teclado_discador")]
        public bool? BloquearTecladoDiscador { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonPropertyName("pausa_restringir")]
        public bool? PausaRestringir { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonPropertyName("pausa")]
        public List<int>? Pausa { get; set; }            
    }
}
