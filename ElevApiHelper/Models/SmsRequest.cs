
using Newtonsoft.Json;
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
        [JsonProperty("host")]
         public string? Host {get; set;}
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("user")]
        public string? User {get; set;}
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("secret")]
        public string? Secret {get; set;}
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("port")]
        public int Port {get; set;}
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("board")]
        public int Board {get; set;}
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("channel")]
        public int Channel {get; set;}
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("number")]
        public string? Number {get; set;}
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("message")]
        public string? Message { get; set; }
    }
}