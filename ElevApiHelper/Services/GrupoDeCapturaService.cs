using ElevApiHelper.Util;
using ElevApiHelper.Models;
using System;
using ElevApiHelper.Interfaces;

namespace ElevApiHelper.Services
{
    internal class GrupoDeCapturaService : IGrupoDeCapturaService
    {
        //GET
        //grupo-captura/{id}
        //Lista o grupo de captura pelo ID passado na url
        /// <summary>
        /// 
        /// </summary>
        /// <param name="config"></param>
        /// <param name="id"></param>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        public object GetGrupoCaptura(ElevConfig config, int id)
        {
            throw new NotImplementedException();
        }

        //Put
        //grupo-captura/{id}
        //Editar de grupo de captura
        /// <summary>
        /// 
        /// </summary>
        /// <param name="config"></param>
        /// <param name="id"></param>
        /// <param name="grupoCaptura"></param>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        public object PutGrupoCaptura(ElevConfig config, int id, GrupoCapturaRequest grupoCaptura)
        { 
            throw new NotImplementedException(); 
        }

        //DELETE 
        //grupo-captura/{id}
        //Remove o grupo de captura do ID passado na url
        /// <summary>
        /// 
        /// </summary>
        /// <param name="config"></param>
        /// <param name="id"></param>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        public object DeleteGrupoCaptura(ElevConfig config, int id)
        {
            throw new NotImplementedException();
        }

        //GET
        //grupo-captura
        //Pesquisa de grupos
        /// <summary>
        /// 
        /// </summary>
        /// <param name="config"></param>
        /// <param name="page">Pagina atual; Default value : 1</param>
        /// <param name="rows">Quantidade de registros por pagina; Default value : 5</param>
        /// <param name="sort_by">Ordenar por um campo especifico</param>
        /// <param name="order_by">Tipo de ordem (asc ou desc)</param>
        /// <param name="ativo">Filtro por ativo;Default value : true</param>
        /// <param name="nome">Filtro por nome</param>
        /// <param name="codigo">Filtro por codigo</param>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        public object GetGrupoCaptura(ElevConfig config, 
            int? page = 1,
            int? rows = 5,
            string? sort_by = null,
            string? order_by = null,
            bool? ativo = null,
            string? nome = null,
            int? codigo = null)
        { 
            throw new NotImplementedException();
        }

        //POST
        //grupo-captura
        //Cadastro de grupo de captura
        /// <summary>
        /// 
        /// </summary>
        /// <param name="config"></param>
        /// <param name="grupoCaptura"></param>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        public object PostGrupoCaptura(ElevConfig config,GrupoCapturaRequest grupoCaptura)
        {
            throw new NotImplementedException();
        }
    }
}
