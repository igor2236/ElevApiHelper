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
        [JsonPropertyName("ramal")]
        public int Ramal { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonPropertyName("nome")]
        public string? Nome { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonPropertyName("fk_grupo")]
        public int FkGrupo { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonPropertyName("fk_centrodecusto")]
        public int FkCentrodecusto { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonPropertyName("fk_grupo_captura")]
        public int FkGrupoCaptura { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonPropertyName("fk_musiconhold")]
        public int FkMusiconhold { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonPropertyName("voicemail")]
        public int Voicemail { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonPropertyName("voicemail_senha")]
        public int VoicemailSenha { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonPropertyName("fk_usuario")]
        public int FkUsuario { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonPropertyName("voicemail_numero")]
        public int VoicemailNumero { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonPropertyName("bina")]
        public bool Bina { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonPropertyName("bina_config")]
        public string? BinaConfig { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonPropertyName("bina_numero")]
        public int BinaNumero { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonPropertyName("desvio")]
        public string? Desvio { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonPropertyName("centro_custo")]
        public bool CentroCusto { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonPropertyName("fk_centrodecusto_mult")]
        public List<int>? FkCentrodecustoMult { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonPropertyName("gravar_audio")]
        public bool GravarAudio { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonPropertyName("callback_chamar")]
        public bool CallbackChamar { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonPropertyName("callback_chamado")]
        public bool CallbackChamado { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonPropertyName("conferencia")]
        public bool ConFerencia { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonPropertyName("conf_exclusiva")]
        public bool ConfExclusiva { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonPropertyName("conf_acessar")]
        public bool ConfAcessar { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonPropertyName("atalho_ddr")]
        public bool AtalhoDdr { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonPropertyName("login_automatico")]
        public bool LoginAutomatico { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonPropertyName("solicitar_senha")]
        public bool SolicitarSenha { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonPropertyName("identificador")]
        public int Identificador { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonPropertyName("senha")]
        public string? Senha { get; set; }
    }
}

