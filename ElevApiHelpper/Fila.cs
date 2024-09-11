using ElevApiHelper.FilaModels;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using System.Threading;

namespace ElevApiHelper
{
    internal static class Fila
    {
        //GET
        //fila/{id}
        //Lista a fila pelo ID passado na url
        /// <summary>
        /// 
        /// </summary>
        /// <param name="uri"></param>
        /// <param name="apiKey"></param>
        /// <param name="id"></param>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        internal static object GetFila(Uri uri, string apiKey, int id)
        {
            throw new NotImplementedException();
        }

        //PUT
        //fila/{id}
        //Edicao de filas
        /// <summary>
        /// 
        /// </summary>
        /// <param name="uri"></param>
        /// <param name="apiKey"></param>
        /// <param name="id"></param>
        /// <param name="filaRequestBody"></param>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        internal static object PutFila(Uri uri, string apiKey, int id, FilaRequestBody filaRequestBody)
        {
            throw new NotImplementedException ();
        }

        //DELETE
        //fila/{id}
        //Desabilita a fila pelo ID passado na url
        /// <summary>
        /// 
        /// </summary>
        /// <param name="uri"></param>
        /// <param name="apiKey"></param>
        /// <param name="id"></param>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        internal static object DeleteFila(Uri uri, string apiKey, int id)
        { 
            throw new NotImplementedException ();
        }

        //GET
        //fila
        //Pesquisa de filas
        /// <summary>
        /// 
        /// </summary>
        /// <param name="uri"></param>
        /// <param name="apiKey"></param>
        /// <param name="page">Pagina atual; Default value : 1</param>
        /// <param name="rows">Quantidade de registros por pagina; Default value : 5</param>
        /// <param name="sort_by">Ordenar por um campo especifico</param>
        /// <param name="order_by">Tipo de ordem (asc ou desc)</param>
        /// <param name="ativo">Filtro por ativo; Default value : true</param>
        /// <param name="nome">Filtro por nome</param>
        /// <param name="fk_estrategia">Filtro por estrategia</param>
        /// <param name="fk_musiconhold">Filtro por audio hold</param>
        /// <param name="fk_ramal">Filtro por fk_ramal</param>
        /// <param name="fk_categoria">Filtro por categoria</param>
        /// <param name="pesquisa">Filtro por pesquisa</param>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        internal static object GetFila(Uri uri, string apiKey,
            int? page = 1,
            int? rows = 5,
            string? sort_by = null,
            string? order_by = "desc",
            bool ativo = true,
            string? nome = null,
            int? fk_estrategia = null,
            int? fk_musiconhold = null,
            int? fk_ramal = null,
            int? fk_categoria = null,
            bool? pesquisa = null
            )
        {
            throw new NotImplementedException();
        }

        //POST
        //fila
        //Cadastro de filas

        internal static object PostFila(Uri uri, string apiKey,FilaRequestBody filaRequestBody)
        {
            throw new NotImplementedException();
        }
    }
}
