using System.Collections.Generic;

namespace ElevApiHelper.Models
{
    /// <summary>
    /// 
    /// </summary>
    public class Grupo
    {
        /// <summary>
        /// 
        /// </summary>
        public string? Nome { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int? FkClasse { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public bool? ChamadaTempo { get; set; }                   
        /// <summary>
        /// 
        /// </summary>
        public int? LimiteTempo { get; set; }                     
        /// <summary>
        /// 
        /// </summary>
        public bool? PausaSupervisor { get; set; }                
        /// <summary>
        /// 
        /// </summary>
        public bool? EntrarPausaSupervisor { get; set; }          
        /// <summary>
        /// 
        /// </summary>
        public int? FkGrupoSupervisor { get; set; }               
        /// <summary>
        /// 
        /// </summary>
        public bool? Pesquisa { get; set; }                       
        /// <summary>
        /// 
        /// </summary>
        public string? Transferencia { get; set; }                
        /// <summary>
        /// 
        /// </summary>
        public int? FkPesquisa { get; set; }                      
        /// <summary>
        /// 
        /// </summary>
        public bool? BloquearTecladoDiscador { get; set; }        
        /// <summary>
        /// 
        /// </summary>
        public bool? PausaRestringir { get; set; }                
        /// <summary>
        /// 
        /// </summary>
        public List<int>? Pausa { get; set; }            
    }
}
