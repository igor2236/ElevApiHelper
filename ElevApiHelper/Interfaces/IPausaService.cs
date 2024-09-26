using ElevApiHelper.Util;
using System;
using System.Collections.Generic;
using System.Text;

namespace ElevApiHelper.Interfaces
{
    /// <summary>
    /// 
    /// </summary>
    public interface IPausaService
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="config"></param>
        /// <param name="id"></param>
        /// <returns></returns>
        public object GetPausa(ElevConfig config, int id);
        /// <summary>
        /// 
        /// </summary>
        /// <param name="config"></param>
        /// <returns></returns>
        public object GetPausa(ElevConfig config);
    }
}
