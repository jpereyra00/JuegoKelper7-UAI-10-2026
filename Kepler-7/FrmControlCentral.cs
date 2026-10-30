using System;
using System.Collections.Generic;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;
using Kepler_7.Facade;

namespace Kepler_7
{
    public partial class FrmControlCentral : Form
    {
        private readonly ControlCentral _controlCentral = new ControlCentral();
        private bool _procesando;
        public FrmControlCentral()
        {
            InitializeComponent();
            ActualizarInterfaz();
        }
        private async void btnIniciarTurno_Click(object sender, EventArgs e)
        {
            await EjecutarOperacionAsync("INICIO / RESTABLECIMIENTO DEL TURNO",() => _controlCentral.iniciarTurno());
        }
        private async void btnEmergencia_Click(object sender, EventArgs e)
        {
            await EjecutarOperacionAsync("PROTOCOLO DE EMERGENCIA",() => _controlCentral.EntrarEnEmergencia());
        }
        private async void btnApagar_Click(object sender, EventArgs e)
        {
            await EjecutarOperacionAsync("APAGADO DE LA ESTACIÓN", () => _controlCentral.ApagarEstacion());
        }
        private async Task EjecutarOperacionAsync(string titulo, Func<IEnumerable<string>> operacion)
        {
            if (_procesando)
                return;

            _procesando = true;
            ActualizarInterfaz();

            pnlEstado.BackColor = Color.FromArgb(0, 112, 160);
            lblEstado.Text = "EJECUTANDO | " + titulo;

            try
            {
                if (txtRegistro.TextLength > 0)
                    txtRegistro.AppendText(Environment.NewLine);

                Registrar(titulo, Color.White);

                // La fachada valida y ejecuta la operación.
                IEnumerable<string> registro = operacion();

                foreach (string paso in registro)
                {
                    Registrar(paso, Color.FromArgb(190, 221, 235));

                    await Task.Delay(400);
                }
            }
            catch (InvalidOperationException ex)
            {
                Registrar("Operación rechazada: " + ex.Message, Color.Salmon);
            }
            catch (Exception ex)
            {
                Registrar("Error al ejecutar la operación: " + ex.Message, Color.Salmon);
            }
            finally
            {
                _procesando = false;
                ActualizarInterfaz();
            }
        }
        private void ActualizarInterfaz()
        {
            btnIniciarTurno.Enabled = !_procesando && _controlCentral.PuedeIniciarTurno;
            btnEmergencia.Enabled = !_procesando && _controlCentral.PuedeEntrarEnEmergencia;
            btnApagar.Enabled = !_procesando && _controlCentral.PuedeApagar;
            btnLimpiar.Enabled = !_procesando;
            btnCerrar.Enabled = !_procesando;
            btnIniciarTurno.Text =  _controlCentral.EstadoActual == EstadoEstacion.EnEmergencia ? "Restablecer operación" : "Iniciar turno";

            if (_procesando)
                return;

            switch (_controlCentral.EstadoActual)
            {
                case EstadoEstacion.Apagada:
                    pnlEstado.BackColor = Color.FromArgb(75, 88, 108);
                    lblEstado.Text = "ESTACIÓN APAGADA";
                    break;

                case EstadoEstacion.Operativa:
                    pnlEstado.BackColor = Color.FromArgb(28, 125, 74);
                    lblEstado.Text = "ESTACIÓN OPERATIVA";
                    break;

                case EstadoEstacion.EnEmergencia:
                    pnlEstado.BackColor = Color.FromArgb(190, 55, 55);
                    lblEstado.Text = "MODO EMERGENCIA ACTIVADO";
                    break;
            }
        }
        private void Registrar(string mensaje, Color color)
        {
            txtRegistro.SelectionStart = txtRegistro.TextLength;
            txtRegistro.SelectionLength = 0;
            txtRegistro.SelectionColor = color;

            txtRegistro.AppendText("[" + DateTime.Now.ToString("HH:mm:ss") + "] " + mensaje + Environment.NewLine);

            txtRegistro.SelectionStart = txtRegistro.TextLength;
            txtRegistro.ScrollToCaret();
        }
        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtRegistro.Clear();
        }
        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }
        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            if (_procesando && e.CloseReason == CloseReason.UserClosing)
            {
                e.Cancel = true;
            }
            base.OnFormClosing(e);
        }
    }
}