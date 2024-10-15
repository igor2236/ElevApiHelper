using System.ComponentModel;
using System.Net;
using System.Net.Http;
using System.Runtime.CompilerServices;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Threading;

namespace ElevApiHelper.Util
{
    /// <summary>
    /// 
    /// </summary>
    public class Wrapper<T> where T : class
    {
        /// <summary>
        /// 
        /// </summary>
        public T? obj { get; }
        /// <summary>
        /// 
        /// </summary>
        public string? error { get; }
        /// <summary>
        /// 
        /// </summary>
        public bool success => string.IsNullOrEmpty(error);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="response"></param>
        public Wrapper(T response)
        {
            obj = response;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="response"></param>
        public Wrapper(string response)
        {
            error = response;
        }
    }
}
