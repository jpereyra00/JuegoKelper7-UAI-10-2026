using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kepler_7.Builder
{
    public class IngenieroJefe
    {
        public Nave RecetaCombate(InaveBuilder b) =>
            b.reiniciar()
            .PonerCasco("Ligero")
            .PonerMotor("Largo alcance")
            .PonerEscudo("Basico")
            .PonerRadar("Avanzado de rastreo")
            .PonerArmas("Ninguna")
            .Construir();

        public Nave RecetaExploradora(InaveBuilder b) =>
                 b.reiniciar()
                .PonerCasco("Blindado")
                .PonerMotor("Fusion")
                .PonerEscudo("Doble blindaje")
                .PonerRadar("Tactico")
                .PonerArmas("laser x4")
                .Construir();
        public Nave RecetaCarga(InaveBuilder b) =>
               b.reiniciar()
              .PonerCasco("Pesado Reforzado")
              .PonerMotor("Gasolina Turbo")
              .PonerEscudo("Basico")
              .PonerRadar("Estandar")
              .PonerArmas("Torre defensiva")
              .Construir();
    }


}
