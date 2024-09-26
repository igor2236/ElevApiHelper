using ElevApiHelper.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace ElevApiHelper.Interfaces
{
    /// <summary>
    /// 
    /// </summary>
    public interface IDiscagemOnlineService
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="ramal"></param>
        /// <param name="telefone"></param>
        /// <returns></returns>
        string Discagem(int ramal, int telefone);
        /// <summary>
        /// 
        /// </summary>
        /// <param name="loginRamalBody"></param>
        /// <returns></returns>
        object LoginRamal(LoginRamal loginRamalBody);
        /// <summary>
        /// 
        /// </summary>
        /// <param name="ramal"></param>
        /// <returns></returns>
        object LoginFila(int ramal);
        /// <summary>
        /// 
        /// </summary>
        /// <param name="ramal"></param>
        /// <returns></returns>
        object LogoutFila(int ramal);
        /// <summary>
        /// 
        /// </summary>
        /// <param name="ramal"></param>
        /// <param name="codPausa"></param>
        /// <returns></returns>
        object PausaRamal(int ramal, int codPausa);
        /// <summary>
        /// 
        /// </summary>
        /// <param name="ramal"></param>
        /// <param name="telefone1"></param>
        /// <param name="telefone2"></param>
        /// <param name="dmf"></param>
        /// <param name="musicaEspera"></param>
        /// <param name="dadosPainel"></param>
        /// <returns></returns>
        object Discagem(int ramal, int telefone1, int telefone2, string dmf, string musicaEspera, string dadosPainel);
        /// <summary>
        /// 
        /// </summary>
        /// <param name="dataInicio"></param>
        /// <param name="dataFim"></param>
        /// <param name="telefone1"></param>
        /// <param name="telefone2"></param>
        /// <param name="metodoIntegracao"></param>
        /// <param name="usuario"></param>
        /// <param name="ramal"></param>
        /// <returns></returns>
        object Relatorio(DateTime dataInicio, DateTime dataFim, int telefone1, int telefone2, string metodoIntegracao, string usuario, string ramal);
    }
}
