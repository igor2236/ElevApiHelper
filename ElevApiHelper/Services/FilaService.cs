using ElevApiHelper.Util;
using ElevApiHelper.Models;
using System;
using ElevApiHelper.Interfaces;

namespace ElevApiHelper.Services
{
    internal class FilaService : IFilaService
    {
        //GET
        //fila/{id}
        //Lista a fila pelo ID passado na url
        /// <summary>
        /// 
        /// </summary>
        /// <param name="config"></param>
        /// <param name="id"></param>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        public object GetFila(ElevConfig config, int id)
        {
            throw new NotImplementedException();
        }

        //PUT
        //fila/{id}
        //Edicao de filas
        /// <summary>
        /// 
        /// </summary>
        /// <param name="config"></param>
        /// <param name="id"></param>
        /// <param name="fila"></param>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        public object PutFila(ElevConfig config, int id, FilaRequest fila)
        {
            throw new NotImplementedException();
        }

        //DELETE
        //fila/{id}
        //Desabilita a fila pelo ID passado na url
        /// <summary>
        /// 
        /// </summary>
        /// <param name="config"></param>
        /// <param name="id"></param>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        public object DeleteFila(ElevConfig config, int id)
        {
            throw new NotImplementedException();
        }

        //GET
        //fila
        //Pesquisa de filas
        /// <summary>
        /// 
        /// </summary>
        /// <param name="config"></param>
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
        public object GetFila(ElevConfig config,
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
        /// <summary>
        /// 
        /// </summary>
        /// <param name="config"></param>
        /// <param name="fila"></param>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        public object PostFila(ElevConfig config, FilaRequest fila)
        {
            throw new NotImplementedException();
        }
    }
}
