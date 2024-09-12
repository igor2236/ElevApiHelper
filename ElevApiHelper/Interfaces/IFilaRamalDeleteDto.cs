using System;
using System.Collections.Generic;
using System.Text;

namespace ElevApiHelper.Interfaces
{
    internal interface IFilaRamalDeleteDto
    {
        int FkFila { get; set; }
        int FkRamal { get; set; }
    }
}
