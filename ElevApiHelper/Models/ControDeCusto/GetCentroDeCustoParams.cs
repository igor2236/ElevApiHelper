using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;

namespace ElevApiHelper.Models.ControDeCusto
{
    /// <summary>
    /// 
    /// </summary>
    public class GetCentroDeCustoParams
    {
        //int? page
        /// <summary>
        /// 
        /// </summary>
        [JsonPropertyName("page")]
        public int? Page { get; set; }

        //int? rows
        /// <summary>
        /// 
        /// </summary>
        [JsonPropertyName("rows")]
        public int? Rows { get; set; }

        //string? sort_by
        /// <summary>
        /// 
        /// </summary>
        [JsonPropertyName("sort_by")]
        public string? SortBy { get; set; }

        //string? order_by
        /// <summary>
        /// 
        /// </summary>
        [JsonPropertyName("order_by")]
        public string? OrderBy { get; set; }

        //bool ativo
        //string? nome
        //int? codigo
        //int? fk_ramal

    }
}
