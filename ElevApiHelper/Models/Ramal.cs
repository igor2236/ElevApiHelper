using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace ElevApiHelper.Models
{
    /// <summary>
    /// 
    /// </summary>
    public class Ramal
    {
        /// <summary>
        /// 
        /// </summary>
        public int ramal { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string? nome { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int fk_grupo { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int fk_centrodecusto { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int fk_grupo_captura { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int fk_musiconhold { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int voicemail { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int voicemail_senha { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int fk_usuario { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int voicemail_numero { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public bool bina { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string? bina_config { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int bina_numero { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string? desvio { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public bool centro_custo { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public List<int>? fk_centrodecusto_mult { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public bool gravar_audio { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public bool callback_chamar { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public bool callback_chamado { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public bool conferencia { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public bool conf_exclusiva { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public bool conf_acessar { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public bool atalho_ddr { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public bool login_automatico { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public bool solicitar_senha { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int identificador { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string? senha { get; set; }
    }
}

