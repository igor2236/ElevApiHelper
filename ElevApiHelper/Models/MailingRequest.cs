using Newtonsoft.Json;
using System.Text.Json.Serialization;

namespace ElevApiHelper.Models
{
    /// <summary>
    /// 
    /// </summary>
    public class MailingRequest
    {
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("campanha")]
        public string? Campanha { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("nome")]
        public string? Nome { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("telefone")]
        public string? Telefone { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("identificador")]
        public string? Identificador { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("inclusao_exclusao")]
        public string? InclusaoExclusao { get; set; }
    }
}