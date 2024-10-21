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
        public static async Task<Wrapper<T>> GetAsyncExtessinonMultParameters<T>(this HttpClient httpClient, string endpoint, Dictionary<string, object>? parameters) where T : class
        {
            try
            {
                string parametersString = "";
                if (parameters != null && parameters.Count > 0)
                {
                    List<string> parametersList = new List<string>();
                    foreach (var parameter in parameters)
                    {
                        parametersList.Add($"{parameter.Key}={parameter.Value}");
                    }
                    parametersString = string.Join('&', parametersList);
                }

                Uri uri = new Uri($"{httpClient.BaseAddress}{endpoint}?{parametersString}");
                using HttpResponseMessage response = await httpClient.GetAsync(uri);
                Byte[]? json = await response.Content.ReadAsByteArrayAsync();
                string jsonString = Encoding.UTF8.GetString(json);
                

                if (string.IsNullOrWhiteSpace(jsonString))
                {
                    ErrorResponse error = new ErrorResponse(null, response.StatusCode);
                    return new Wrapper<T>(error);
                }

                if (response.IsSuccessStatusCode)
                {
                    T jsonResponse = JsonSerializer.Deserialize<T>(jsonString)!;
                    return new Wrapper<T>(jsonResponse);
                }
                else
                {
                    ErrorResponse error = new ErrorResponse(jsonString, response.StatusCode);
                    return new Wrapper<T>(error);
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
                string jsonString = Encoding.UTF8.GetString(json);


                if (string.IsNullOrWhiteSpace(jsonString))
                {
                    ErrorResponse error = new ErrorResponse(null, response.StatusCode);
                    return new Wrapper<T>(error);
                }


                if (response.IsSuccessStatusCode)
                {
                    T jsonResponse = JsonSerializer.Deserialize<T>(jsonString)!;
                    return new Wrapper<T>(jsonResponse);
                }
                else
                {
                    ErrorResponse error = new ErrorResponse(jsonString, response.StatusCode);
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
