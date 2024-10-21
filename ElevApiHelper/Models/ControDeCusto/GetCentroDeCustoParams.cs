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
        /// <summary>
        /// 
        /// </summary>
        [JsonPropertyName("ativo")]
        public bool? Ativo { get; set; } = true;

        //string? nome
        /// <summary>
        /// 
        /// </summary>
        [JsonPropertyName("nome")]
        public string? Nome { get; set; }

        //int? codigo
        /// <summary>
        /// 
        /// </summary>
        [JsonPropertyName("codigo")]
        public int? Codigo { get; set; }

        //int? fk_ramal
        /// <summary>
        /// 
        /// </summary>
        [JsonPropertyName("fk_ramal")]
        public int? FkRamal { get; set; }

    }
}
