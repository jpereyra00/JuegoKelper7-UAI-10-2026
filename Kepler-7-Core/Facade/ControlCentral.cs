using System;
using System.Collections.Generic;

namespace Kepler_7.Facade
{
    public enum EstadoEstacion
    {
        Apagada,
        Operativa,
        EnEmergencia
    }
    public class ControlCentral
    {
        private readonly Energia _energia = new Energia();
        private readonly SoporteVital _soporteVital = new SoporteVital();
        private readonly Navegacion _navegacion = new Navegacion();
        private readonly Comunicaciones _comunicaciones = new Comunicaciones();
        private readonly Seguridad _seguridad = new Seguridad();
        private readonly Defensa _defensa = new Defensa();
        public EstadoEstacion EstadoActual { get; private set; } = EstadoEstacion.Apagada;
        public bool PuedeIniciarTurno
        {
            get { return EstadoActual != EstadoEstacion.Operativa; }
        }
        public bool PuedeEntrarEnEmergencia
        {
            get { return EstadoActual == EstadoEstacion.Operativa; }
        }
        public bool PuedeApagar
        {
            get { return EstadoActual != EstadoEstacion.Apagada; }
        }
        public IEnumerable<string> iniciarTurno()
        {
            if (!PuedeIniciarTurno)
            {
                throw new InvalidOperationException("La estación ya está operativa.");
            }

            bool recuperando = EstadoActual == EstadoEstacion.EnEmergencia;

            var registro = new List<string>();

            registro.Add(recuperando ? "- Restableciendo el funcionamiento normal" : "- Iniciando el turno operativo");

            registro.Add(_energia.Encender());
            registro.Add(_soporteVital.Activar());
            registro.Add(_navegacion.Calibrar());
            registro.Add(_comunicaciones.Abrir());
            registro.Add(_seguridad.Rondar());

            if (recuperando)
                registro.Add(_defensa.BajarEscudos());

            EstadoActual = EstadoEstacion.Operativa;

            registro.Add("- Estación completamente operativa");

            return registro;
        }
        public IEnumerable<string> EntrarEnEmergencia()
        {
            if (!PuedeEntrarEnEmergencia)
            {
                throw new InvalidOperationException("Solo se puede activar la emergencia " + "cuando la estación está operativa.");
            }

            var registro = new List<string>();

            registro.Add("- Activando protocolo de emergencia");
            registro.Add(_defensa.ArmarEscudos());
            registro.Add(_comunicaciones.Abrir());
            registro.Add(_seguridad.Rondar());
            registro.Add(_soporteVital.Minimizar());

            EstadoActual = EstadoEstacion.EnEmergencia;

            registro.Add("- Modo emergencia activado");

            return registro;
        }

        public IEnumerable<string> ApagarEstacion()
        {
            if (!PuedeApagar)
            {
                throw new InvalidOperationException("La estación ya está apagada.");
            }

            var registro = new List<string>();

            registro.Add("- Apagando la estación");
            registro.Add(_defensa.BajarEscudos());
            registro.Add(_comunicaciones.Cerrar());
            registro.Add(_soporteVital.Minimizar());
            registro.Add(_energia.Apagar());

            EstadoActual = EstadoEstacion.Apagada;

            registro.Add("- Estación apagada");

            return registro;
        }
    }
}