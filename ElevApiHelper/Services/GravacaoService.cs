using ElevApiHelper.Interfaces;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace ElevApiHelper.Services
{
    internal class GravacaoService : IGravacoesService
    {
        //GET
        //busca-gravacoes
        //Verifica se retorna as informações das Gravações.
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sort_by">Ordenar por um campo especifico</param>
        /// <param name="order_by">Tipo de ordem (asc ou desc)</param>
        /// <param name="fk_ramal">Número do ramal do usuário.</param>
        /// <param name="fk_grupo">Grupo</param>
        /// <param name="id_usuario">Usuário</param>
        /// <param name="codigo">Código</param>
        /// <param name="telefone">Este campo se destina a busca pelas ligaçoes o qual se encontra na Origem.</param>
        /// <param name="destino">Este campo se destina a ligação que foi efetuada pelo discador,
        /// nesse caso inserir o telefone do cliente e deixar o campo fk_ramal vazio.</param>
        /// <param name="observacao">Observação</param>
        /// <param name="possui_observacao">Verifica se possuí observação.</param>
        /// <param name="fk_rota">Rota</param>
        /// <param name="duracao_inicio">Inicio de duração em minutagem da ligação.</param>
        /// <param name="duracao_fim">Fim de duração em minutagem da ligação.</param>
        /// <param name="origem_ligacao">Tipo de ligação que veio de origem.
        /// Available values : ramal / discador, ramal, discador</param>
        /// <param name="favorita">Tipo de ligação que veio de origem.</param>
        /// <param name="page">Pagina atual</param>
        /// <param name="rows">Quantidade de registros por pagina</param>
        /// <param name="tipo">Tipo de Chamadas. 
        /// <param name="inicio">Incio</param>
        /// <param name="fim">Fim</param>
        /// Available values : Entrada, Saida, Conferencia
        /// Default value : Entrada</param>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        public object GetGravacoes(
            string? sort_by,
            string? order_by,
            int? fk_ramal,
            int fk_grupo,
            int id_usuario,
            string? codigo, 
            int? telefone,
            int? destino,
            string? observacao,
            bool? possui_observacao, 
            string? fk_rota,
            int? duracao_inicio,
            int? duracao_fim,
            string? origem_ligacao,
            bool? favorita,
            int? page = 1, 
            int? rows = 15,
            string? tipo = "Entrada",
            string inicio = "01/01/2024",
            string fim = "01/01/2024")
        {
            throw new NotImplementedException();
        }
    }
}
