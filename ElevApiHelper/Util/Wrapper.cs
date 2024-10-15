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
        public T? Result { get; }
        /// <summary>
        /// 
        /// </summary>
        public ErrorResponse? Error { get; }
        /// <summary>
        /// 
        /// </summary>
        public bool success => Error == null;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="response"></param>
        public Wrapper(T response)
        {
            Result = response;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="response"></param>
        public Wrapper(ErrorResponse response)
        {
            Error = response;
        }
    }
}
