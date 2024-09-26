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
    public interface IGrupoDeCapturaService
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="config"></param>
        /// <param name="id"></param>
        /// <returns></returns>
        object GetGrupoCaptura(ElevConfig config, int id);
        /// <summary>
        /// 
        /// </summary>
        /// <param name="config"></param>
        /// <param name="id"></param>
        /// <param name="grupoCaptura"></param>
        /// <returns></returns>
        object PutGrupoCaptura(ElevConfig config, int id, GrupoCaptura grupoCaptura);
        /// <summary>
        /// 
        /// </summary>
        /// <param name="config"></param>
        /// <param name="id"></param>
        /// <returns></returns>
        object DeleteGrupoCaptura(ElevConfig config, int id);
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
        /// <param name="codigo"></param>
        /// <returns></returns>
        object GetGrupoCaptura(ElevConfig config,
            int? page = 1,
            int? rows = 5,
            string? sort_by = null,
            string? order_by = null,
            bool? ativo = null,
            string? nome = null,
            int? codigo = null);
        /// <summary>
        /// 
        /// </summary>
        /// <param name="config"></param>
        /// <param name="grupoCaptura"></param>
        /// <returns></returns>
        object PostGrupoCaptura(ElevConfig config, GrupoCaptura grupoCaptura);
        
    }
}
