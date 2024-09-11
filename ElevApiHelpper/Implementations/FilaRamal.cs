using ElevApiHelper.Interfaces.FilaRamalInterfaces;
using ElevApiHelper.Util;
using System;

namespace ElevApiHelper.Implementations
{
    internal class FilaRamal
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
        public object PostFilaRamal(IElevConfig elevConfig, IFilaRamalModel filaRamalModel)
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
        public object DeleteFilaRamal(IElevConfig elevConfig, IFilaRamalDeleteDto filaRamalDeleteDto)
        {  
            throw new NotImplementedException(); 
        }

    }
}
