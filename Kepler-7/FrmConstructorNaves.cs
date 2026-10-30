using System;
using System.Drawing;
using System.Windows.Forms;
using Kepler_7.Builder;

namespace Kepler_7
{
    public partial class FrmConstructorNaves : Form
    {
        private readonly IngenieroJefe _ingeniero = new IngenieroJefe();
        private readonly InaveBuilder _builder = new NaveBuilder();

        // Permite recuperar la nave desde el formulario que abrió el hangar.
        public Nave NaveConstruida { get; private set; }
        public FrmConstructorNaves()
        {
            InitializeComponent();
            cmbReceta.SelectedIndex = 0;
        }
        private void btnConstruir_Click(object sender, EventArgs e)
        {
            switch (cmbReceta.SelectedIndex)
            {
                case 0:
                    NaveConstruida = _ingeniero.RecetaExploradora(_builder);
                    break;

                case 1:
                    NaveConstruida = _ingeniero.RecetaCombate(_builder);
                    break;

                case 2:
                    NaveConstruida = _ingeniero.RecetaCarga(_builder);
                    break;

                default:
                    MessageBox.Show("Seleccioná un tipo de nave.","Constructor de naves", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
            }

            MostrarNave(NaveConstruida);

            grpResultado.Text = "Nave ensamblada: " + cmbReceta.Text;

            lblEstado.ForeColor = Color.FromArgb(28, 125, 74);
            lblEstado.Text = "Construcción completada. Nave " + cmbReceta.Text.ToLower() + " lista.";
        }
        private void MostrarNave(Nave nave)
        {
            lvComponentes.BeginUpdate();

            try
            {
                lvComponentes.Items.Clear();

                AgregarComponente("Casco", nave.Casco);
                AgregarComponente("Motor", nave.Motor);
                AgregarComponente("Escudo", nave.Escudo);
                AgregarComponente("Armas", nave.Armas);
                AgregarComponente("Radar", nave.Radar);
                AgregarComponente("Tanque de combustible", nave.TanqueCombustible);
                AgregarComponente("Inteligencia artificial", nave.InteligenciaArtificial);
            }
            finally
            {
                lvComponentes.EndUpdate();
            }
        }
        private void AgregarComponente(string componente, string valor)
        {
            bool instalado = !string.IsNullOrWhiteSpace(valor) && valor != "-";

            var fila = new ListViewItem(componente);
            fila.SubItems.Add(instalado ? valor : "No instalado");

            if (!instalado)
                fila.ForeColor = Color.Gray;

            lvComponentes.Items.Add(fila);
        }
        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}