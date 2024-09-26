using ElevApiHelper.Interfaces;
using ElevApiHelper.Util;
using System;
using System.Collections.Generic;
using System.Text;

namespace ElevApiHelper.Services
{
    internal class PosicaoService : IPosicaoService
    {
        //GET
        //posicao/{posicao}
        //Lista posição do ID passado na url
        /// <summary>
        /// 
        /// </summary>
        /// <param name="config"></param>
        /// <param name="posicao"></param>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        public object GetPosicao(ElevConfig config, int posicao)
        {
            throw new NotImplementedException();
        }

        //GET
        //posicao
        //Pesquisa de posições
        /// <summary>
        /// 
        /// </summary>
        /// <param name="config"></param>
        /// <param name="page"></param>
        /// <param name="rows"></param>
        /// <param name="sort_by"></param>
        /// <param name="order_by"></param>
        /// <param name="ativo"></param>
        /// <param name="posicao"></param>
        /// <param name="fk_contexto"></param>
        /// <param name="fk_tipo"></param>
        /// <param name="ip"></param>
        /// <param name="status"></param>
        /// <param name="registro"></param>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        public object GetPosicao(ElevConfig config, 
            int? page = 1,
            int? rows = 5,
            string? sort_by = null,
            string? order_by = null,
            bool? ativo = null,
            string? posicao = null,
            int? fk_contexto = null,
            int? fk_tipo = null,
            string? ip = null,
            int? status = null,
            string? registro = null)
        {
            throw new NotImplementedException();
        }
    }
}
