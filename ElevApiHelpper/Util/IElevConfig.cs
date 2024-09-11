using System;

namespace ElevApiHelper.Util
{
    public interface IElevConfig
    {
        string? ApiKey { get; set; }
        Uri? Uri { get; set; }
    }
}