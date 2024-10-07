using System.Text.Json.Serialization;

namespace ElevApiHelper.Models
{
    /// <summary>
    /// 
    /// </summary>
    public class CentroDeCusto
    {
        /// <summary>
        /// 
        /// </summary>
        [JsonPropertyName("nome")]
        public string? Nome { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonPropertyName("codigo")]
        public int Codigo { get; set; }
    }
}
