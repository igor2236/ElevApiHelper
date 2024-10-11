
using System.Text.Json.Serialization;

namespace ElevApiHelper.Models
{
    /// <summary>
    /// 
    /// </summary>
    public class SmsRequest
    {
        /// <summary>
        /// 
        /// </summary>
        [JsonPropertyName("host")]
         public string? Host {get; set;}
        /// <summary>
        /// 
        /// </summary>
        [JsonPropertyName("user")]
        public string? User {get; set;}
        /// <summary>
        /// 
        /// </summary>
        [JsonPropertyName("secret")]
        public string? Secret {get; set;}
        /// <summary>
        /// 
        /// </summary>
        [JsonPropertyName("port")]
        public int Port {get; set;}
        /// <summary>
        /// 
        /// </summary>
        [JsonPropertyName("board")]
        public int Board {get; set;}
        /// <summary>
        /// 
        /// </summary>
        [JsonPropertyName("channel")]
        public int Channel {get; set;}
        /// <summary>
        /// 
        /// </summary>
        [JsonPropertyName("number")]
        public string? Number {get; set;}
        /// <summary>
        /// 
        /// </summary>
        [JsonPropertyName("message")]
        public string? Message { get; set; }
    }
}