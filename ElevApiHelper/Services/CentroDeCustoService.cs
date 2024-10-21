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
using System.Text.Json.Serialization;
using AJP;
using System.Reflection;

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
        public async Task<Wrapper<CentroDeCustoResponse>> GetCentroDeCustoById(int id)
        {
            Wrapper<CentroDeCustoResponse> response;
            try
            {
                response = await _httpClient.GetAsyncExtessinonSingleParameter<CentroDeCustoResponse>(Endpoints.CentroDeCusto, id.ToString());

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
        public async Task<Wrapper<GetCentrosDeCustoResponse>> GetCentrosDeCusto(GetCentroDeCustoParams getCentroDeCustoParams)
        {
            Wrapper<GetCentrosDeCustoResponse> response;
            try
            {
                //TODO: Pegar o JsonPropertyName
                Dictionary<string, object> parameters = new Dictionary<string, object>();
                foreach (var property in getCentroDeCustoParams.GetProperties())
                {
                    var jsonPropertyNameAttribute = getCentroDeCustoParams.GetType().GetCustomAttribute<JsonPropertyNameAttribute>().Name;
                    parameters.Add(jsonPropertyNameAttribute, property.Value);
                }




                string json = JsonConvert.SerializeObject(getCentroDeCustoParams, Formatting.Indented);
                //Dictionary<string, object>? parameters = JsonConvert.DeserializeObject<Dictionary<string, object>>(json);

                //string json = string.IsNullOrEmpty(JsonConvert.SerializeObject(getCentroDeCustoParams, Formatting.Indented))
                //? "" 
                //: JsonConvert.SerializeObject(getCentroDeCustoParams, Formatting.Indented);

                response = await _httpClient.GetAsyncExtessinonMultParameters<GetCentrosDeCustoResponse>(Endpoints.CentroDeCusto,parameters);
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
