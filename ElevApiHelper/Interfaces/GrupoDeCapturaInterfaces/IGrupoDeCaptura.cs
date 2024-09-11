using ElevApiHelper.Enums;
using ElevApiHelper.Util;
using System.Runtime.Serialization;

namespace ElevApiHelper.Interfaces.GrupoDeCapturaInterfaces
{
    internal interface IGrupoDeCaptura
    {
        object GetGrupoCaptura(IElevConfig elevConfig, int id);
        object PutGrupCaptura(IElevConfig elevConfig, int id, IGrupoCapturaModel grupoCaptura);
        object DeleteGrupoCaptura(IElevConfig elevConfig, int id);
        object GetGrupoDeCaptura(IElevConfig elevConfig,int page,int sortBy,string orderBy,bool ativo,string nome,int codigo);
        object PostGrupoCaptura(IElevConfig elevConfig, IGrupoCapturaModel grupoCaptura);
    }
}
