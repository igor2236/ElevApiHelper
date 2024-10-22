using ElevApiHelper.Models.CentroDeCusto;
using Newtonsoft.Json;
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
        [JsonProperty("params")]
        public GetCentrosDeCustoParams? GetCentroDeCustoParams { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("data")]
        public List<CentroDeCustoResponse>? Data { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("pagination")]
        public CentroDeCustoPagination? CentroDeCustoPagination { get; set; }
    }

}
