using System;

namespace ElevApiHelper
{
    internal static class DiscagemOnline
    {
        //GET
        //discagem-online/discagem/{ramal}/{telefone}
        //Efetua uma ligação do ramal para o telefone passado pelos URL
        /// <summary>
        /// 
        /// </summary>
        /// <param name="ramal"></param>
        /// <param name="telefone"></param>
        /// <param name="Uri"></param>
        /// <param name="ApiKey"></param>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        internal static string Discagem(int ramal, int telefone, Uri Uri, string ApiKey)
        {
            throw new NotImplementedException();
        }

        //POST
        //discagem-online/login-ramal/
        //Efetua o login do ramal enviado.
        /// <summary>
        /// 
        /// </summary>
        /// <param name="loginRamalBody"></param>
        /// <param name="Uri"></param>
        /// <param name="ApiKey"></param>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        internal static object LoginRamal(LoginRamalBody loginRamalBody, Uri Uri, string ApiKey)
        {
            /*{
                "ramal": 1001,
                "posicao": 801,
                "senhaRamal": "1124816"
            }*/
            throw new NotImplementedException();
        }

        //GET
        //discagem-online/login-fila/{ramal}
        //Efetua o login do ramal na fila.
        /// <summary>
        /// 
        /// </summary>
        /// <param name="Uri"></param>
        /// <param name="ApiKey"></param>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        internal static object LoginFila(Uri Uri, string ApiKey)
        {
            throw new NotImplementedException();
        }

        //GET
        //discagem-online/logout-fila/{ramal}
        //Efetua o logout do ramal da fila.
        /// <summary>
        /// 
        /// </summary>
        /// <param name="ramal"></param>
        /// <param name="Uri"></param>
        /// <param name="ApiKey"></param>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        internal static object LogoutFila(int ramal, Uri Uri, string ApiKey)
        {
            throw new NotImplementedException();
        }

        //GET
        //discagem-online/pausa-ramal/{ramal}/{codPausa}
        //Efetua pausa/despausa do ramal selecionado.
        /// <summary>
        /// 
        /// </summary>
        /// <param name="ramal"></param>
        /// <param name="codPausa"></param>
        /// <param name="Uri"></param>
        /// <param name="ApiKey"></param>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        internal static object PausaRamal(int ramal, int codPausa, Uri Uri, string ApiKey)
        {
            throw new NotImplementedException();
        }

        //GET
        //discagem-online/discagem/{ramal}/{telefone1}/{ telefone2}
        //Efetua uma ligação que ir conectar dois telefones atráves de um ramal.
        /// <summary>
        /// 
        /// </summary>
        /// <param name="ramal"></param>
        /// <param name="telefone1"></param>
        /// <param name="telefone2"></param>
        /// <param name="dmf"></param>
        /// <param name="musicaEspera"></param>
        /// <param name="dadosPainel"></param>
        /// <param name="Uri"></param>
        /// <param name="ApiKey"></param>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        internal static object Discagem(int ramal, int telefone1, int telefone2,string dmf, string musicaEspera,string dadosPainel, Uri Uri, string ApiKey)
        {
            throw new NotImplementedException();
        }

        //GET
        //discagem-online​/relatorio
        //Efetua uma consulta no banco para retornar os dados em relatório.
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
        /// <param name="Uri"></param>
        /// <param name="ApiKey"></param>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        internal static object Relatorio(DateTime dataInicio, DateTime dataFim, int telefone1, int telefone2, string metodoIntegracao, string usuario, string ramal, Uri Uri, string ApiKey)
        {
            //datainicio: 01/01/2024
            throw new NotImplementedException();
        }

    }
}
