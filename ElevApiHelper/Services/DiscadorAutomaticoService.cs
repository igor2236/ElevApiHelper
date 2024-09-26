using ElevApiHelper.Interfaces;
using ElevApiHelper.Models;

namespace ElevApiHelper.Services
{
    internal class DiscadorAutomaticoService : IDiscadorAutomaticoService
    {
        //GET
        //discador-automatico​/mailing
        //Análise de mailing
        /// <summary>
        /// 
        /// </summary>
        /// <param name="campanha">Filtro por campanha</param>
        /// <param name="data_inicio">Filtro por data inicial</param>
        /// <param name="data_fim">Filtro por data final</param>
        /// <returns></returns>
        /// <exception cref="System.NotImplementedException"></exception>
        public object GetMailing(string? campanha, string? data_inicio, string? data_fim)
        {
            throw new System.NotImplementedException();
        }

        //POST
        //discador-automatico/mailing
        //Cadastro de mailings
        /// <summary>
        /// 
        /// </summary>
        /// <param name="mailing"></param>
        /// <returns></returns>
        /// <exception cref="System.NotImplementedException"></exception>
        public object PostMailing(Mailing mailing)
        {
            throw new System.NotImplementedException();
        }

        //GET
        //discador-automatico​/discagem-automatica
        //Análise das discagens automáticas
        /// <summary>
        /// 
        /// </summary>
        /// <param name="page">Pagina atual</param>
        /// <param name="rows">Ordenar por um campo especifico</param>
        /// <param name="sort_by">Ordenar por um campo especifico</param>
        /// <param name="order_by">Tipo de ordem (asc ou desc)</param>
        /// <param name="campanha">Filtro por campanha</param>
        /// <param name="status_mailing">Filtro por status do mailing</param>
        /// <param name="tabulacao_ligacao">Filtro por tabulação</param>
        /// <param name="ligacao_status">Filtro por status da ligação</param>
        /// <param name="telefone">Filtro por telefone</param>
        /// <param name="identificador">Filtro por identificador</param>
        /// <param name="tabulacao_ligacao_motivo">Filtro por motivo da ligação</param>
        /// <param name="data_inicio">Filtro por data inicial</param>
        /// <param name="data_fim">Filtro por data final</param>
        /// <param name="hora_inicio">Filtro por hora inicial</param>
        /// <param name="hora_fim">Filtro por hora final</param>
        /// <returns></returns>
        /// <exception cref="System.NotImplementedException"></exception>
        public object GetDiscagemAutomatica( string? sort_by,
            string? order_by,
            string? campanha,
            string? status_mailing,
            string? tabulacao_ligacao, 
            string? ligacao_status, 
            string? telefone, 
            string? identificador, 
            string? tabulacao_ligacao_motivo, 
            string? data_inicio, 
            string? data_fim, 
            string? hora_inicio, 
            string? hora_fim, 
            int? page = 1, 
            int? rows = 5)
        {
            throw new System.NotImplementedException();
        }

   

    }
}
