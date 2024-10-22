using Newtonsoft.Json;
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
        [JsonProperty("id")]
        public int? Id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("nome")]
        public string? Nome { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("quant_ramais")]
        public int? QuantRamais {  get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("codigo")]
        public int? Codigo { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("ativo")]
        public string? Ativo { get; set; }
    }
}
