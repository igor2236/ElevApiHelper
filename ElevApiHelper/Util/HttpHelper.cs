using ElevApiHelper.Models.CentroDeCusto;
using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Data;
using System.Data.Common;
using System.IO;
using System.Linq;
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
        public static async Task<T> GetAsyncExtessinonMultParameters<T>(this HttpClient httpClient, string endpoint, Dictionary<string, object> parameters) where T : class
        {
            try
            {
                List<string> parametersList = new List<string>();
                foreach (var parameter in parameters)
                {
                    parametersList.Add($"{parameter.Value}");
                }

                string parametersString = string.Join('&', parametersList);

                Uri uri = new Uri($"{httpClient.BaseAddress}{endpoint}/{parametersString}");
                using HttpResponseMessage response = await httpClient.GetAsync(uri);
                string? json = await response.Content.ReadAsStringAsync();

                if (response.IsSuccessStatusCode && !string.IsNullOrWhiteSpace(json))
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
            catch (Exception)
            {
                throw;
            }


        }
        /// <summary>
        /// 
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="httpClient"></param>
        /// <param name="endpoint"></param>
        /// <param name="parameter"></param>
        /// <returns></returns>
        public static async Task<Wrapper<T>> GetAsyncExtessinonSingleParameter<T>(this HttpClient httpClient, string endpoint, string parameter) where T : class
        {
            try
            {
                Uri uri = new Uri($"{httpClient.BaseAddress}{endpoint}/{parameter}");
                using HttpResponseMessage response = await httpClient.GetAsync(uri);
                Byte[]? json = await response.Content.ReadAsByteArrayAsync();
                string jonsonString = Encoding.UTF8.GetString(json);


                if (string.IsNullOrWhiteSpace(jonsonString))
                {
                    ErrorResponse error = new ErrorResponse(null, response.StatusCode);
                    return new Wrapper<T>(error);
                }


                if (response.IsSuccessStatusCode)
                {
                    T jsonResponse = JsonSerializer.Deserialize<T>(jonsonString)!;
                    return new Wrapper<T>(jsonResponse);
                }
                else
                {
                    ErrorResponse error = new ErrorResponse(jonsonString, response.StatusCode);
                    return new Wrapper<T>(error);
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

    }
}
