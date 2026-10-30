using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kepler_7.Builder
{
    public interface InaveBuilder {

        InaveBuilder reiniciar();
        InaveBuilder PonerCasco(string casco);
        InaveBuilder PonerMotor(string motor);
        InaveBuilder PonerEscudo(string escudo);
        InaveBuilder PonerArmas(string armas);
        InaveBuilder PonerRadar(string radar);

        Nave Construir();


    }
}
