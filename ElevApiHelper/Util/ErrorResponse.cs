using AJP;
using ElevApiHelper.Util.ErrorModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Runtime.Serialization;
using System.Text;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Xml.Linq;

namespace ElevApiHelper.Util
{
    /// <summary>
    /// 
    /// </summary>
    public class ErrorResponse
    {
        /// <summary>
        /// 
        /// </summary>
        public string? Message { get; }
        /// <summary>
        /// 
        /// </summary>
        public HttpStatusCode? HttpStatus { get; }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="errorJson"></param>
        /// <param name="httpStatus"></param>
        public ErrorResponse(string? errorJson, HttpStatusCode httpStatus)
        {
            HttpStatus = httpStatus;

            if (errorJson == null)
            {
                Message = "Nothing was returned by api.";
                return;
            }

            errorJson = "{\r\n  \"error\": {\r\n    \"code\": 403,\r\n    \"message\": \"O ramal não está vinculado a nenhuma fila.\"\r\n  }\r\n}";
            JsonElement errorJsonElement = JsonSerializer.Deserialize<JsonElement>(JsonDocument.Parse(errorJson));
            Message = GetErrorMessage(errorJsonElement);
        }

        private string GetErrorMessage(JsonElement errorJsonElement)
        {
            if (errorJsonElement.TryGetProperty("message", out var message))
            {
                return message.ToString();
            }
            else
            {
                //TODO Ver isso aqui
                var aaa = errorJsonElement.GetProperties();
                GetErrorMessage(JsonSerializer.Deserialize<JsonElement>(JsonDocument.Parse(errorJsonElement.GetProperties().ToString())));
                return errorJsonElement.ToString();
            }
        }
    }
}
