using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace ElevApiHelper.Models.ControDeCusto
{
    /// <summary>
    /// 
    /// </summary>
    public class GetCentroDeCustoResponse
    {
        //int? page
        /// <summary>
        /// 
        /// </summary>
        [JsonPropertyName("page")]
        public int? Page {  get; set; }
        
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
        public string? SortBy {  get; set; }

        //string? order_by
        [JsonPropertyName("order_by")]
        public string? OrderBy {  get; set; }
        //bool ativo
        //string? nome
        //int? codigo
        //int? fk_ramal

        //200
        //http://192.168.2.242:9000/api/v2/centro-custo?page=1&rows=200
        //{
        //  "params": {
        //    "page": int,
        //    "rows": 200,
        //    "sort_by": 1,
        //    "order_by": "asc",
        //    "ativo": "true"
        //  },
        //  "data": [
        //    {
        //      "id": 1,
        //      "nome": "NOME CENTRO CUSTO",
        //      "quant_ramais": 187,
        //      "codigo": 3,
        //      "ativo": "t"
        //    },
        //    {
        //      "id": 2,
        //      "nome": "DISCADOR-AUTOMATICO",
        //      "quant_ramais": 18,
        //      "codigo": "",
        //      "ativo": "t"
        //    }
        //  ],
        //  "pagination": {
        //    "page": 1,
        //    "rows": 200,
        //    "totalRows": 2,
        //    "totalPages": 1
        //  }
        //}
    }
}
