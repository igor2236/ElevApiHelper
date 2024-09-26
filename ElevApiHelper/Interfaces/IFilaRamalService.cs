using ElevApiHelper.Dtos;
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
    public interface IFilaRamalService
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="elevConfig"></param>
        /// <param name="filaRamalModel"></param>
        /// <returns></returns>
        object PostFilaRamal(ElevConfig elevConfig, FilaRamal filaRamalModel);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="elevConfig"></param>
        /// <param name="filaRamalDeleteDto"></param>
        /// <returns></returns>
        object DeleteFilaRamal(ElevConfig elevConfig, FilaRamalDeleteDto filaRamalDeleteDto);
    }
}
