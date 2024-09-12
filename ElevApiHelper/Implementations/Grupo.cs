using ElevApiHelper.Models;
using ElevApiHelper.Util;
using System;
using System.Collections.Generic;
using System.Text;

namespace ElevApiHelper.Implementations
{
    internal static class Grupo
    {
        //GET
        //grupo/{id}
        //Lista o grupo do ID passado na url
        /// <summary>
        /// 
        /// </summary>
        /// <param name="config"></param>
        /// <param name="id"></param>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        internal static object GetGrupo(ElevConfig config, int id)
        {
            throw new NotImplementedException();
        }

        //PUT
        //grupo/{id}
        //Edição de grupos
        /// <summary>
        /// 
        /// </summary>
        /// <param name="config"></param>
        /// <param name="id"></param>
        /// <param name="grupo"></param>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        internal static object PutGrupo(ElevConfig config, int id, GrupoModel grupo)
        {
            throw new NotImplementedException();
        }

        //DELETE
        //grupo/{id}
        //Desabilita o grupo do ID passado na url
        /// <summary>
        /// 
        /// </summary>
        /// <param name="config"></param>
        /// <param name="id"></param>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        internal static object DeleteGrupo(ElevConfig config, int id)
        {
            throw new NotImplementedException();
        }

        //GET
        //grupo
        //Pesquisa de grupos
        /// <summary>
        /// 
        /// </summary>
        /// <param name="config"></param>
        /// <param name="page"></param>
        /// <param name="rows"></param>
        /// <param name="sort_by"></param>
        /// <param name="order_by"></param>
        /// <param name="ativo"></param>
        /// <param name="nome"></param>
        /// <param name="fk_classe"></param>
        /// <param name="desvio"></param>
        /// <param name="pesquisa"></param>
        /// <param name="restricao_tempo"></param>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        internal static object GetGrupo(ElevConfig config,
            int? page = 1,
            int? rows = 5,
            string? sort_by = null,
            string? order_by = null,
            bool? ativo = null,
            string? nome = null,
            int? fk_classe = null,
            bool? desvio = null,
            bool? pesquisa = null,
            bool? restricao_tempo = null)
        {
            throw new NotImplementedException();
        }

        //POST
        //grupo
        //Cadastro de grupos
        /// <summary>
        /// 
        /// </summary>
        /// <param name="config"></param>
        /// <param name="grupo"></param>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        internal static object PostGrupo(ElevConfig config, GrupoModel grupo)
        {
            throw new NotImplementedException();
        }
    }
}
