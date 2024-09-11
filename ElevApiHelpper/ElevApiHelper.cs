using ElevApiHelper.Util;

namespace ElevApiHelper
{
    public class ElevApiHelper
    {
        private ElevConfig ElevConfig { get; set; }
        public ElevApiHelper(ElevConfig elevConfig)
        {
            ElevConfig = elevConfig;
        }
    }
}
