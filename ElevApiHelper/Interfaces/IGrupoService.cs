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
    public interface IGrupoService
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="config"></param>
        /// <param name="id"></param>
        /// <returns></returns>
        object GetGrupo(ElevConfig config, int id);
        /// <summary>
        /// 
        /// </summary>
        /// <param name="config"></param>
        /// <param name="id"></param>
        /// <param name="grupo"></param>
        /// <returns></returns>
        object PutGrupo(ElevConfig config, int id, GrupoRequest grupo);
        /// <summary>
        /// 
        /// </summary>
        /// <param name="config"></param>
        /// <param name="id"></param>
        /// <returns></returns>
        object DeleteGrupo(ElevConfig config, int id);
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
        /// <param name="fk_classe"></param>
        /// <param name="desvio"></param>
        /// <param name="pesquisa"></param>
        /// <param name="restricao_tempo"></param>
        /// <returns></returns>
        object GetGrupo(ElevConfig config,
            int? page = 1,
            int? rows = 5,
            string? sort_by = null,
            string? order_by = null,
            bool? ativo = null,
            string? nome = null,
            int? fk_classe = null,
            bool? desvio = null,
            bool? pesquisa = null,
            bool? restricao_tempo = null);
        /// <summary>
        /// 
        /// </summary>
        /// <param name="config"></param>
        /// <param name="grupo"></param>
        /// <returns></returns>
        object PostGrupo(ElevConfig config, GrupoRequest grupo);

    }
}
