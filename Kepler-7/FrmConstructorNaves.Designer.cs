namespace Kepler_7
{
    partial class FrmConstructorNaves
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Panel pnlEncabezado;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblSubtitulo;
        private System.Windows.Forms.GroupBox grpConstruccion;
        private System.Windows.Forms.Label lblReceta;
        private System.Windows.Forms.ComboBox cmbReceta;
        private System.Windows.Forms.Button btnConstruir;
        private System.Windows.Forms.GroupBox grpResultado;
        private System.Windows.Forms.ListView lvComponentes;
        private System.Windows.Forms.ColumnHeader colComponente;
        private System.Windows.Forms.ColumnHeader colEquipamiento;
        private System.Windows.Forms.Label lblEstado;
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
            this.grpConstruccion = new System.Windows.Forms.GroupBox();
            this.lblReceta = new System.Windows.Forms.Label();
            this.cmbReceta = new System.Windows.Forms.ComboBox();
            this.btnConstruir = new System.Windows.Forms.Button();
            this.grpResultado = new System.Windows.Forms.GroupBox();
            this.lvComponentes = new System.Windows.Forms.ListView();
            this.colComponente = new System.Windows.Forms.ColumnHeader();
            this.colEquipamiento = new System.Windows.Forms.ColumnHeader();
            this.lblEstado = new System.Windows.Forms.Label();
            this.btnCerrar = new System.Windows.Forms.Button();

            this.pnlEncabezado.SuspendLayout();
            this.grpConstruccion.SuspendLayout();
            this.grpResultado.SuspendLayout();
            this.SuspendLayout();

            // pnlEncabezado
            this.pnlEncabezado.BackColor = System.Drawing.Color.FromArgb(20, 33, 55);
            this.pnlEncabezado.Controls.Add(this.lblTitulo);
            this.pnlEncabezado.Controls.Add(this.lblSubtitulo);
            this.pnlEncabezado.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlEncabezado.Location = new System.Drawing.Point(0, 0);
            this.pnlEncabezado.Name = "pnlEncabezado";
            this.pnlEncabezado.Size = new System.Drawing.Size(760, 100);
            this.pnlEncabezado.TabIndex = 0;

            // lblTitulo
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold);
            this.lblTitulo.ForeColor = System.Drawing.Color.White;
            this.lblTitulo.Location = new System.Drawing.Point(22, 15);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(450, 37);
            this.lblTitulo.Text = "KEPLER-7 | Hangar de construcción";

            // lblSubtitulo
            this.lblSubtitulo.AutoSize = true;
            this.lblSubtitulo.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblSubtitulo.ForeColor =
                System.Drawing.Color.FromArgb(168, 190, 215);
            this.lblSubtitulo.Location = new System.Drawing.Point(26, 62);
            this.lblSubtitulo.Name = "lblSubtitulo";
            this.lblSubtitulo.Text ="Seleccioná una receta y ensamblá una nave para la estación.";

            // grpConstruccion
            this.grpConstruccion.Controls.Add(this.lblReceta);
            this.grpConstruccion.Controls.Add(this.cmbReceta);
            this.grpConstruccion.Controls.Add(this.btnConstruir);
            this.grpConstruccion.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.grpConstruccion.Location = new System.Drawing.Point(24, 120);
            this.grpConstruccion.Name = "grpConstruccion";
            this.grpConstruccion.Size = new System.Drawing.Size(712, 118);
            this.grpConstruccion.TabIndex = 1;
            this.grpConstruccion.TabStop = false;
            this.grpConstruccion.Text = "Orden de construcción";

            // lblReceta
            this.lblReceta.AutoSize = true;
            this.lblReceta.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblReceta.Location = new System.Drawing.Point(20, 30);
            this.lblReceta.Name = "lblReceta";
            this.lblReceta.Text = "Tipo de nave";

            // cmbReceta
            this.cmbReceta.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbReceta.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.cmbReceta.FormattingEnabled = true;
            this.cmbReceta.Items.AddRange(new object[]
            {
                "Exploradora",
                "Combate",
                "Carga"
            });
            this.cmbReceta.Location = new System.Drawing.Point(24, 57);
            this.cmbReceta.Name = "cmbReceta";
            this.cmbReceta.Size = new System.Drawing.Size(430, 28);
            this.cmbReceta.TabIndex = 0;

            // btnConstruir
            this.btnConstruir.BackColor = System.Drawing.Color.FromArgb(0, 112, 160);
            this.btnConstruir.FlatAppearance.BorderSize = 0;
            this.btnConstruir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConstruir.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnConstruir.ForeColor = System.Drawing.Color.White;
            this.btnConstruir.Location = new System.Drawing.Point(478, 52);
            this.btnConstruir.Name = "btnConstruir";
            this.btnConstruir.Size = new System.Drawing.Size(210, 39);
            this.btnConstruir.TabIndex = 1;
            this.btnConstruir.Text = "Construir nave";
            this.btnConstruir.UseVisualStyleBackColor = false;
            this.btnConstruir.Click += new System.EventHandler(this.btnConstruir_Click);

            // grpResultado
            this.grpResultado.Controls.Add(this.lvComponentes);
            this.grpResultado.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.grpResultado.Location = new System.Drawing.Point(24, 254);
            this.grpResultado.Name = "grpResultado";
            this.grpResultado.Size = new System.Drawing.Size(712, 285);
            this.grpResultado.TabIndex = 2;
            this.grpResultado.TabStop = false;
            this.grpResultado.Text = "Nave ensamblada";

            // lvComponentes
            this.lvComponentes.Columns.AddRange(new System.Windows.Forms.ColumnHeader[]
                {
                    this.colComponente,
                    this.colEquipamiento
                });
            this.lvComponentes.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.lvComponentes.FullRowSelect = true;
            this.lvComponentes.GridLines = true;
            this.lvComponentes.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.lvComponentes.HideSelection = false;
            this.lvComponentes.Location = new System.Drawing.Point(24, 32);
            this.lvComponentes.MultiSelect = false;
            this.lvComponentes.Name = "lvComponentes";
            this.lvComponentes.Size = new System.Drawing.Size(664, 230);
            this.lvComponentes.TabIndex = 0;
            this.lvComponentes.UseCompatibleStateImageBehavior = false;
            this.lvComponentes.View = System.Windows.Forms.View.Details;

            // colComponente
            this.colComponente.Text = "Componente";
            this.colComponente.Width = 230;

            // colEquipamiento
            this.colEquipamiento.Text = "Equipamiento instalado";
            this.colEquipamiento.Width = 405;

            // lblEstado
            this.lblEstado.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblEstado.ForeColor = System.Drawing.Color.FromArgb(85, 99, 116);
            this.lblEstado.Location = new System.Drawing.Point(24, 559);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(540, 45);
            this.lblEstado.TabIndex = 3;
            this.lblEstado.Text = "Hangar listo. Esperando orden de construcción.";

            // btnCerrar
            this.btnCerrar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCerrar.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnCerrar.Location = new System.Drawing.Point(596, 557);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(140, 38);
            this.btnCerrar.TabIndex = 4;
            this.btnCerrar.Text = "Cerrar";
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);

            // FrmConstructorNaves
            this.AcceptButton = this.btnConstruir;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(242, 245, 249);
            this.CancelButton = this.btnCerrar;
            this.ClientSize = new System.Drawing.Size(760, 620);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.lblEstado);
            this.Controls.Add(this.grpResultado);
            this.Controls.Add(this.grpConstruccion);
            this.Controls.Add(this.pnlEncabezado);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FrmConstructorNaves";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kepler-7 - Constructor de naves";

            this.pnlEncabezado.ResumeLayout(false);
            this.pnlEncabezado.PerformLayout();
            this.grpConstruccion.ResumeLayout(false);
            this.grpConstruccion.PerformLayout();
            this.grpResultado.ResumeLayout(false);
            this.ResumeLayout(false);
        }
    }
}