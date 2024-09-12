using ElevApiHelper.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace ElevApiHelper.Dtos
{
    internal class FilaRamalDeleteDto : IFilaRamalDeleteDto
    {
        public int FkFila { get; set; }
        public int FkRamal { get; set; }
    }
}
