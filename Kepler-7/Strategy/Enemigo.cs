using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kepler_7.Strategy
{
    public class Enemigo {
        public string Nombre { get; }

        public IEstrategiaIA Estrategia { get; set; }

        public Enemigo(string nombre, IEstrategiaIA estrategiaInicial) {
            Nombre = nombre;
            Estrategia = estrategiaInicial;
        }
        public string JugarTurno(Contexto c) =>
            $"{Nombre}[IA {Estrategia.nombre}] -> {Estrategia.DecidirAccion(c)}";
    }
}
