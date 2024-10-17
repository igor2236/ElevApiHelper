using System.Text.Json.Serialization;

namespace ElevApiHelper.Models.CentroDeCusto
{
    /// <summary>
    /// 
    /// </summary>
    public class PostCentroDeCustoRequest
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
