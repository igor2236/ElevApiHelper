using ElevApiHelper.Util;
using System;
using ElevApiHelper.Models;
using System.Collections.Generic;
using System.Text;

namespace ElevApiHelper.Interfaces
{
    /// <summary>
    /// 
    /// </summary>
    public interface IRamalService
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="config"></param>
        /// <param name="ramal"></param>
        /// <returns></returns>
        object GetRamal(ElevConfig config, int ramal);
        
        /// <summary>
        /// 
        /// </summary>
        /// <param name="config"></param>
        /// <param name="ramal"></param>
        /// <returns></returns>
        object PutRamal(ElevConfig config, int ramal);
        /// <summary>
        /// 
        /// </summary>
        /// <param name="config"></param>
        /// <param name="ramal"></param>
        /// <param name="inativar_ramal_fila"></param>
        /// <returns></returns>
       object DeleteRamal(ElevConfig config, int ramal, bool? inativar_ramal_fila = null);
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
        /// <param name="fk_grupo"></param>
        /// <param name="numero"></param>
        /// <param name="posicao"></param>
        /// <param name="fk_grupo_captura"></param>
        /// <param name="fk_centrodecusto"></param>
        /// <param name="pausados"></param>
        /// <param name="gravar_audio"></param>
        /// <param name="desvio"></param>
        /// <param name="logado"></param>
        /// <returns></returns>
       object GetRamais(ElevConfig config,
            int page = 1,
            int rows = 5,
            string? sort_by = null,
            string? order_by = null,
            bool ativo = true,
            string? nome = null,
            int? fk_grupo = null,
            int? numero = null,
            int? posicao = null,
            int? fk_grupo_captura = null,
            int? fk_centrodecusto = null,
            bool? pausados = null,
            bool? gravar_audio = null,
            bool? desvio = null,
            bool? logado = null);
        /// <summary>
        /// 
        /// </summary>
        /// <param name="config"></param>
        /// <param name="ramal"></param>
        /// <returns></returns>
        public object PostRamal(ElevConfig config, Ramal ramal);

    }
}
