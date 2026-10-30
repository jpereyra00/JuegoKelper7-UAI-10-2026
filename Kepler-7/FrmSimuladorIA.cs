using System;
using System.Windows.Forms;
using Kepler_7.Strategy;

namespace Kepler_7
{
    public partial class FrmSimuladorIA : Form
    {
        private readonly IEstrategiaIA[] _estrategias =
        {
            new IAAgresiva(),
            new IADefensiva(),
            new IAAleatoria(),
            new IACalculadora()
        };

        private readonly Enemigo _enemigo;
        // Se conserva el mismo contexto durante todo el combate.
        private Contexto _contexto;
        private int _numeroTurno;
        public FrmSimuladorIA()
        {
            InitializeComponent();

            numVidaEnemigo.Minimum = 0;
            numVidaEnemigo.Maximum = Contexto.VidaMaxima;
            numVidaJugador.Minimum = 0;
            numVidaJugador.Maximum = Contexto.VidaMaxima;
            numDistancia.Minimum = 0;
            numDistancia.Maximum = Contexto.DistanciaMaxima;
            btnEjecutarTurno.Text = "Jugar turno";
            btnLimpiar.Text = "Nuevo combate";
            _enemigo = new Enemigo("Dron invasor", _estrategias[0]);
            cmbEstrategia.SelectedIndex = 0;
            PrepararCombate();
        }
        private void cmbEstrategia_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (_enemigo == null || cmbEstrategia.SelectedIndex < 0)
            {
                return;
            }
            _enemigo.Estrategia = _estrategias[cmbEstrategia.SelectedIndex];
            ActualizarEtiquetaEstrategia();
            Registrar("Estrategia cambiada a " + _enemigo.Estrategia.nombre + ".");
            lblDecision.Text = "IA " + _enemigo.Estrategia.nombre + " seleccionada para el próximo turno.";
        }
        private void btnEjecutarTurno_Click(object sender, EventArgs e)
        {
            // Solo se crea al comenzar, no en cada turno.
            if (_contexto == null)
            {
                if (numVidaEnemigo.Value < 1 || numVidaJugador.Value < 1)
                {
                    MessageBox.Show("Ambos participantes deben iniciar con vida.","Configuración del combate", MessageBoxButtons.OK,MessageBoxIcon.Information);
                    return;
                }

                _contexto = new Contexto((int)numVidaEnemigo.Value,(int)numVidaJugador.Value,(int)numDistancia.Value);
                HabilitarConfiguracion(false);
                Registrar("COMBATE INICIADO");
            }

            if (_contexto.PartidaTerminada)
                return;

            _numeroTurno++;

            Registrar("");
            Registrar("TURNO " + _numeroTurno);

            // Primero actúa el jugador.
            string accionJugador =_contexto.JugarTurnoJugador();

            Registrar(accionJugador);

            string accionEnemigo = "";

            // El enemigo responde si sigue vivo.
            if (!_contexto.PartidaTerminada)
            {
                accionEnemigo = _enemigo.JugarTurno(_contexto);

                Registrar(accionEnemigo);
            }

            // Refleja el contexto actualizado en pantalla.
            ActualizarValores();
            ActualizarEtiquetaEstrategia();

            lblDecision.Text = accionJugador + Environment.NewLine + accionEnemigo;

            Registrar("Vida jugador: " + _contexto.VidaJugador + " | Vida enemigo: " + _contexto.VidaEnemigo + " | Distancia: " + _contexto.Distancia);

            if (_contexto.PartidaTerminada)
                FinalizarCombate();
        }
        private void ActualizarValores()
        {
            numVidaEnemigo.Value = _contexto.VidaEnemigo;
            numVidaJugador.Value = _contexto.VidaJugador;
            numDistancia.Value = _contexto.Distancia;
        }
        private void ActualizarEtiquetaEstrategia()
        {
            string detalle = "";

            if (_contexto != null)
            {
                detalle =" | Botiquines: " + _contexto.CuracionesEnemigo + " | Cubierto: " + (_contexto.EnemigoCubierto ? "Sí" : "No");
            }

            lblEstrategiaActual.Text ="IA: " + _enemigo.Estrategia.nombre + detalle;
        }
        private void FinalizarCombate()
        {
            string resultado = _contexto.VidaEnemigo <= 0 ? "¡VICTORIA! El enemigo fue derrotado." : "DERROTA. El jugador se quedó sin vida.";

            lblDecision.Text = resultado;
            Registrar(resultado);

            btnEjecutarTurno.Enabled = false;
            cmbEstrategia.Enabled = false;
        }
        private void HabilitarConfiguracion(bool habilitar)
        {
            numVidaEnemigo.Enabled = habilitar;
            numVidaJugador.Enabled = habilitar;
            numDistancia.Enabled = habilitar;
        }
        private void PrepararCombate()
        {
            _contexto = null;
            _numeroTurno = 0;

            numVidaEnemigo.Value = 100;
            numVidaJugador.Value = 100;
            numDistancia.Value = 5;

            HabilitarConfiguracion(true);

            btnEjecutarTurno.Enabled = true;
            cmbEstrategia.Enabled = true;

            txtHistorial.Clear();
            ActualizarEtiquetaEstrategia();

            lblDecision.Text ="Configurá el encuentro y pulsá Jugar turno. " + "El jugador ataca si está cerca o avanza; " + "después responde el enemigo.";

            Registrar("Nuevo combate preparado. IA: " + _enemigo.Estrategia.nombre + ".");
        }
        private void Registrar(string mensaje)
        {
            txtHistorial.AppendText(mensaje + Environment.NewLine);

            txtHistorial.SelectionStart =txtHistorial.TextLength;

            txtHistorial.ScrollToCaret();
        }
        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            PrepararCombate();
        }
        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}