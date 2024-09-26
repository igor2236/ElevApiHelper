using System;
using System.Collections.Generic;
using System.Text;

namespace ElevApiHelper.Models
{
    internal class Ramal
    {

  public int ramal { get; set; }
  public string? nome { get; set; }
  public int fk_grupo { get; set; }
  public int fk_centrodecusto { get; set; }
  public int fk_grupo_captura{ get; set; }
  public int fk_musiconhold { get; set; }
  public int voicemail { get; set; }
  public int voicemail_senha{ get; set; }
  public int fk_usuario { get; set; }
  public int voicemail_numero { get; set; }
  public bool bina { get; set; }
  public string? bina_config { get; set; }
  public int bina_numero { get; set; }
  public string? desvio { get; set; }
  public bool centro_custo {  get; set; }
  public List<int>? fk_centrodecusto_mult {  get; set; }
  public bool gravar_audio {  get; set; }
  public bool callback_chamar {  get; set; }
  public bool callback_chamado { get; set; }
  public bool conferencia {  get; set; }
  public bool conf_exclusiva {  get; set; }
  public bool conf_acessar {  get; set; }
  public bool atalho_ddr { get; set; }
  public bool login_automatico { get; set; }
  public bool solicitar_senha {  get; set; }
  public int identificador {  get; set; }
  public string? senha {  get; set; }
}
}

