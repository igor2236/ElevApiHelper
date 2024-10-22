using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Newtonsoft.Json;

namespace ElevApiHelper.Util
{
    internal static class ObjectDictionaryConvert
    {
        internal static Dictionary<string,object> ObjectToDictionary(object obj)
        {
            string json = JsonConvert.SerializeObject(obj, Formatting.Indented);

            Dictionary<string, object>? parameters = JsonConvert.DeserializeObject<Dictionary<string, object>>(json)
                .Select(x => x)
                .Where(x => x.Value != null)
                .ToDictionary(x => x.Key, x => x.Value);

            return parameters;
         }
    }
}
