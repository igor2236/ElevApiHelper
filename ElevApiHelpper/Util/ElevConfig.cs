using System;

namespace ElevApiHelper.Util
{
    public class ElevConfig : IElevConfig
    {
        public Uri? Uri { get; set; }
        public string? ApiKey { get; set; }
    }
}
