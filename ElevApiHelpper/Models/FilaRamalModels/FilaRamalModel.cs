using System;
using System.Collections.Generic;
using System.Text;
using ElevApiHelper.Interfaces.FilaRamalInterfaces;

namespace ElevApiHelper.Models.FilaRamalModels
{
    internal class FilaRamalModel : IFilaRamalModel
    {
        public int FkFila { get; set; }
        public int FkRamal { get; set; }
        public string? Acao { get; set; }
    }
}
