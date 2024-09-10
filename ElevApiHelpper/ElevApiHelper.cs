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

        public string Discagem(int ramal, int telefone)
        {
            var result = DiscagemOnline.Discagem(ramal, telefone, _Uri, _ApiKey);
            return result;
        }
    }
}
