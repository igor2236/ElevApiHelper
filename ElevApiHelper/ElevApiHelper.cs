using ElevApiHelper.Implementations;
using ElevApiHelper.Util;
using System.Diagnostics;

namespace ElevApiHelper
{
    public class ElevApiHelper
    {
        private readonly ElevConfig ElevConfig;
        public ElevApiHelper(ElevConfig elevConfig)
        {
            ElevConfig = elevConfig;
        }

        private void GetFila(int filaId)
        {
            Fila.GetFila(ElevConfig,filaId);
        }


    }
}
