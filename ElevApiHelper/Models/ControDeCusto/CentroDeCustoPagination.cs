using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Numerics;
using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace ElevApiHelper.Models.ControDeCusto
{
    /// <summary>
    /// 
    /// </summary>
    public class CentroDeCustoPagination
    {
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("page")]
        public int Page {  get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("rows")]
        public int Rows { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("totalRows")]
        public int TotalRows { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("totalPages")]
        public int TotalPages { get; set; }

    }
}
