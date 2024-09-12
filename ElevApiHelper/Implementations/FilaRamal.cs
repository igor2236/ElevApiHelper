using ElevApiHelper.Interfaces;
using ElevApiHelper.Util;
using System;

namespace ElevApiHelper.Implementations
{
    internal static class FilaRamal
    { 

        //POST
        //fila-ramal
        //Cadastro de membros da fila
        /// <summary>
        /// 
        /// </summary>
        /// <param name="elevConfig"></param>
        /// <param name="filaRamalModel"></param>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        internal static object PostFilaRamal(IElevConfig elevConfig, IFilaRamalModel filaRamalModel)
        {
            throw new NotImplementedException();
        }

        //DELETE
        //fila-ramal
        //Remover membros da fila
        /// <summary>
        /// 
        /// </summary>
        /// <param name="elevConfig"></param>
        /// <param name="filaRamalDeleteDto"></param>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        internal static object DeleteFilaRamal(IElevConfig elevConfig, IFilaRamalDeleteDto filaRamalDeleteDto)
        {  
            throw new NotImplementedException(); 
        }

    }
}
