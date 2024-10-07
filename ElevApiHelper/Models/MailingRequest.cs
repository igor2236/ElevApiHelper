using System.Text.Json.Serialization;

namespace ElevApiHelper.Models
{
    /// <summary>
    /// 
    /// </summary>
    public class Mailing
    {
        /// <summary>
        /// 
        /// </summary>
        [JsonPropertyName("campanha")]
        public string? Campanha { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonPropertyName("nome")]
        public string? Nome { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonPropertyName("telefone")]
        public string? Telefone { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonPropertyName("identificador")]
        public string? Identificador { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonPropertyName("inclusao_exclusao")]
        public string? InclusaoExclusao { get; set; }
    }
}