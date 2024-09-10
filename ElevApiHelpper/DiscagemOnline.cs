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
        /// <param name="uri"></param>
        /// <param name="apiKey"></param>
        /// <param name="ramal">Ramal que irá efetuar a ligação.</param>
        /// <param name="telefone">Telefone que irá receber a ligação.</param>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        internal static string Discagem(Uri uri, string apiKey, int ramal, int telefone)
        {
            throw new NotImplementedException();
        }

        //POST
        //discagem-online/login-ramal/
        //Efetua o login do ramal enviado.
        /// <summary>
        /// 
        /// </summary>
        /// <param name="uri"></param>
        /// <param name="apiKey"></param>
        /// <param name="loginRamalBody"></param>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        internal static object LoginRamal(Uri uri, string apiKey, LoginRamalRequestBody loginRamalBody)
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
        /// <param name="uri"></param>
        /// <param name="apiKey"></param>
        /// <param name="ramal">Ramal que irá logar na fila.</param>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        internal static object LoginFila(Uri uri, string apiKey,int ramal)
        {
            throw new NotImplementedException();
        }

        //GET
        //discagem-online/logout-fila/{ramal}
        //Efetua o logout do ramal da fila.
        /// <summary>
        /// 
        /// </summary>
        /// <param name="uri"></param>
        /// <param name="apiKey"></param>
        /// <param name="ramal">Ramal que irá deslogar da fila.</param>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        internal static object LogoutFila(Uri uri, string apiKey,int ramal)
        {
            throw new NotImplementedException();
        }

        //GET
        //discagem-online/pausa-ramal/{ramal}/{codPausa}
        //Efetua pausa/despausa do ramal selecionado.
        /// <summary>
        /// 
        /// </summary>
        /// <param name="uri"></param>
        /// <param name="apiKey"></param>
        /// <param name="ramal">Ramal que irá ser pausado.</param>
        /// <param name="codPausa">Código da pausa irá ser utilizada no ramal.</param>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        internal static object PausaRamal(Uri uri, string apiKey, int ramal, int codPausa)
        {
            throw new NotImplementedException();
        }

        //GET
        //discagem-online/discagem/{ramal}/{telefone1}/{ telefone2}
        //Efetua uma ligação que ir conectar dois telefones atráves de um ramal.
        /// <summary>
        /// 
        /// </summary>
        /// <param name="uri"></param>
        /// <param name="apiKey"></param>
        /// <param name="ramal">Ramal que irá efetuar as discagem.</param>
        /// <param name="telefone1">Primeiro telefone que será discado.</param>
        /// <param name="telefone2">Segundo telefone que será discado.</param>
        /// <param name="dmf">Macro DTMF , usando o simbolo w para pausa de 500 milisegundos e numericos para o DTMF no contato do telefone1.</param>
        /// <param name="musicaEspera">ID da musica de espera em substituicao da default.</param>
        /// <param name="dadosPainel">Dados de painel do usuario.</param>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        internal static object Discagem(Uri uri, string apiKey, int ramal, int telefone1, int telefone2,string dmf, string musicaEspera,string dadosPainel)
        {
            throw new NotImplementedException();
        }

        //GET
        //discagem-online​/relatorio
        //Efetua uma consulta no banco para retornar os dados em relatório.
        /// <summary>
        /// 
        /// </summary>
        /// <param name="uri"></param>
        /// <param name="apiKey"></param>
        /// <param name="dataInicio">Format: 01/01/2024</param>
        /// <param name="dataFim">Format: 01/01/2024</param>
        /// <param name="telefone1"></param>
        /// <param name="telefone2">Caso ligação entre dois telefones</param>
        /// <param name="metodoIntegracao">Default value : login-fila</param>
        /// <param name="usuario">Colocar o login do usuário</param>
        /// <param name="ramal"></param>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        internal static object Relatorio(Uri uri, string apiKey, DateTime dataInicio, DateTime dataFim, int telefone1, int telefone2, string metodoIntegracao, string usuario, string ramal)
        {
            throw new NotImplementedException();
        }
    }
}
