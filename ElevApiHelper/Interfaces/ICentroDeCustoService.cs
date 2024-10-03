using ElevApiHelper.Models;
using ElevApiHelper.Util;
using System;
using System.IO;
using System.Text.Json.Nodes;
using System.Threading.Tasks;

namespace ElevApiHelper.Interfaces
{
    /// <summary>
    /// 
    /// </summary>
    public interface ICentroDeCustoService
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        Task<JsonObject?> GetCentroDeCustoById(int id);
        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        /// <param name="centroDeCusto"></param>
        /// <returns></returns>
        object PutCentroDeCusto(int id, CentroDeCusto centroDeCusto);
        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        object DeleteCentroDeCusto(int id);
        /// <summary>
        /// 
        /// </summary>
        /// <param name="page"></param>
        /// <param name="rows"></param>
        /// <param name="sort_by"></param>
        /// <param name="order_by"></param>
        /// <param name="ativo"></param>
        /// <param name="nome"></param>
        /// <param name="codigo"></param>
        /// <param name="fk_ramal"></param>
        /// <returns></returns>
        object GetCentrosDeCusto(int? page = 1, int? rows = 5, string? sort_by = null, string? order_by = null, bool ativo = true, string? nome = null, int? codigo = null, int? fk_ramal = null);
        /// <summary>
        /// 
        /// </summary>
        /// <param name="centroDeCustoRequestBody"></param>
        /// <returns></returns>
        object PostCentroDeCusto(CentroDeCusto centroDeCustoRequestBody);
    }
}