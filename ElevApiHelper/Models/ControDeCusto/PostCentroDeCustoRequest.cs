﻿using Newtonsoft.Json;
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
        [JsonProperty("nome")]
        public string? Nome { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("codigo")]
        public int Codigo { get; set; }
    }
}
