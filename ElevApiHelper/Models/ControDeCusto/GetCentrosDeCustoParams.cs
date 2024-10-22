using ElevApiHelper.Enums;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;

namespace ElevApiHelper.Models.ControDeCusto
{
    /// <summary>
    /// 
    /// </summary>
    public class GetCentrosDeCustoParams
    {
        //int? page
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("page")]
        public int? Page { get; set; }

        //int? rows
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("rows")]
        public int? Rows { get; set; }

        //string? sort_by
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("sort_by")]
        public string? SortBy { get; set; }

        //string? order_by
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("order_by")]
        public string? OrderBy { get; set; }

        //bool ativo
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("ativo")]
        public bool? Ativo { get; set; } = true;

        //string? nome
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("nome")]
        public string? Nome { get; set; }

        //int? codigo
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("codigo")]
        public int? Codigo { get; set; }

        //int? fk_ramal
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("fk_ramal")]
        public int? FkRamal { get; set; }

    }
}
