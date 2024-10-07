using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;

namespace ElevApiHelper.Models
{
    /// <summary>
    /// 
    /// </summary>
    public class LoginRequest
    {
        /// <summary>
        /// 
        /// </summary>
        [JsonPropertyName("login")]
        public string? Login { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonPropertyName("senha")]
        public string? Senha { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonPropertyName("tipoPosicao")]
        public string? TipoPosicao { get; set; }
    }
}
