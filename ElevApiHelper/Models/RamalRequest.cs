using Newtonsoft.Json;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace ElevApiHelper.Models
{
    /// <summary>
    /// 
    /// </summary>
    public class RamalRequest
    {
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("ramal")]
        public int Ramal { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("nome")]
        public string? Nome { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("fk_grupo")]
        public int FkGrupo { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("fk_centrodecusto")]
        public int FkCentrodecusto { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("fk_grupo_captura")]
        public int FkGrupoCaptura { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("fk_musiconhold")]
        public int FkMusiconhold { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("voicemail")]
        public int Voicemail { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("voicemail_senha")]
        public int VoicemailSenha { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("fk_usuario")]
        public int FkUsuario { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("voicemail_numero")]
        public int VoicemailNumero { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("bina")]
        public bool Bina { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("bina_config")]
        public string? BinaConfig { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("bina_numero")]
        public int BinaNumero { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("desvio")]
        public string? Desvio { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("centro_custo")]
        public bool CentroCusto { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("fk_centrodecusto_mult")]
        public List<int>? FkCentrodecustoMult { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("gravar_audio")]
        public bool GravarAudio { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("callback_chamar")]
        public bool CallbackChamar { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("callback_chamado")]
        public bool CallbackChamado { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("conferencia")]
        public bool ConFerencia { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("conf_exclusiva")]
        public bool ConfExclusiva { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("conf_acessar")]
        public bool ConfAcessar { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("atalho_ddr")]
        public bool AtalhoDdr { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("login_automatico")]
        public bool LoginAutomatico { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("solicitar_senha")]
        public bool SolicitarSenha { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("identificador")]
        public int Identificador { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("senha")]
        public string? Senha { get; set; }
    }
}

