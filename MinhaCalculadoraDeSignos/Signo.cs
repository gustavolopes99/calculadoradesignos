using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MinhaCalculadoraDeSignos
{
    public class Signo
    {
        public string? nome { get; set; }
        public int diaInicio { get; set; }
        public int mesInicio { get; set; }
        public int diaFim { get; set; }
        public int mesFim { get; set; }
        public string? caracteristicas { get; set; }

    }
}