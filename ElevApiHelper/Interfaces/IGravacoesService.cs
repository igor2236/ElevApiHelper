using System;
using System.Collections.Generic;
using System.Text;

namespace ElevApiHelper.Interfaces
{
    /// <summary>
    /// 
    /// </summary>
    public interface IGravacoesService
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sort_by"></param>
        /// <param name="order_by"></param>
        /// <param name="fk_ramal"></param>
        /// <param name="fk_grupo"></param>
        /// <param name="id_usuario"></param>
        /// <param name="codigo"></param>
        /// <param name="telefone"></param>
        /// <param name="destino"></param>
        /// <param name="observacao"></param>
        /// <param name="possui_observacao"></param>
        /// <param name="fk_rota"></param>
        /// <param name="duracao_inicio"></param>
        /// <param name="duracao_fim"></param>
        /// <param name="origem_ligacao"></param>
        /// <param name="favorita"></param>
        /// <param name="page"></param>
        /// <param name="rows"></param>
        /// <param name="tipo"></param>
        /// <param name="inicio"></param>
        /// <param name="fim"></param>
        /// <returns></returns>
        object GetGravacoes( string? sort_by, 
            string? order_by, 
            int? fk_ramal,
            int fk_grupo, 
            int id_usuario, 
            string? codigo, 
            int? telefone, 
            int? destino,
            string? observacao, 
            bool? possui_observacao, 
            string? fk_rota, 
            int? duracao_inicio, 
            int? duracao_fim, 
            string? origem_ligacao, 
            bool? favorita, 
            int? page, 
            int? rows,
            string? tipo,
            string inicio,
            string fim);
    }
}
