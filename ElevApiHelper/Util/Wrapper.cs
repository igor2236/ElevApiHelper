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
    public class Wrapper<T>
    {
        internal T _obj { get; }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="response"></param>
    public Wrapper(T response)
        {
            _obj = response;
        }
    }
}
