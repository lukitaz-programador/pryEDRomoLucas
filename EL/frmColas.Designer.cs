namespace pryEDRomoL
{
    partial class frmColas
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dgvCola = new System.Windows.Forms.DataGridView();
            this.colCodigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDeuda = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.lstCola = new System.Windows.Forms.ListBox();
            this.gbListado = new System.Windows.Forms.GroupBox();
            this.gbNuevo = new System.Windows.Forms.GroupBox();
            this.txtTramite = new System.Windows.Forms.TextBox();
            this.lblTramite = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.gbEliminado = new System.Windows.Forms.GroupBox();
            this.lblTramiteRdo = new System.Windows.Forms.Label();
            this.lblNomRdo = new System.Windows.Forms.Label();
            this.lblCodRdo = new System.Windows.Forms.Label();
            this.lblCod = new System.Windows.Forms.Label();
            this.lblTramit = new System.Windows.Forms.Label();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.lblNomb = new System.Windows.Forms.Label();
            this.pbColas = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCola)).BeginInit();
            this.gbListado.SuspendLayout();
            this.gbNuevo.SuspendLayout();
            this.gbEliminado.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbColas)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvCola
            // 
            this.dgvCola.AllowUserToAddRows = false;
            this.dgvCola.AllowUserToDeleteRows = false;
            this.dgvCola.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCola.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colCodigo,
            this.colNombre,
            this.colDeuda});
            this.dgvCola.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvCola.Location = new System.Drawing.Point(189, 21);
            this.dgvCola.Name = "dgvCola";
            this.dgvCola.RowHeadersVisible = false;
            this.dgvCola.RowHeadersWidth = 51;
            this.dgvCola.Size = new System.Drawing.Size(313, 158);
            this.dgvCola.TabIndex = 0;
            // 
            // colCodigo
            // 
            this.colCodigo.Frozen = true;
            this.colCodigo.HeaderText = "Código";
            this.colCodigo.MinimumWidth = 6;
            this.colCodigo.Name = "colCodigo";
            this.colCodigo.Width = 60;
            // 
            // colNombre
            // 
            this.colNombre.Frozen = true;
            this.colNombre.HeaderText = "Nombre";
            this.colNombre.MinimumWidth = 6;
            this.colNombre.Name = "colNombre";
            this.colNombre.Width = 125;
            // 
            // colDeuda
            // 
            this.colDeuda.Frozen = true;
            this.colDeuda.HeaderText = "Trámite";
            this.colDeuda.MinimumWidth = 6;
            this.colDeuda.Name = "colDeuda";
            this.colDeuda.Width = 125;
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(90, 28);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(62, 20);
            this.txtCodigo.TabIndex = 1;
            this.txtCodigo.TextChanged += new System.EventHandler(this.txtCodigo_TextChanged);
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Location = new System.Drawing.Point(18, 35);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(43, 13);
            this.lblCodigo.TabIndex = 0;
            this.lblCodigo.Text = "Código:";
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(21, 124);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(131, 34);
            this.btnAgregar.TabIndex = 6;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // lstCola
            // 
            this.lstCola.FormattingEnabled = true;
            this.lstCola.Location = new System.Drawing.Point(16, 19);
            this.lstCola.Name = "lstCola";
            this.lstCola.Size = new System.Drawing.Size(157, 160);
            this.lstCola.TabIndex = 1;
            // 
            // gbListado
            // 
            this.gbListado.Controls.Add(this.lstCola);
            this.gbListado.Controls.Add(this.dgvCola);
            this.gbListado.Location = new System.Drawing.Point(11, 191);
            this.gbListado.Name = "gbListado";
            this.gbListado.Size = new System.Drawing.Size(533, 204);
            this.gbListado.TabIndex = 13;
            this.gbListado.TabStop = false;
            this.gbListado.Text = "Listado en una Lista y una Grilla";
            // 
            // gbNuevo
            // 
            this.gbNuevo.Controls.Add(this.txtTramite);
            this.gbNuevo.Controls.Add(this.lblCodigo);
            this.gbNuevo.Controls.Add(this.lblTramite);
            this.gbNuevo.Controls.Add(this.txtCodigo);
            this.gbNuevo.Controls.Add(this.txtNombre);
            this.gbNuevo.Controls.Add(this.btnAgregar);
            this.gbNuevo.Controls.Add(this.lblNombre);
            this.gbNuevo.Location = new System.Drawing.Point(200, 21);
            this.gbNuevo.Name = "gbNuevo";
            this.gbNuevo.Size = new System.Drawing.Size(169, 164);
            this.gbNuevo.TabIndex = 0;
            this.gbNuevo.TabStop = false;
            this.gbNuevo.Text = "Nuevo Elemento";
            // 
            // txtTramite
            // 
            this.txtTramite.Location = new System.Drawing.Point(67, 91);
            this.txtTramite.Name = "txtTramite";
            this.txtTramite.Size = new System.Drawing.Size(85, 20);
            this.txtTramite.TabIndex = 5;
            this.txtTramite.TextChanged += new System.EventHandler(this.txtTramite_TextChanged);
            // 
            // lblTramite
            // 
            this.lblTramite.AutoSize = true;
            this.lblTramite.Location = new System.Drawing.Point(18, 91);
            this.lblTramite.Name = "lblTramite";
            this.lblTramite.Size = new System.Drawing.Size(45, 13);
            this.lblTramite.TabIndex = 4;
            this.lblTramite.Text = "Tramite:";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(67, 58);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(85, 20);
            this.txtNombre.TabIndex = 3;
            this.txtNombre.TextChanged += new System.EventHandler(this.txtNombre_TextChanged);
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(18, 62);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(47, 13);
            this.lblNombre.TabIndex = 2;
            this.lblNombre.Text = "Nombre:";
            // 
            // gbEliminado
            // 
            this.gbEliminado.Controls.Add(this.lblTramiteRdo);
            this.gbEliminado.Controls.Add(this.lblNomRdo);
            this.gbEliminado.Controls.Add(this.lblCodRdo);
            this.gbEliminado.Controls.Add(this.lblCod);
            this.gbEliminado.Controls.Add(this.lblTramit);
            this.gbEliminado.Controls.Add(this.btnEliminar);
            this.gbEliminado.Controls.Add(this.lblNomb);
            this.gbEliminado.Location = new System.Drawing.Point(375, 21);
            this.gbEliminado.Name = "gbEliminado";
            this.gbEliminado.Size = new System.Drawing.Size(169, 164);
            this.gbEliminado.TabIndex = 1;
            this.gbEliminado.TabStop = false;
            this.gbEliminado.Text = "Elemento Eliminado";
            // 
            // lblTramiteRdo
            // 
            this.lblTramiteRdo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblTramiteRdo.Location = new System.Drawing.Point(67, 90);
            this.lblTramiteRdo.Name = "lblTramiteRdo";
            this.lblTramiteRdo.Size = new System.Drawing.Size(85, 20);
            this.lblTramiteRdo.TabIndex = 5;
            // 
            // lblNomRdo
            // 
            this.lblNomRdo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblNomRdo.Location = new System.Drawing.Point(67, 61);
            this.lblNomRdo.Name = "lblNomRdo";
            this.lblNomRdo.Size = new System.Drawing.Size(85, 20);
            this.lblNomRdo.TabIndex = 3;
            // 
            // lblCodRdo
            // 
            this.lblCodRdo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblCodRdo.Location = new System.Drawing.Point(90, 34);
            this.lblCodRdo.Name = "lblCodRdo";
            this.lblCodRdo.Size = new System.Drawing.Size(62, 20);
            this.lblCodRdo.TabIndex = 1;
            // 
            // lblCod
            // 
            this.lblCod.AutoSize = true;
            this.lblCod.Location = new System.Drawing.Point(18, 35);
            this.lblCod.Name = "lblCod";
            this.lblCod.Size = new System.Drawing.Size(43, 13);
            this.lblCod.TabIndex = 0;
            this.lblCod.Text = "Código:";
            // 
            // lblTramit
            // 
            this.lblTramit.AutoSize = true;
            this.lblTramit.Location = new System.Drawing.Point(18, 91);
            this.lblTramit.Name = "lblTramit";
            this.lblTramit.Size = new System.Drawing.Size(45, 13);
            this.lblTramit.TabIndex = 4;
            this.lblTramit.Text = "Trámite:";
            // 
            // btnEliminar
            // 
            this.btnEliminar.Enabled = false;
            this.btnEliminar.Location = new System.Drawing.Point(21, 124);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(131, 34);
            this.btnEliminar.TabIndex = 6;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // lblNomb
            // 
            this.lblNomb.AutoSize = true;
            this.lblNomb.Location = new System.Drawing.Point(18, 61);
            this.lblNomb.Name = "lblNomb";
            this.lblNomb.Size = new System.Drawing.Size(47, 13);
            this.lblNomb.TabIndex = 2;
            this.lblNomb.Text = "Nombre:";
            // 
            // pbColas
            // 
            this.pbColas.Location = new System.Drawing.Point(27, 22);
            this.pbColas.Name = "pbColas";
            this.pbColas.Size = new System.Drawing.Size(157, 146);
            this.pbColas.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbColas.TabIndex = 0;
            this.pbColas.TabStop = false;
            // 
            // frmColas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(560, 407);
            this.Controls.Add(this.gbEliminado);
            this.Controls.Add(this.gbNuevo);
            this.Controls.Add(this.gbListado);
            this.Controls.Add(this.pbColas);
            this.Name = "frmColas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Estructura Dinámica Lineal - Cola";
            ((System.ComponentModel.ISupportInitialize)(this.dgvCola)).EndInit();
            this.gbListado.ResumeLayout(false);
            this.gbNuevo.ResumeLayout(false);
            this.gbNuevo.PerformLayout();
            this.gbEliminado.ResumeLayout(false);
            this.gbEliminado.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbColas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pbColas;
        private System.Windows.Forms.DataGridView dgvCola;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.ListBox lstCola;
        private System.Windows.Forms.GroupBox gbListado;
        private System.Windows.Forms.GroupBox gbNuevo;
        private System.Windows.Forms.TextBox txtTramite;
        private System.Windows.Forms.Label lblTramite;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.GroupBox gbEliminado;
        private System.Windows.Forms.Label lblCod;
        private System.Windows.Forms.Label lblTramit;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Label lblNomb;
        private System.Windows.Forms.Label lblTramiteRdo;
        private System.Windows.Forms.Label lblNomRdo;
        private System.Windows.Forms.Label lblCodRdo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCodigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDeuda;
    }
}