using ElevApiHelper.Util;
using ElevApiHelper.Models;
using ElevApiHelper.Interfaces;
using System;
using System.Net.Http;
using System.Runtime.CompilerServices;

namespace ElevApiHelper.Services
{
    internal class CentroDeCustoService : ICentroDeCustoService
    {
        private readonly ElevConfig _config;
        private readonly HttpClient _httpClient;
        internal CentroDeCustoService(ElevConfig config,HttpClient client)
        {
            _config = config;
            _httpClient = client;
        }

        //GET
        //centro-custo/{id}
        //Lista o centro de custo pelo ID passado na url
        /// <summary>
        /// 
        /// </summary>
        /// <param name="id">ID do centro de custo</param>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        public object GetCentroDeCustoById(int id)
        {
            return new object();
        }

        //PUT
        //centro-custo/{id}
        //Editar de centro de custo
        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        /// <param name="centroDeCusto"></param>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        public object PutCentroDeCusto(int id, CentroDeCusto centroDeCusto)
        {
            throw new NotImplementedException();
        }

        //DELETE
        //centro-custo/{id}
        //Desabilita o centro de custo do ID passado na url
        /// <summary>
        /// 
        /// </summary>
        /// <param name="id">ID do centro de custo</param>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        public object DeleteCentroDeCusto(int id)
        {
            throw new NotImplementedException();
        }

        //GET
        //centro-custo
        //Pesquisa de centro de custo
        /// <summary>
        /// 
        /// </summary>
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
        public object GetCentroDeCusto(int? page = 1, int? rows = 5, string? sort_by = null, string? order_by = null, bool ativo = true, string? nome = null, int? codigo = null, int? fk_ramal = null)
        {
            throw new NotImplementedException();
        }

        //POST
        //centro-custo
        //Cadastro de centro de custo
        /// <summary>
        /// 
        /// </summary>
        /// <param name="centroDeCustoRequestBody"></param>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        public object PostCentroDeCusto(CentroDeCusto centroDeCustoRequestBody)
        {
            throw new NotImplementedException();
        }
    }
}
