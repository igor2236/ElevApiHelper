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
    public interface IFilaService
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="config"></param>
        /// <param name="id"></param>
        /// <returns></returns>
        object GetFila(ElevConfig config, int id);
        /// <summary>
        /// 
        /// </summary>
        /// <param name="config"></param>
        /// <param name="id"></param>
        /// <param name="fila"></param>
        /// <returns></returns>
        object PutFila(ElevConfig config, int id, FilaRequest fila);
        /// <summary>
        /// 
        /// </summary>
        /// <param name="config"></param>
        /// <param name="id"></param>
        /// <returns></returns>
        object DeleteFila(ElevConfig config, int id);
        /// <summary>
        /// 
        /// </summary>
        /// <param name="config"></param>
        /// <param name="page"></param>
        /// <param name="rows"></param>
        /// <param name="sort_by"></param>
        /// <param name="order_by"></param>
        /// <param name="ativo"></param>
        /// <param name="nome"></param>
        /// <param name="fk_estrategia"></param>
        /// <param name="fk_musiconhold"></param>
        /// <param name="fk_ramal"></param>
        /// <param name="fk_categoria"></param>
        /// <param name="pesquisa"></param>
        /// <returns></returns>
        object GetFila(ElevConfig config,
            int? page = 1,
            int? rows = 5,
            string? sort_by = null,
            string? order_by = "desc",
            bool ativo = true,
            string? nome = null,
            int? fk_estrategia = null,
            int? fk_musiconhold = null,
            int? fk_ramal = null,
            int? fk_categoria = null,
            bool? pesquisa = null);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="config"></param>
        /// <param name="fila"></param>
        /// <returns></returns>
        object PostFila(ElevConfig config, FilaRequest fila);
    }
}
