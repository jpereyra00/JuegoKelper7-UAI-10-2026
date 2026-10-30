namespace Kepler_7
{
    partial class FrmControlCentral
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Panel pnlEncabezado;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblSubtitulo;
        private System.Windows.Forms.GroupBox grpOperaciones;
        private System.Windows.Forms.Button btnIniciarTurno;
        private System.Windows.Forms.Button btnEmergencia;
        private System.Windows.Forms.Button btnApagar;
        private System.Windows.Forms.Panel pnlEstado;
        private System.Windows.Forms.Label lblEstado;
        private System.Windows.Forms.GroupBox grpRegistro;
        private System.Windows.Forms.RichTextBox txtRegistro;
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
            this.grpOperaciones = new System.Windows.Forms.GroupBox();
            this.btnIniciarTurno = new System.Windows.Forms.Button();
            this.btnEmergencia = new System.Windows.Forms.Button();
            this.btnApagar = new System.Windows.Forms.Button();
            this.pnlEstado = new System.Windows.Forms.Panel();
            this.lblEstado = new System.Windows.Forms.Label();
            this.grpRegistro = new System.Windows.Forms.GroupBox();
            this.txtRegistro = new System.Windows.Forms.RichTextBox();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnCerrar = new System.Windows.Forms.Button();

            this.pnlEncabezado.SuspendLayout();
            this.grpOperaciones.SuspendLayout();
            this.pnlEstado.SuspendLayout();
            this.grpRegistro.SuspendLayout();
            this.SuspendLayout();

            // pnlEncabezado
            this.pnlEncabezado.BackColor =
                System.Drawing.Color.FromArgb(20, 33, 55);
            this.pnlEncabezado.Controls.Add(this.lblTitulo);
            this.pnlEncabezado.Controls.Add(this.lblSubtitulo);
            this.pnlEncabezado.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlEncabezado.Location = new System.Drawing.Point(0, 0);
            this.pnlEncabezado.Name = "pnlEncabezado";
            this.pnlEncabezado.Size = new System.Drawing.Size(800, 100);
            this.pnlEncabezado.TabIndex = 0;

            // lblTitulo
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold);
            this.lblTitulo.ForeColor = System.Drawing.Color.White;
            this.lblTitulo.Location = new System.Drawing.Point(22, 15);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Text = "KEPLER-7 | Control central";

            // lblSubtitulo
            this.lblSubtitulo.AutoSize = true;
            this.lblSubtitulo.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblSubtitulo.ForeColor = System.Drawing.Color.FromArgb(168, 190, 215);
            this.lblSubtitulo.Location = new System.Drawing.Point(26, 62);
            this.lblSubtitulo.Name = "lblSubtitulo";
            this.lblSubtitulo.Text = "Coordinación de los subsistemas de la estación.";

            // grpOperaciones
            this.grpOperaciones.Controls.Add(this.btnIniciarTurno);
            this.grpOperaciones.Controls.Add(this.btnEmergencia);
            this.grpOperaciones.Controls.Add(this.btnApagar);
            this.grpOperaciones.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.grpOperaciones.Location = new System.Drawing.Point(24, 118);
            this.grpOperaciones.Name = "grpOperaciones";
            this.grpOperaciones.Size = new System.Drawing.Size(752, 100);
            this.grpOperaciones.TabIndex = 1;
            this.grpOperaciones.TabStop = false;
            this.grpOperaciones.Text = "Operaciones de la estación";

            // btnIniciarTurno
            this.btnIniciarTurno.BackColor = System.Drawing.Color.FromArgb(0, 112, 160);
            this.btnIniciarTurno.FlatAppearance.BorderSize = 0;
            this.btnIniciarTurno.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIniciarTurno.ForeColor = System.Drawing.Color.White;
            this.btnIniciarTurno.Location = new System.Drawing.Point(20, 35);
            this.btnIniciarTurno.Name = "btnIniciarTurno";
            this.btnIniciarTurno.Size = new System.Drawing.Size(225, 42);
            this.btnIniciarTurno.TabIndex = 0;
            this.btnIniciarTurno.Text = "Iniciar turno";
            this.btnIniciarTurno.UseVisualStyleBackColor = false;
            this.btnIniciarTurno.Click += new System.EventHandler(this.btnIniciarTurno_Click);

            // btnEmergencia
            this.btnEmergencia.BackColor = System.Drawing.Color.FromArgb(190, 55, 55);
            this.btnEmergencia.FlatAppearance.BorderSize = 0;
            this.btnEmergencia.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEmergencia.ForeColor = System.Drawing.Color.White;
            this.btnEmergencia.Location = new System.Drawing.Point(263, 35);
            this.btnEmergencia.Name = "btnEmergencia";
            this.btnEmergencia.Size = new System.Drawing.Size(225, 42);
            this.btnEmergencia.TabIndex = 1;
            this.btnEmergencia.Text = "Activar emergencia";
            this.btnEmergencia.UseVisualStyleBackColor = false;
            this.btnEmergencia.Click += new System.EventHandler(this.btnEmergencia_Click);

            // btnApagar
            this.btnApagar.BackColor = System.Drawing.Color.FromArgb(75, 88, 108);
            this.btnApagar.FlatAppearance.BorderSize = 0;
            this.btnApagar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnApagar.ForeColor = System.Drawing.Color.White;
            this.btnApagar.Location = new System.Drawing.Point(506, 35);
            this.btnApagar.Name = "btnApagar";
            this.btnApagar.Size = new System.Drawing.Size(225, 42);
            this.btnApagar.TabIndex = 2;
            this.btnApagar.Text = "Apagar estación";
            this.btnApagar.UseVisualStyleBackColor = false;
            this.btnApagar.Click += new System.EventHandler(this.btnApagar_Click);

            // pnlEstado
            this.pnlEstado.BackColor = System.Drawing.Color.FromArgb(75, 88, 108);
            this.pnlEstado.Controls.Add(this.lblEstado);
            this.pnlEstado.Location = new System.Drawing.Point(24, 234);
            this.pnlEstado.Name = "pnlEstado";
            this.pnlEstado.Size = new System.Drawing.Size(752, 48);
            this.pnlEstado.TabIndex = 2;

            // lblEstado
            this.lblEstado.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblEstado.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lblEstado.ForeColor = System.Drawing.Color.White;
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Text = "CONTROL CENTRAL | Esperando operación";
            this.lblEstado.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            // grpRegistro
            this.grpRegistro.Controls.Add(this.txtRegistro);
            this.grpRegistro.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.grpRegistro.Location = new System.Drawing.Point(24, 298);
            this.grpRegistro.Name = "grpRegistro";
            this.grpRegistro.Size = new System.Drawing.Size(752, 290);
            this.grpRegistro.TabIndex = 3;
            this.grpRegistro.TabStop = false;
            this.grpRegistro.Text = "Registro de operaciones";

            // txtRegistro
            this.txtRegistro.BackColor = System.Drawing.Color.FromArgb(18, 26, 39);
            this.txtRegistro.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtRegistro.Font = new System.Drawing.Font("Consolas", 10F);
            this.txtRegistro.ForeColor = System.Drawing.Color.FromArgb(190, 221, 235);
            this.txtRegistro.Location = new System.Drawing.Point(18, 29);
            this.txtRegistro.Name = "txtRegistro";
            this.txtRegistro.ReadOnly = true;
            this.txtRegistro.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.txtRegistro.Size = new System.Drawing.Size(716, 242);
            this.txtRegistro.TabIndex = 0;
            this.txtRegistro.Text = "";

            // btnLimpiar
            this.btnLimpiar.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnLimpiar.Location = new System.Drawing.Point(24, 604);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(160, 38);
            this.btnLimpiar.TabIndex = 4;
            this.btnLimpiar.Text = "Limpiar registro";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click +=  new System.EventHandler(this.btnLimpiar_Click);

            // btnCerrar
            this.btnCerrar.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnCerrar.Location = new System.Drawing.Point(636, 604);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(140, 38);
            this.btnCerrar.TabIndex = 5;
            this.btnCerrar.Text = "Cerrar";
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);

            // FrmControlCentral
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(242, 245, 249);
            this.ClientSize = new System.Drawing.Size(800, 665);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.grpRegistro);
            this.Controls.Add(this.pnlEstado);
            this.Controls.Add(this.grpOperaciones);
            this.Controls.Add(this.pnlEncabezado);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FrmControlCentral";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kepler-7 - Control central";

            this.pnlEncabezado.ResumeLayout(false);
            this.pnlEncabezado.PerformLayout();
            this.grpOperaciones.ResumeLayout(false);
            this.pnlEstado.ResumeLayout(false);
            this.grpRegistro.ResumeLayout(false);
            this.ResumeLayout(false);
        }
    }
}