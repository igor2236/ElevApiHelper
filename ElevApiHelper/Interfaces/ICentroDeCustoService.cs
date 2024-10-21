using ElevApiHelper.Models.CentroDeCusto;
using ElevApiHelper.Models.ControDeCusto;
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
        Task<Wrapper<CentroDeCustoResponse>> GetCentroDeCustoById(int id);
        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        /// <param name="centroDeCusto"></param>
        /// <returns></returns>
        object PutCentroDeCusto(int id, PostCentroDeCustoRequest centroDeCusto);
        
        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        object DeleteCentroDeCusto(int id);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="getCentroDeCustoParams"></param>
        /// <returns></returns>
        Task<Wrapper<GetCentrosDeCustoResponse>> GetCentrosDeCusto(GetCentroDeCustoParams getCentroDeCustoParams);
        
        /// <summary>
        /// 
        /// </summary>
        /// <param name="centroDeCustoRequestBody"></param>
        /// <returns></returns>
        object PostCentroDeCusto(PostCentroDeCustoRequest centroDeCustoRequestBody);
    }
}