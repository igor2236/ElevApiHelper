using System;
using System.Collections.Generic;
using System.Text;

namespace ElevApiHelper.Models
{
    internal class GrupoModel
    {
        public string? Nome { get; set; }
        public int? FkClasse { get; set; }
        public bool? ChamadaTempo { get; set; }
        public int? LimiteTempo { get; set; }
        public bool? PausaSupervisor { get; set; }
        public bool? EntrarPausaSupervisor { get; set; }
        public int? FkGrupoSupervisor { get; set; }
        public bool? Pesquisa { get; set; }
        public string? Transferencia { get; set; }
        public int? FkPesquisa { get; set; }
        public bool? BloquearTecladoDiscador { get; set; }
        public bool? PausaRestringir { get; set; }
        public List<int>? Pausa { get; set; }
    }
}
