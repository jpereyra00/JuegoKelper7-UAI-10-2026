using System;
using System.Drawing;
using System.Windows.Forms;

namespace Kepler_7
{
    public partial class FrmMenuPrincipal : Form
    {
        public FrmMenuPrincipal()
        {
            InitializeComponent();
        }
        private void btnRecorrido_Click(object sender, EventArgs e)
        {
            AbrirAreasDesde(0);
        }
        private void btnControlCentral_Click(object sender, EventArgs e)
        {
            AbrirAreasDesde(0);
        }
        private void btnHangar_Click(object sender, EventArgs e)
        {
            AbrirAreasDesde(1);
        }
        private void btnCombate_Click(object sender, EventArgs e)
        {
            AbrirAreasDesde(2);
        }
        private void AbrirAreasDesde(int indiceInicial)
        {
            Hide();

            try
            {
                for (int indice = indiceInicial; indice < 3; indice++)
                {
                    using (Form area = CrearArea(indice))
                    {
                        AgregarNavegacion(area, indice);

                        DialogResult resultado = area.ShowDialog(this);

                        // Solo avanzamos si se pulsó Siguiente.
                        if (resultado != DialogResult.OK)
                            break;
                    }
                }
                lblEstado.Text = "DEMOSTRACIÓN | Podés volver a ingresar a cualquier área.";
            }
            finally
            {
                Show();
                Activate();
            }
        }
        private Form CrearArea(int indice)
        {
            switch (indice)
            {
                case 0: return new FrmControlCentral();
                case 1: return new FrmConstructorNaves();
                case 2: return new FrmSimuladorIA();
                default: throw new ArgumentOutOfRangeException(nameof(indice));
            }
        }
        private void AgregarNavegacion(Form area, int indice)
        {
            Size tamanioOriginal = area.ClientSize;

            area.ClientSize = new Size(tamanioOriginal.Width, tamanioOriginal.Height + 62);

            var barra = new Panel
            {
                Name = "pnlNavegacionDemo",
                Location = new Point(0, tamanioOriginal.Height),
                Size = new Size(tamanioOriginal.Width, 62),
                BackColor = Color.FromArgb(20, 33, 55),
                Anchor = AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Bottom
            };

            var etiqueta = new Label
            {
                AutoSize = false,
                Location = new Point(18, 14),
                Size = new Size(260, 34),
                ForeColor = Color.White,
                TextAlign = ContentAlignment.MiddleLeft,
                Text = "RECORRIDO | Área " + (indice + 1) + " de 3"
            };

            var siguiente = new Button
            {
                Location = new Point(tamanioOriginal.Width - 270, 12),
                Size = new Size(250, 38),
                BackColor = Color.FromArgb(35, 160, 130),
                ForeColor = Color.White,
                FlatStyle = FlatStyle.Flat,
                Cursor = Cursors.Hand,

                // Cierra el diálogo indicando que debe avanzar.
                DialogResult = DialogResult.OK,

                Text = indice == 0 ? "Siguiente: Hangar →" : indice == 1 ? "Siguiente: Combate →" : "Finalizar y volver al menú"
            };

            siguiente.FlatAppearance.BorderSize = 0;

            barra.Controls.Add(etiqueta);
            barra.Controls.Add(siguiente);

            area.Controls.Add(barra);
            barra.BringToFront();
        }
        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}