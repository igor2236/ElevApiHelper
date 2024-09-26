using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using ElevApiHelper.Models;

namespace ElevApiHelper.Interfaces
{
    /// <summary>
    /// 
    /// </summary>
    public interface IDiscadorAutomaticoService
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="campanha"></param>
        /// <param name="data_inicio"></param>
        /// <param name="data_fim"></param>
        /// <returns></returns>
        object GetMailing(string? campanha, string? data_inicio, string? data_fim);
        /// <summary>
        /// 
        /// </summary>
        /// <param name="mailing"></param>
        /// <returns></returns>
        object PostMailing(Mailing mailing);
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sort_by"></param>
        /// <param name="order_by"></param>
        /// <param name="campanha"></param>
        /// <param name="status_mailing"></param>
        /// <param name="tabulacao_ligacao"></param>
        /// <param name="ligacao_status"></param>
        /// <param name="telefone"></param>
        /// <param name="identificador"></param>
        /// <param name="tabulacao_ligacao_motivo"></param>
        /// <param name="data_inicio"></param>
        /// <param name="data_fim"></param>
        /// <param name="hora_inicio"></param>
        /// <param name="hora_fim"></param>
        /// <param name="page"></param>
        /// <param name="rows"></param>
        /// <returns></returns>
        object GetDiscagemAutomatica(string? sort_by, string? order_by, string? campanha,
            string? status_mailing, string? tabulacao_ligacao,string? ligacao_status, string? telefone,
            string? identificador,string? tabulacao_ligacao_motivo, string? data_inicio, string? data_fim,
            string? hora_inicio, string? hora_fim,int? page, int? rows);
    }
}
