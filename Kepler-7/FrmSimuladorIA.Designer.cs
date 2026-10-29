namespace Kepler_7
{
    partial class FrmSimuladorIA
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Panel pnlEncabezado;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblSubtitulo;
        private System.Windows.Forms.GroupBox grpEstrategia;
        private System.Windows.Forms.ComboBox cmbEstrategia;
        private System.Windows.Forms.Label lblEstrategiaActual;
        private System.Windows.Forms.GroupBox grpContexto;
        private System.Windows.Forms.Label lblVidaEnemigo;
        private System.Windows.Forms.Label lblVidaJugador;
        private System.Windows.Forms.Label lblDistancia;
        private System.Windows.Forms.NumericUpDown numVidaEnemigo;
        private System.Windows.Forms.NumericUpDown numVidaJugador;
        private System.Windows.Forms.NumericUpDown numDistancia;
        private System.Windows.Forms.Button btnEjecutarTurno;
        private System.Windows.Forms.Label lblDecision;
        private System.Windows.Forms.GroupBox grpHistorial;
        private System.Windows.Forms.RichTextBox txtHistorial;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnCerrar;

        protected override void Dispose(bool disposing)
        {
            if (disposing && components != null)
                components.Dispose();

            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.pnlEncabezado = new System.Windows.Forms.Panel();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblSubtitulo = new System.Windows.Forms.Label();
            this.grpEstrategia = new System.Windows.Forms.GroupBox();
            this.cmbEstrategia = new System.Windows.Forms.ComboBox();
            this.lblEstrategiaActual = new System.Windows.Forms.Label();
            this.grpContexto = new System.Windows.Forms.GroupBox();
            this.lblVidaEnemigo = new System.Windows.Forms.Label();
            this.lblVidaJugador = new System.Windows.Forms.Label();
            this.lblDistancia = new System.Windows.Forms.Label();
            this.numVidaEnemigo = new System.Windows.Forms.NumericUpDown();
            this.numVidaJugador = new System.Windows.Forms.NumericUpDown();
            this.numDistancia = new System.Windows.Forms.NumericUpDown();
            this.btnEjecutarTurno = new System.Windows.Forms.Button();
            this.lblDecision = new System.Windows.Forms.Label();
            this.grpHistorial = new System.Windows.Forms.GroupBox();
            this.txtHistorial = new System.Windows.Forms.RichTextBox();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnCerrar = new System.Windows.Forms.Button();

            this.pnlEncabezado.SuspendLayout();
            this.grpEstrategia.SuspendLayout();
            this.grpContexto.SuspendLayout();
            this.grpHistorial.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numVidaEnemigo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numVidaJugador)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numDistancia)).BeginInit();
            this.SuspendLayout();

            // Encabezado
            this.pnlEncabezado.BackColor = System.Drawing.Color.FromArgb(20, 33, 55);
            this.pnlEncabezado.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlEncabezado.Size = new System.Drawing.Size(800, 100);
            this.pnlEncabezado.Controls.Add(this.lblTitulo);
            this.pnlEncabezado.Controls.Add(this.lblSubtitulo);

            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Location = new System.Drawing.Point(22, 15);
            this.lblTitulo.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold);
            this.lblTitulo.ForeColor = System.Drawing.Color.White;
            this.lblTitulo.Text = "KEPLER-7 | Simulador de IA";

            this.lblSubtitulo.AutoSize = true;
            this.lblSubtitulo.Location = new System.Drawing.Point(26, 62);
            this.lblSubtitulo.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblSubtitulo.ForeColor = System.Drawing.Color.FromArgb(168, 190, 215);
            this.lblSubtitulo.Text = "Cambiá la estrategia del enemigo y observá sus decisiones.";

            // Estrategia
            this.grpEstrategia.Location = new System.Drawing.Point(24, 116);
            this.grpEstrategia.Size = new System.Drawing.Size(752, 100);
            this.grpEstrategia.Text = "Estrategia del enemigo: Dron invasor";
            this.grpEstrategia.Controls.Add(this.cmbEstrategia);
            this.grpEstrategia.Controls.Add(this.lblEstrategiaActual);

            this.cmbEstrategia.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEstrategia.Items.AddRange(new object[]
            {
                "Agresiva",
                "Defensiva",
                "Aleatoria",
                "Calculadora"
            });
            this.cmbEstrategia.Location = new System.Drawing.Point(20, 38);
            this.cmbEstrategia.Size = new System.Drawing.Size(260, 28);
            this.cmbEstrategia.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.cmbEstrategia.TabIndex = 0;
            this.cmbEstrategia.SelectedIndexChanged += new System.EventHandler(this.cmbEstrategia_SelectedIndexChanged);

            this.lblEstrategiaActual.Location = new System.Drawing.Point(305, 32);
            this.lblEstrategiaActual.Size = new System.Drawing.Size(425, 48);
            this.lblEstrategiaActual.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblEstrategiaActual.Text = "IA activa: -";

            // Contexto
            this.grpContexto.Location = new System.Drawing.Point(24, 230);
            this.grpContexto.Size = new System.Drawing.Size(752, 112);
            this.grpContexto.Text = "Contexto del encuentro";
            this.grpContexto.Controls.Add(this.lblVidaEnemigo);
            this.grpContexto.Controls.Add(this.lblVidaJugador);
            this.grpContexto.Controls.Add(this.lblDistancia);
            this.grpContexto.Controls.Add(this.numVidaEnemigo);
            this.grpContexto.Controls.Add(this.numVidaJugador);
            this.grpContexto.Controls.Add(this.numDistancia);
            this.grpContexto.Controls.Add(this.btnEjecutarTurno);

            this.lblVidaEnemigo.AutoSize = true;
            this.lblVidaEnemigo.Location = new System.Drawing.Point(20, 29);
            this.lblVidaEnemigo.Text = "Vida enemigo";

            this.numVidaEnemigo.Location = new System.Drawing.Point(24, 56);
            this.numVidaEnemigo.Minimum = 1;
            this.numVidaEnemigo.Maximum = 100;
            this.numVidaEnemigo.Value = 100;
            this.numVidaEnemigo.Size = new System.Drawing.Size(135, 25);
            this.numVidaEnemigo.TabIndex = 0;

            this.lblVidaJugador.AutoSize = true;
            this.lblVidaJugador.Location = new System.Drawing.Point(185, 29);
            this.lblVidaJugador.Text = "Vida jugador";

            this.numVidaJugador.Location = new System.Drawing.Point(189, 56);
            this.numVidaJugador.Minimum = 1;
            this.numVidaJugador.Maximum = 100;
            this.numVidaJugador.Value = 100;
            this.numVidaJugador.Size = new System.Drawing.Size(135, 25);
            this.numVidaJugador.TabIndex = 1;

            this.lblDistancia.AutoSize = true;
            this.lblDistancia.Location = new System.Drawing.Point(350, 29);
            this.lblDistancia.Text = "Distancia";

            this.numDistancia.Location = new System.Drawing.Point(354, 56);
            this.numDistancia.Minimum = 0;
            this.numDistancia.Maximum = 100;
            this.numDistancia.Value = 5;
            this.numDistancia.Size = new System.Drawing.Size(135, 25);
            this.numDistancia.TabIndex = 2;

            this.btnEjecutarTurno.Location = new System.Drawing.Point(525, 46);
            this.btnEjecutarTurno.Size = new System.Drawing.Size(205, 42);
            this.btnEjecutarTurno.BackColor = System.Drawing.Color.FromArgb(0, 112, 160);
            this.btnEjecutarTurno.ForeColor = System.Drawing.Color.White;
            this.btnEjecutarTurno.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEjecutarTurno.FlatAppearance.BorderSize = 0;
            this.btnEjecutarTurno.Text = "Ejecutar turno";
            this.btnEjecutarTurno.UseVisualStyleBackColor = false;
            this.btnEjecutarTurno.TabIndex = 3;
            this.btnEjecutarTurno.Click += new System.EventHandler(this.btnEjecutarTurno_Click);

            // Última decisión
            this.lblDecision.Location = new System.Drawing.Point(24, 356);
            this.lblDecision.Size = new System.Drawing.Size(752, 70);
            this.lblDecision.BackColor = System.Drawing.Color.FromArgb(225, 234, 245);
            this.lblDecision.ForeColor = System.Drawing.Color.FromArgb(20, 33, 55);
            this.lblDecision.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lblDecision.Padding = new System.Windows.Forms.Padding(12);
            this.lblDecision.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblDecision.Text ="Ajustá el contexto y ejecutá un turno.";

            // Historial
            this.grpHistorial.Location = new System.Drawing.Point(24, 440);
            this.grpHistorial.Size = new System.Drawing.Size(752, 215);
            this.grpHistorial.Text = "Historial de decisiones";
            this.grpHistorial.Controls.Add(this.txtHistorial);

            this.txtHistorial.Location = new System.Drawing.Point(18, 28);
            this.txtHistorial.Size = new System.Drawing.Size(716, 169);
            this.txtHistorial.BackColor = System.Drawing.Color.FromArgb(18, 26, 39);
            this.txtHistorial.ForeColor = System.Drawing.Color.FromArgb(190, 221, 235);
            this.txtHistorial.Font = new System.Drawing.Font("Consolas", 10F);
            this.txtHistorial.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtHistorial.ReadOnly = true;
            this.txtHistorial.Text = "";
            this.txtHistorial.TabIndex = 0;

            // Botones inferiores
            this.btnLimpiar.Location = new System.Drawing.Point(24, 670);
            this.btnLimpiar.Size = new System.Drawing.Size(160, 38);
            this.btnLimpiar.Text = "Limpiar historial";
            this.btnLimpiar.TabIndex = 4;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);

            this.btnCerrar.Location = new System.Drawing.Point(636, 670);
            this.btnCerrar.Size = new System.Drawing.Size(140, 38);
            this.btnCerrar.Text = "Cerrar";
            this.btnCerrar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCerrar.TabIndex = 5;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);

            // Formulario
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.BackColor = System.Drawing.Color.FromArgb(242, 245, 249);
            this.ClientSize = new System.Drawing.Size(800, 730);
            this.Controls.Add(this.pnlEncabezado);
            this.Controls.Add(this.grpEstrategia);
            this.Controls.Add(this.grpContexto);
            this.Controls.Add(this.lblDecision);
            this.Controls.Add(this.grpHistorial);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnCerrar);
            this.AcceptButton = this.btnEjecutarTurno;
            this.CancelButton = this.btnCerrar;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Name = "FrmSimuladorIA";
            this.Text = "Kepler-7 - Simulador de IA";

            this.pnlEncabezado.ResumeLayout(false);
            this.pnlEncabezado.PerformLayout();
            this.grpEstrategia.ResumeLayout(false);
            this.grpContexto.ResumeLayout(false);
            this.grpContexto.PerformLayout();
            this.grpHistorial.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize) (this.numVidaEnemigo)).EndInit();
            ((System.ComponentModel.ISupportInitialize) (this.numVidaJugador)).EndInit();
            ((System.ComponentModel.ISupportInitialize) (this.numDistancia)).EndInit();
            this.ResumeLayout(false);
        }
    }
}