using Newtonsoft.Json;
using System.Text.Json.Serialization;

namespace ElevApiHelper.Models
{
    /// <summary>
    /// 
    /// </summary>
    public class LoginRamalRequest
    {
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("ramal")]
        public string? Ramal { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("posicao")]
        public int Posicao { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("senhaRamal")]
        public string? SenhaRamal { get; set; }
    }
}