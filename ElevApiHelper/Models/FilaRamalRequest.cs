using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Text;
using System.Text.Json.Serialization;

namespace ElevApiHelper.Models
{
    /// <summary>
    /// 
    /// </summary>
    public class FilaRamalRequest
    {
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("fk_fila")]
        public int FkFila { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("fk_ramal")]
        public int FkRamal { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("acao")]
        public string? Acao { get; set; }
    }
}
