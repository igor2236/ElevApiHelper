using ElevApiHelper.Models;
using ElevApiHelper.Util;
using System;
using System.Collections.Generic;
using System.Text;

namespace ElevApiHelper.Interfaces
{
    /// <summary>
    /// 
    /// </summary>
    public interface ILoginService
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="config"></param>
        /// <param name="login"></param>
        /// <returns></returns>
        public object PostLogin(ElevConfig config, LoginModel login);
    }
}
