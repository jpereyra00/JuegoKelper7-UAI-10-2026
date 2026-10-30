namespace Kepler_7
{
    partial class FrmMenuPrincipal
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Panel pnlEncabezado;
        private System.Windows.Forms.Label lblMarca;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblHistoria;
        private System.Windows.Forms.Label lblSecciones;
        private System.Windows.Forms.Button btnControlCentral;
        private System.Windows.Forms.Button btnHangar;
        private System.Windows.Forms.Button btnCombate;
        private System.Windows.Forms.Label lblDescripcionControl;
        private System.Windows.Forms.Label lblDescripcionHangar;
        private System.Windows.Forms.Label lblDescripcionCombate;
        private System.Windows.Forms.Button btnRecorrido;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Label lblEstado;

        protected override void Dispose(bool disposing)
        {
            if (disposing && components != null)
                components.Dispose();

            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.pnlEncabezado = new System.Windows.Forms.Panel();
            this.lblMarca = new System.Windows.Forms.Label();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblHistoria = new System.Windows.Forms.Label();
            this.lblSecciones = new System.Windows.Forms.Label();
            this.btnControlCentral = new System.Windows.Forms.Button();
            this.btnHangar = new System.Windows.Forms.Button();
            this.btnCombate = new System.Windows.Forms.Button();
            this.lblDescripcionControl = new System.Windows.Forms.Label();
            this.lblDescripcionHangar = new System.Windows.Forms.Label();
            this.lblDescripcionCombate = new System.Windows.Forms.Label();
            this.btnRecorrido = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.lblEstado = new System.Windows.Forms.Label();

            this.pnlEncabezado.SuspendLayout();
            this.SuspendLayout();

            // Encabezado
            this.pnlEncabezado.BackColor = System.Drawing.Color.FromArgb(20, 33, 55);
            this.pnlEncabezado.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlEncabezado.Size = new System.Drawing.Size(940, 230);
            this.pnlEncabezado.Controls.Add(this.lblMarca);
            this.pnlEncabezado.Controls.Add(this.lblTitulo);
            this.pnlEncabezado.Controls.Add(this.lblHistoria);

            this.lblMarca.AutoSize = true;
            this.lblMarca.Location = new System.Drawing.Point(35, 27);
            this.lblMarca.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblMarca.ForeColor = System.Drawing.Color.FromArgb(70, 210, 230);
            this.lblMarca.Text = "ESTACIÓN ORBITAL / CONSEJO DE INGENIERÍA";

            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Location = new System.Drawing.Point(28, 53);
            this.lblTitulo.Font = new System.Drawing.Font("Segoe UI", 42F, System.Drawing.FontStyle.Bold);
            this.lblTitulo.ForeColor = System.Drawing.Color.White;
            this.lblTitulo.Text = "KEPLER-7";

            this.lblHistoria.Location = new System.Drawing.Point(35, 145);
            this.lblHistoria.Size = new System.Drawing.Size(860, 65);
            this.lblHistoria.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lblHistoria.ForeColor = System.Drawing.Color.FromArgb(180, 198, 220);
            this.lblHistoria.Text = "Una crisis amenaza la estación. Activá sus sistemas, " + "prepará una nave y enfrentá las amenazas.\r\n" + "Tu misión comienza en el Control Central.";

            // Secciones
            this.lblSecciones.AutoSize = true;
            this.lblSecciones.Location = new System.Drawing.Point(35, 253);
            this.lblSecciones.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lblSecciones.ForeColor = System.Drawing.Color.FromArgb(180, 198, 220);
            this.lblSecciones.Text = "SELECCIONÁ UN ÁREA DE LA ESTACIÓN";

            // Control Central
            this.btnControlCentral.Location = new System.Drawing.Point(35, 295);
            this.btnControlCentral.Size = new System.Drawing.Size(275, 105);
            this.btnControlCentral.BackColor = System.Drawing.Color.FromArgb(0, 112, 160);
            this.btnControlCentral.ForeColor = System.Drawing.Color.White;
            this.btnControlCentral.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnControlCentral.FlatAppearance.BorderSize = 0;
            this.btnControlCentral.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.btnControlCentral.Text = "01\r\nCONTROL CENTRAL";
            this.btnControlCentral.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnControlCentral.UseVisualStyleBackColor = false;
            this.btnControlCentral.TabIndex = 0;
            this.btnControlCentral.Click += new System.EventHandler(this.btnControlCentral_Click);

            this.lblDescripcionControl.Location = new System.Drawing.Point(35, 414);
            this.lblDescripcionControl.Size = new System.Drawing.Size(275, 72);
            this.lblDescripcionControl.ForeColor = System.Drawing.Color.FromArgb(180, 198, 220);
            this.lblDescripcionControl.Text ="Coordiná los subsistemas y respondé ante emergencias.\r\n\r\n" + "Patrón: Facade";

            // Hangar
            this.btnHangar.Location = new System.Drawing.Point(332, 295);
            this.btnHangar.Size = new System.Drawing.Size(275, 105);
            this.btnHangar.BackColor = System.Drawing.Color.FromArgb(80, 65, 145);
            this.btnHangar.ForeColor = System.Drawing.Color.White;
            this.btnHangar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHangar.FlatAppearance.BorderSize = 0;
            this.btnHangar.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.btnHangar.Text = "02\r\nHANGAR DE NAVES";
            this.btnHangar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnHangar.UseVisualStyleBackColor = false;
            this.btnHangar.TabIndex = 1;
            this.btnHangar.Click += new System.EventHandler(this.btnHangar_Click);

            this.lblDescripcionHangar.Location = new System.Drawing.Point(332, 414);
            this.lblDescripcionHangar.Size = new System.Drawing.Size(275, 72);
            this.lblDescripcionHangar.ForeColor = System.Drawing.Color.FromArgb(180, 198, 220);
            this.lblDescripcionHangar.Text = "Ensamblá una nave a partir de las recetas disponibles.\r\n\r\n" + "Patrón: Builder";

            // Combate
            this.btnCombate.Location = new System.Drawing.Point(630, 295);
            this.btnCombate.Size = new System.Drawing.Size(275, 105);
            this.btnCombate.BackColor = System.Drawing.Color.FromArgb(155, 55, 65);
            this.btnCombate.ForeColor = System.Drawing.Color.White;
            this.btnCombate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCombate.FlatAppearance.BorderSize = 0;
            this.btnCombate.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.btnCombate.Text = "03\r\nSIMULADOR DE COMBATE";
            this.btnCombate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCombate.UseVisualStyleBackColor = false;
            this.btnCombate.TabIndex = 2;
            this.btnCombate.Click += new System.EventHandler(this.btnCombate_Click);

            this.lblDescripcionCombate.Location = new System.Drawing.Point(630, 414);
            this.lblDescripcionCombate.Size = new System.Drawing.Size(275, 72);
            this.lblDescripcionCombate.ForeColor = System.Drawing.Color.FromArgb(180, 198, 220);
            this.lblDescripcionCombate.Text ="Enfrentá un enemigo y cambiá su inteligencia artificial.\r\n\r\n" + "Patrón: Strategy";

            // Recorrido
            this.btnRecorrido.Location = new System.Drawing.Point(35, 515);
            this.btnRecorrido.Size = new System.Drawing.Size(572, 48);
            this.btnRecorrido.BackColor = System.Drawing.Color.FromArgb(35, 160, 130);
            this.btnRecorrido.ForeColor = System.Drawing.Color.White;
            this.btnRecorrido.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRecorrido.FlatAppearance.BorderSize = 0;
            this.btnRecorrido.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnRecorrido.Text = "INICIAR RECORRIDO POR LA ESTACIÓN";
            this.btnRecorrido.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRecorrido.UseVisualStyleBackColor = false;
            this.btnRecorrido.TabIndex = 3;
            this.btnRecorrido.Click += new System.EventHandler(this.btnRecorrido_Click);

            // Salir
            this.btnSalir.Location = new System.Drawing.Point(630, 515);
            this.btnSalir.Size = new System.Drawing.Size(275, 48);
            this.btnSalir.BackColor = System.Drawing.Color.FromArgb(35, 47, 65);
            this.btnSalir.ForeColor = System.Drawing.Color.White;
            this.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalir.FlatAppearance.BorderSize = 0;
            this.btnSalir.Text = "Salir del juego";
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.TabIndex = 4;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);

            // Estado
            this.lblEstado.Location = new System.Drawing.Point(35, 585);
            this.lblEstado.Size = new System.Drawing.Size(870, 30);
            this.lblEstado.ForeColor = System.Drawing.Color.FromArgb(140, 162, 185);
            this.lblEstado.Text ="DEMOSTRACIÓN | Tres áreas disponibles para explorar.";

            // Formulario
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode =System.Windows.Forms.AutoScaleMode.Font;
            this.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.BackColor =System.Drawing.Color.FromArgb(12, 20, 33);
            this.ClientSize = new System.Drawing.Size(940, 635);
            this.Controls.Add(this.pnlEncabezado);
            this.Controls.Add(this.lblSecciones);
            this.Controls.Add(this.btnControlCentral);
            this.Controls.Add(this.btnHangar);
            this.Controls.Add(this.btnCombate);
            this.Controls.Add(this.lblDescripcionControl);
            this.Controls.Add(this.lblDescripcionHangar);
            this.Controls.Add(this.lblDescripcionCombate);
            this.Controls.Add(this.btnRecorrido);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.lblEstado);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Name = "FrmMenuPrincipal";
            this.Text = "Kepler-7 | Menú principal";

            this.pnlEncabezado.ResumeLayout(false);
            this.pnlEncabezado.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}