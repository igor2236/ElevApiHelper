using ElevApiHelper.Models;
using ElevApiHelper.Dtos;
using ElevApiHelper.Util;
using System;
using ElevApiHelper.Interfaces;

namespace ElevApiHelper.Services
{
    internal class FilaRamalService : IFilaRamalService
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
        public object PostFilaRamal(ElevConfig elevConfig, FilaRamal filaRamalModel)
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
        public object DeleteFilaRamal(ElevConfig elevConfig, FilaRamalDeleteDto filaRamalDeleteDto)
        {  
            throw new NotImplementedException(); 
        }

    }
}
