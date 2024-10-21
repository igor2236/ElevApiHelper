using System.Text.Json.Serialization;

namespace ElevApiHelper.Models.CentroDeCusto
{
    /// <summary>
    /// 
    /// </summary>
    public class CentroDeCustoResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [JsonPropertyName("id")]
        public int? Id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonPropertyName("nome")]
        public string? Nome { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonPropertyName("quant_ramais")]
        public int? QuantRamais {  get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonPropertyName("codigo")]
        public int? Codigo { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonPropertyName("ativo")]
        public string? Ativo { get; set; }
    }
}
