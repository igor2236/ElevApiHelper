using ElevApiHelper.Util;

namespace ElevApiHelper.Interfaces.FilaRamalInterfaces
{
    internal interface IFilaRamal
    {
        object PostFilaRamal(IElevConfig elevConfig, IFilaRamalModel filaRamalModel);
        object DeleteFilaRamal(IElevConfig elevConfig, IFilaRamalDeleteDto filaRamalDeleteDto);
    }
}