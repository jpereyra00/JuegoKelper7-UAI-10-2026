using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kepler_7.Facade
{
    public class ControlCentral {
        private readonly Energia _energia = new Energia();
        private readonly SoporteVital _soporteVital = new SoporteVital();
        private readonly Navegacion _navegacion= new Navegacion();
        private readonly Comunicaciones _comunicaciones= new Comunicaciones();
        private readonly Seguridad _seguridad= new Seguridad();
        private readonly Defensa _defensa= new Defensa();

        public IEnumerable<string> iniciarTurno() {
            yield return "- Iniciando el turno operativo"; 
            yield return _energia.Encender();
            yield return _soporteVital.Activar();
            yield return _navegacion.Calibrar();
            yield return _comunicaciones.Abrir();
            yield return _seguridad.Rondar();
            yield return "- Estacion completamente Operativa";
          }
        public IEnumerable<string> EntrarEnEmergencia()
        {
            yield return "- ¡Alerta !- Entrando en modo Emergencia";
            yield return _defensa.ArmarEscudos();
            yield return _comunicaciones.Abrir();
            yield return _seguridad.Rondar();
            yield return _soporteVital.Minimizar();
            yield return "- Estacion en MODO EMERGENCIA ACTIVADO";
        }
        public IEnumerable<string> ApagarEstacion(){
            yield return "- ¡Apagando la estación... !";
            yield return _defensa.BajarEscudos();
            yield return _comunicaciones.Cerrar();
            yield return _soporteVital.Minimizar();
            yield return "- Estacion en reposo o apagado";
        }
    }
}
