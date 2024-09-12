using ElevApiHelper.Enums;
using ElevApiHelper.Interfaces;
using ElevApiHelper.Util;
using System;

namespace ElevApiHelper.Implementations
{
    internal static class CentroDeCusto
    {
        //GET
        //centro-custo/{id}
        //Lista o centro de custo pelo ID passado na url
        /// <summary>
        /// 
        /// </summary>
        /// <param name="elevConfig"></param>
        /// <param name="id">ID do centro de custo</param>
        /// <param name="centroDeCustoRequestBody"></param>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        internal static object GetCentroDeCustoById(IElevConfig elevConfig, int id, ICentroDeCustoModel centroDeCustoRequestBody)
        {
            throw new NotImplementedException();
        }

        //PUT
        //centro-custo/{id}
        //Editar de centro de custo
        /// <summary>
        /// 
        /// </summary>
        /// <param name="elevConfig"></param>
        /// <param name="id">ID do centro de custo</param>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        internal static object PutCentroDeCusto(IElevConfig elevConfig, int id)
        {
            throw new NotImplementedException();
        }

        //DELETE
        //centro-custo/{id}
        //Desabilita o centro de custo do ID passado na url
        /// <summary>
        /// 
        /// </summary>
        /// <param name="elevConfig"></param>
        /// <param name="id">ID do centro de custo</param>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        internal static object DeleteCentroDeCusto(IElevConfig elevConfig, int id)
        {
            throw new NotImplementedException();
        }

        //GET
        //centro-custo
        //Pesquisa de centro de custo
        /// <summary>
        /// 
        /// </summary>
        /// <param name="elevConfig"></param>
        /// <param name="page">Pagina atual; Default value : 1</param>
        /// <param name="rows">Quantidade de registros por pagina; Default value : 5</param>
        /// <param name="sort_by">Ordenar por um campo especifico</param>
        /// <param name="order_by">Tipo de ordem (asc ou desc)</param>
        /// <param name="ativo">Filtro por ativo; Default value : true</param>
        /// <param name="nome">Filtro por nome</param>
        /// <param name="codigo">Filtro por codigo</param>
        /// <param name="fk_ramal">Filtro por fk_ramal</param>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        internal static object GetCentroDeCusto(IElevConfig elevConfig, int? page = 1, int? rows = 5, string? sort_by = null, string? order_by = null, bool ativo = true, string? nome = null, int? codigo = null, int? fk_ramal = null)
        {
            throw new NotImplementedException();
        }

        //POST
        //centro-custo
        //Cadastro de centro de custo
        /// <summary>
        /// 
        /// </summary>
        /// <param name="elevConfig"></param>
        /// <param name="centroDeCustoRequestBody"></param>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        internal static object PostCentroDeCusto(IElevConfig elevConfig, ICentroDeCustoModel centroDeCustoRequestBody)
        {
            throw new NotImplementedException();
        }
    }
}
