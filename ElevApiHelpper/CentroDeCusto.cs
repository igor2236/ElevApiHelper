using ElevApiHelper.CentroDeCustoModels;
using System;
using System.Collections.Concurrent;
using System.Dynamic;

namespace ElevApiHelper
{
    internal static class CentroDeCusto
    { 

        //GET
​        //centro-custo​/{id}
        //Lista o centro de custo pelo ID passado na url
        /// <summary>
        /// 
        /// </summary>
        /// <param name="uri"></param>
        /// <param name="apiKey"></param>
        /// <param name="id"></param>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        internal static object GetCentroDeCustoById(Uri uri, string apiKey,int id)
        {
            throw new NotImplementedException();
        }

        //PUT
        //centro-custo/{id}
        //Editar de centro de custo
        /// <summary>
        /// 
        /// </summary>
        /// <param name="uri"></param>
        /// <param name="apiKey"></param>
        /// <param name="id"></param>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        internal static object PutCentroDeCusto(Uri uri, string apiKey,int id)
        {
            throw new NotImplementedException();
        }

        //DELETE
        //centro-custo/{id}
        //Desabilita o centro de custo do ID passado na url
        /// <summary>
        /// 
        /// </summary>
        /// <param name="uri"></param>
        /// <param name="apiKey"></param>
        /// <param name="id"></param>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        internal static object DeleteCentroDeCusto(Uri uri, string apiKey, int id)
        {
            throw new NotImplementedException();
        }

        //GET
        //centro-custo
        //Pesquisa de centro de custo
        /// <summary>
        /// 
        /// </summary>
        /// <param name="uri"></param>
        /// <param name="apiKey"></param>
        /// <param name="sort_by"></param>
        /// <param name="order_by"></param>
        /// <param name="nome"></param>
        /// <param name="codigo"></param>
        /// <param name="fk_ramal"></param>
        /// <param name="page"></param>
        /// <param name="rows"></param>
        /// <param name="ativo"></param>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        internal static object GetCentroDeCusto(Uri uri, string apiKey, string sort_by, string order_by, string nome,  int codigo, int fk_ramal, int page = 1, int rows = 5, bool ativo = true)
        {
            throw new NotImplementedException();
        }

        //POST
        //centro-custo
        //Cadastro de centro de custo
        /// <summary>
        /// 
        /// </summary>
        /// <param name="uri"></param>
        /// <param name="apiKey"></param>
        /// <param name="centroDeCustoRequestBody"></param>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        internal static object PostCentroDeCusto(Uri uri, string apiKey,CentroDeCustoRequestBody centroDeCustoRequestBody)
        {
            throw new NotImplementedException();
        }
    }
}
