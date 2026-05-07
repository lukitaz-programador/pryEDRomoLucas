namespace pryEDRomoL
{
    partial class frmListaSimple
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
            this.gbEliminado = new System.Windows.Forms.GroupBox();
            this.cmbListaSimple = new System.Windows.Forms.ComboBox();
            this.lblCod = new System.Windows.Forms.Label();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.gbNuevo = new System.Windows.Forms.GroupBox();
            this.txtTramite = new System.Windows.Forms.TextBox();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.lblTramite = new System.Windows.Forms.Label();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.lblNombre = new System.Windows.Forms.Label();
            this.gbListado = new System.Windows.Forms.GroupBox();
            this.lstListaSimple = new System.Windows.Forms.ListBox();
            this.dgvListaSimple = new System.Windows.Forms.DataGridView();
            this.colCodigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDeuda = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pbColas = new System.Windows.Forms.PictureBox();
            this.gbEliminado.SuspendLayout();
            this.gbNuevo.SuspendLayout();
            this.gbListado.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaSimple)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbColas)).BeginInit();
            this.SuspendLayout();
            // 
            // gbEliminado
            // 
            this.gbEliminado.Controls.Add(this.cmbListaSimple);
            this.gbEliminado.Controls.Add(this.lblCod);
            this.gbEliminado.Controls.Add(this.btnEliminar);
            this.gbEliminado.Location = new System.Drawing.Point(370, 11);
            this.gbEliminado.Name = "gbEliminado";
            this.gbEliminado.Size = new System.Drawing.Size(169, 164);
            this.gbEliminado.TabIndex = 20;
            this.gbEliminado.TabStop = false;
            this.gbEliminado.Text = "Elemento a eliminar";
            // 
            // cmbListaSimple
            // 
            this.cmbListaSimple.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbListaSimple.FormattingEnabled = true;
            this.cmbListaSimple.Location = new System.Drawing.Point(55, 70);
            this.cmbListaSimple.Name = "cmbListaSimple";
            this.cmbListaSimple.Size = new System.Drawing.Size(97, 21);
            this.cmbListaSimple.TabIndex = 7;
            this.cmbListaSimple.SelectedIndexChanged += new System.EventHandler(this.cmbListaSimple_SelectedIndexChanged);
            // 
            // lblCod
            // 
            this.lblCod.AutoSize = true;
            this.lblCod.Location = new System.Drawing.Point(6, 73);
            this.lblCod.Name = "lblCod";
            this.lblCod.Size = new System.Drawing.Size(43, 13);
            this.lblCod.TabIndex = 0;
            this.lblCod.Text = "Código:";
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
            // gbNuevo
            // 
            this.gbNuevo.Controls.Add(this.txtTramite);
            this.gbNuevo.Controls.Add(this.lblCodigo);
            this.gbNuevo.Controls.Add(this.lblTramite);
            this.gbNuevo.Controls.Add(this.txtCodigo);
            this.gbNuevo.Controls.Add(this.txtNombre);
            this.gbNuevo.Controls.Add(this.btnAgregar);
            this.gbNuevo.Controls.Add(this.lblNombre);
            this.gbNuevo.Location = new System.Drawing.Point(195, 11);
            this.gbNuevo.Name = "gbNuevo";
            this.gbNuevo.Size = new System.Drawing.Size(169, 164);
            this.gbNuevo.TabIndex = 18;
            this.gbNuevo.TabStop = false;
            this.gbNuevo.Text = "Nuevo Elemento";
            // 
            // txtTramite
            // 
            this.txtTramite.Location = new System.Drawing.Point(67, 91);
            this.txtTramite.Name = "txtTramite";
            this.txtTramite.Size = new System.Drawing.Size(85, 20);
            this.txtTramite.TabIndex = 5;
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
            // lblTramite
            // 
            this.lblTramite.AutoSize = true;
            this.lblTramite.Location = new System.Drawing.Point(18, 91);
            this.lblTramite.Name = "lblTramite";
            this.lblTramite.Size = new System.Drawing.Size(45, 13);
            this.lblTramite.TabIndex = 4;
            this.lblTramite.Text = "Tramite:";
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(90, 28);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(62, 20);
            this.txtCodigo.TabIndex = 1;
            this.txtCodigo.TextChanged += new System.EventHandler(this.txtCodigo_TextChanged);
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(67, 58);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(85, 20);
            this.txtNombre.TabIndex = 3;
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
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(18, 62);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(47, 13);
            this.lblNombre.TabIndex = 2;
            this.lblNombre.Text = "Nombre:";
            // 
            // gbListado
            // 
            this.gbListado.Controls.Add(this.lstListaSimple);
            this.gbListado.Controls.Add(this.dgvListaSimple);
            this.gbListado.Location = new System.Drawing.Point(6, 181);
            this.gbListado.Name = "gbListado";
            this.gbListado.Size = new System.Drawing.Size(533, 204);
            this.gbListado.TabIndex = 21;
            this.gbListado.TabStop = false;
            this.gbListado.Text = "Listado en una Lista y una Grilla";
            // 
            // lstListaSimple
            // 
            this.lstListaSimple.FormattingEnabled = true;
            this.lstListaSimple.Location = new System.Drawing.Point(16, 19);
            this.lstListaSimple.Name = "lstListaSimple";
            this.lstListaSimple.Size = new System.Drawing.Size(157, 160);
            this.lstListaSimple.TabIndex = 1;
            // 
            // dgvListaSimple
            // 
            this.dgvListaSimple.AllowUserToAddRows = false;
            this.dgvListaSimple.AllowUserToDeleteRows = false;
            this.dgvListaSimple.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListaSimple.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colCodigo,
            this.colNombre,
            this.colDeuda});
            this.dgvListaSimple.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvListaSimple.Location = new System.Drawing.Point(189, 21);
            this.dgvListaSimple.Name = "dgvListaSimple";
            this.dgvListaSimple.RowHeadersVisible = false;
            this.dgvListaSimple.RowHeadersWidth = 51;
            this.dgvListaSimple.Size = new System.Drawing.Size(313, 158);
            this.dgvListaSimple.TabIndex = 0;
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
            // pbColas
            // 
            this.pbColas.Location = new System.Drawing.Point(12, 12);
            this.pbColas.Name = "pbColas";
            this.pbColas.Size = new System.Drawing.Size(177, 157);
            this.pbColas.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbColas.TabIndex = 19;
            this.pbColas.TabStop = false;
            // 
            // frmListaSimple
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(558, 400);
            this.Controls.Add(this.gbEliminado);
            this.Controls.Add(this.gbNuevo);
            this.Controls.Add(this.gbListado);
            this.Controls.Add(this.pbColas);
            this.Name = "frmListaSimple";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Estructura de datos lineal: Lista Simple";
            this.Load += new System.EventHandler(this.frmListaSimple_Load);
            this.gbEliminado.ResumeLayout(false);
            this.gbEliminado.PerformLayout();
            this.gbNuevo.ResumeLayout(false);
            this.gbNuevo.PerformLayout();
            this.gbListado.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaSimple)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbColas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbEliminado;
        private System.Windows.Forms.Label lblCod;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.GroupBox gbNuevo;
        private System.Windows.Forms.TextBox txtTramite;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.Label lblTramite;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.GroupBox gbListado;
        private System.Windows.Forms.ListBox lstListaSimple;
        private System.Windows.Forms.DataGridView dgvListaSimple;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCodigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDeuda;
        private System.Windows.Forms.PictureBox pbColas;
        private System.Windows.Forms.ComboBox cmbListaSimple;
    }
}