using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MinhaCalculadoraDeSignos
{
    public class Signo
    {
        public string? Nome { get; set; }
        public int DiaInicio { get; set; }
        public int MesInicio { get; set; }
        public int DiaFim { get; set; }
        public int MesFim { get; set; }
        public string? Caracteristicas { get; set; }

    }
}