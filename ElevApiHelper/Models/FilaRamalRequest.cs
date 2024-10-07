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
    public class FilaRamal
    {
        /// <summary>
        /// 
        /// </summary>
        [JsonPropertyName("fk_fila")]
        public int FkFila { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonPropertyName("fk_ramal")]
        public int FkRamal { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonPropertyName("acao")]
        public string? Acao { get; set; }
    }
}
