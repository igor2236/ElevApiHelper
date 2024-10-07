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
        [JsonPropertyName("ramal")]
        public string? Ramal { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonPropertyName("posicao")]
        public int Posicao { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonPropertyName("senhaRamal")]
        public string? SenhaRamal { get; set; }
    }
}