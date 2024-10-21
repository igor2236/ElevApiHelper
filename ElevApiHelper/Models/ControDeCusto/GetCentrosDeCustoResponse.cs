using ElevApiHelper.Models.CentroDeCusto;
using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace ElevApiHelper.Models.ControDeCusto
{/// <summary>
 /// 
 /// </summary>
    public class GetCentrosDeCustoResponse
    {/// <summary>
     /// 
     /// </summary>
        [JsonPropertyName("params")]
        public GetCentroDeCustoParams? GetCentroDeCustoParams { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonPropertyName("data")]
        public List<CentroDeCustoResponse>? Data { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonPropertyName("pagination")]
        public CentroDeCustoPagination? CentroDeCustoPagination { get; set; }
    }
}
