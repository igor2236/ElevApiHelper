using AJP;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json.Serialization;
using System.Linq;
using System.Net;
using System.Text.Json;

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

            JObject errorJsonElement = JObject.Parse(errorJson);
            Message = GetErrorMessage(errorJsonElement, "");
        }

        private string GetErrorMessage(JObject errorJsonElement, string message)
        {
            try
            {
                if (errorJsonElement.Children().Count() > 0)
                {
                    foreach (JProperty child in errorJsonElement.Children())
                    {
                        if (child.Children().Children().Count() > 0 )
                            message = GetErrorMessage(JObject.Parse(child.Value.ToString()), message);
                        else
                            if(child.Name == "message" && string.IsNullOrWhiteSpace(null))
                            message = child.Value.ToString();
                    }
                } 
            }
            catch (System.Exception)
            {
                throw;
            }
            return message;
        }
    }
}
