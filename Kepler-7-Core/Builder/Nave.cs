using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kepler_7.Builder
{
    public class Nave {
        public string Casco { get; set; } = "-";
        public string Motor { get; set; } = "-";
        public string Escudo { get; set; } = "-";
        public string Armas { get; set; } = "-";
        public string Radar { get; set; } = "-";
        public string TanqueCombustible { get; set; } = "-";
        public string InteligenciaArtificial { get; set; } = "-";

        public override string ToString() =>
            $"Casco: {Casco} | Motor: {Motor} | Escudo: {Escudo} | Armas: {Armas} | Radar: {Radar} | Tanque: {TanqueCombustible} | IA: {InteligenciaArtificial}";








    }
}
