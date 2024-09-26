using ElevApiHelper.Interfaces;
using ElevApiHelper.Util;
using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics.CodeAnalysis;
using System.Diagnostics.Contracts;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;

namespace ElevApiHelper.Services
{
    internal class RamalService : IRamalService
    {
        //GET
        //ramal/{ramal}
        //Lista o ramal do numero passado na url
        /// <summary>
        /// 
        /// </summary>
        /// <param name="config"></param>
        /// <param name="ramal">Numero do ramal</param>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        public object GetRamal(ElevConfig config, int ramal)
        {
            throw new NotImplementedException();
        }

        //PUT
        //ramal​/{ramal}
        //Edicao de ramais
        /// <summary>
        /// 
        /// </summary>
        /// <param name="config"></param>
        /// <param name="ramal"></param>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        public object PutRamal(ElevConfig config, int ramal)
        {
            throw new NotImplementedException();
        }

        //DELETE
        //ramal​/{ramal}
        //Desabilita o ramal do ID passado na url
        /// <summary>
        /// 
        /// </summary>
        /// <param name="config"></param>
        /// <param name="ramal"></param>
        /// <param name="inativar_ramal_fila"></param>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        public object DeleteRamal(ElevConfig config, int ramal, bool? inativar_ramal_fila = null)
        {
            throw new NotImplementedException();
        }

        //GET
        //ramal
        //Pesquisa de ramais
        /// <summary>
        /// 
        /// </summary>
        /// <param name="config"></param>
        /// <param name="page">Pagina atual</param>
        /// <param name="rows">Quantidade de registros por pagina</param>
        /// <param name="sort_by">Ordenar por um campo especifico</param>
        /// <param name="order_by">Tipo de ordem (asc ou desc)</param>
        /// <param name="ativo">Filtro por ativo</param>
        /// <param name="nome">Filtro por nome</param>
        /// <param name="fk_grupo">Filtro por id de grupo</param>
        /// <param name="numero">Filtro por numero</param>
        /// <param name="posicao">Filtro por posicao</param>
        /// <param name="fk_grupo_captura">Filtro por id do grupo de captura</param>
        /// <param name="fk_centrodecusto">Filtro por id do centro de custo</param>
        /// <param name="pausados">Filtro por ramais pausados</param>
        /// <param name="gravar_audio">Filtro por gravar audio</param>
        /// <param name="desvio">Filtro por desvio</param>
        /// <param name="logado">Filtro por ramal logado</param>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        public object GetRamais(ElevConfig config, 
            int page = 1,
            int rows = 5,
            string? sort_by = null,
            string? order_by = null,
            bool ativo = true,
            string? nome = null,
            int? fk_grupo = null,
            int? numero = null,
            int? posicao = null,
            int? fk_grupo_captura = null,
            int? fk_centrodecusto = null,
            bool? pausados = null,
            bool? gravar_audio = null,
            bool? desvio = null,
            bool? logado = null)
        {
            throw new NotImplementedException();
        }

        //POST
        //ramal
        //Cadastro de ramais
        /// <summary>
        /// 
        /// </summary>
        /// <param name="config"></param>
        /// <param name="ramal"></param>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        public object PostRamal(ElevConfig config, Models.Ramal ramal)
        { 
            throw new NotImplementedException();
        }
    }
}
