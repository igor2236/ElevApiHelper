using Newtonsoft.Json;
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
        [JsonProperty("nome")]
        public string? Nome { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("fk_classe")]
        public int? FkClasse { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("chamada_tempo")] 
        public bool? ChamadaTempo { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("limite_tempo")]
        public int? LimiteTempo { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("pausa_supervisor")]
        public bool? PausaSupervisor { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("entrar_pausa_supervisor")]
        public bool? EntrarPausaSupervisor { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("fk_grupo_supervisor")]
        public int? FkGrupoSupervisor { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("pesquisa")]
        public bool? Pesquisa { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("transferencia")]
        public string? Transferencia { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("fk_pesquisa")]
        public int? FkPesquisa { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("bloquear_teclado_discador")]
        public bool? BloquearTecladoDiscador { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("pausa_restringir")]
        public bool? PausaRestringir { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("pausa")]
        public List<int>? Pausa { get; set; }            
    }
}
