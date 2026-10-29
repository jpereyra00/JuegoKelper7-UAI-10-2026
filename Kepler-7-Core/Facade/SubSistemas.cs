using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kepler_7.Facade
{
    public class Energia {
        public string Encender() => "Reactor principal en Linea";
        public string Apagar() => "Reactor en modo reposo o apagado";
    }
    public class SoporteVital {
        public string Activar() => "Soporte vital estabilidazo";
        public string Minimizar() => "Soporte vital en minimos";

    }
    public class Navegacion {
        public string Calibrar() => "Navegacion  calibrada y orientada";
    }
    public class Comunicaciones {
        public string Abrir() => "Canal con tierra abierto";
        public string Cerrar() => "Canal con tierra cerrado";

    }
    public class Seguridad {
        public string Rondar() => "Protocolos de seguridad activos";
    }
    public class Defensa {
        public string ArmarEscudos() => "Escudos de defensa armados y activos";
        public string BajarEscudos() => "Escudos desactivados";
    }
}
