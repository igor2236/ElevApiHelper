using ElevApiHelper.Interfaces.FilaRamalInterfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace ElevApiHelper.Models.FilaRamalModels
{
    internal class FilaRamalDeleteDto : IFilaRamalDeleteDto
    {
        public int FkFila { get; set; }
        public int FkRamal { get; set; }
    }
}
