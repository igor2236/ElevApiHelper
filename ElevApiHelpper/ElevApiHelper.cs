using System;

namespace ElevApiHelper
{
    public class ElevApiHelper
    {
        public Uri _Uri;
        public string _ApiKey;

        public ElevApiHelper(Uri uri, string ApiKey)
        {
            _Uri = uri;
            _ApiKey = ApiKey;
        }
    }
}
