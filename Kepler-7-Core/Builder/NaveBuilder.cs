using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kepler_7.Builder
{
    public class NaveBuilder : InaveBuilder {

        private Nave _nave = new Nave();

        public Nave Construir()
        {
            Nave resultado = _nave;
            reiniciar();
            return resultado;
        }

        public InaveBuilder PonerArmas(string armas)
        {
            _nave.Armas = armas;
            return this;
        }

        public InaveBuilder PonerCasco(string casco)
        {
            _nave.Casco = casco;
            return this;
        }

        public InaveBuilder PonerEscudo(string escudo)
        {
            _nave.Escudo = escudo;
            return this;
        }

        public InaveBuilder PonerMotor(string motor)
        {
            _nave.Motor = motor;
            return this;
        }

        public InaveBuilder PonerRadar(string radar)
        {
            _nave.Radar = radar;
            return this;
        }

           public InaveBuilder reiniciar()
        {
            _nave = new Nave();
            return this;
        }
    }
}
