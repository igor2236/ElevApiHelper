using ElevApiHelper.Util;
using ElevApiHelper.Models;
using ElevApiHelper.Interfaces;
using System;
using System.Net.Http;
using System.Threading.Tasks;
using System.Diagnostics;
using System.IO;
using System.Text.Json;
using System.Net.Http.Json;
using System.Text.Json.Nodes;
using System.Runtime.CompilerServices;
using ElevApiHelper.Models.CentroDeCusto;
using System.Collections.Generic;
using System.Runtime.Serialization;
using ElevApiHelper.Models.ControDeCusto;
using Newtonsoft.Json;

namespace ElevApiHelper.Services
{
    internal class CentroDeCustoService : ICentroDeCustoService
    {
        private readonly ElevConfig _config;
        private readonly HttpClient _httpClient;
        internal CentroDeCustoService(ElevConfig config, HttpClient client)
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
        public async Task<Wrapper<GetCentroDeCustoByIdResponse>> GetCentroDeCustoById(int id)
        {
            Wrapper <GetCentroDeCustoByIdResponse> response;
            try
            {
                response = await _httpClient.GetAsyncExtessinonSingleParameter<GetCentroDeCustoByIdResponse>(Endpoints.CentroDeCusto, id.ToString());

                return response;
            }
            catch (Exception)
            {
                throw;
            }
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
        public object PutCentroDeCusto(int id, PostCentroDeCustoRequest centroDeCusto)
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
     /// <param name="getCentroDeCustoParams"></param>
     /// <returns></returns>
        public async Task<Wrapper<GetCentroDeCustoResponse>> GetCentrosDeCusto(GetCentroDeCustoParams getCentroDeCustoParams)
        {
            Wrapper<GetCentroDeCustoResponse> response;
            try
            {
                string? json = string.IsNullOrEmpty(JsonConvert.SerializeObject(getCentroDeCustoParams, Formatting.Indented))
                    ?  
                JsonConvert.SerializeObject(getCentroDeCustoParams, Formatting.Indented);

                response = await _httpClient.GetAsyncExtessinonMultParameters<GetCentroDeCustoResponse>(Endpoints.CentroDeCusto, JsonConvert.DeserializeObject<Dictionary<string,object>>(getCentroDeCustoParams));
                return response;
            }
            catch (Exception)
            {
                throw;
            }
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
        public object PostCentroDeCusto(PostCentroDeCustoRequest centroDeCustoRequestBody)
        {
            throw new NotImplementedException();
        }
    }
}
