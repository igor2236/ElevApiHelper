using ElevApiHelper.Models.CentroDeCusto;
using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.IO;
using System.Net.Http;
using System.Runtime.CompilerServices;
using System.Text;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace ElevApiHelper.Util
{
    /// <summary>
    /// 
    /// </summary>
    public static class HttpHelper
    {
       /// <summary>
       /// 
       /// </summary>
       /// <param name="httpClient"></param>
       /// <param name="endpoint"></param>
       /// <param name="parameters"></param>
       /// <returns></returns>
        public static async Task<T> GetAsyncExtessinon<T>(this HttpClient httpClient,string endpoint, Dictionary<string,object> parameters) where T : class
        {
           
            using HttpResponseMessage response = await httpClient.GetAsync($"{httpClient.BaseAddress}{endpoint}/{parameters}");
            string? json = await response.Content.ReadAsStringAsync();

            if (response.IsSuccessStatusCode) 
            {
                T jsonResponse = JsonSerializer.Deserialize<T>(json)!;
                //T jsonResponse = JsonSerializer.Deserialize<T>(json) != null ?
                //JsonSerializer.Deserialize<T>(json)! :
                //jsonResponse;
                return jsonResponse;
            }
            else 
            {
                 T jsonResponse = JsonSerializer.Deserialize<T>(json)!;
                return jsonResponse;
            }
        }

    }
}
