using ElevApiHelper.Interfaces;
using ElevApiHelper.Models;
using ElevApiHelper.Util;
using System;

namespace ElevApiHelper.Services
{

    internal class LoginService : ILoginService
    {

        //POST
        //login
        //Verifica se retorna as informações do usúario.
        /// <summary>
        /// 
        /// </summary>
        /// <param name="config"></param>
        /// <param name="login"></param>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        public object PostLogin(ElevConfig config, LoginRequest login)
        {
            throw new NotImplementedException();
        }
    }
}
