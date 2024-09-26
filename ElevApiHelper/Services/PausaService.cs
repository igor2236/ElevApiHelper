using ElevApiHelper.Interfaces;
using ElevApiHelper.Util;
using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Text;

namespace ElevApiHelper.Services
{
    internal class PausaService : IPausaService
    {
        //GET
        //pausa/{id}
        //Lista a pausa pelo ID passado na url
        /// <summary>
        /// 
        /// </summary>
        /// <param name="config"></param>
        /// <param name="id"></param>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        public object GetPausa(ElevConfig config, int id)
        {
            throw new NotImplementedException();
        }

        //GET
        //pausa
        //Pesquisa de pausas
        /// <summary>
        /// 
        /// </summary>
        /// <param name="config"></param>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        public object GetPausa(ElevConfig config)
        { 
            throw new NotImplementedException(); 
        }
    }
}
