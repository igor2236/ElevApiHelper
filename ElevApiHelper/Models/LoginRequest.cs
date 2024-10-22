using Newtonsoft.Json;
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
        [JsonProperty("login")]
        public string? Login { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("senha")]
        public string? Senha { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("tipoPosicao")]
        public string? TipoPosicao { get; set; }
    }
}
