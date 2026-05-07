namespace pryEDRomoL
{
    partial class frmColores
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
            this.lstColores = new System.Windows.Forms.ListBox();
            this.btnRecorrer = new System.Windows.Forms.Button();
            this.btnListar = new System.Windows.Forms.Button();
            this.txtColores = new System.Windows.Forms.TextBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lstColores
            // 
            this.lstColores.FormattingEnabled = true;
            this.lstColores.Location = new System.Drawing.Point(12, 109);
            this.lstColores.Name = "lstColores";
            this.lstColores.Size = new System.Drawing.Size(302, 277);
            this.lstColores.TabIndex = 9;
            // 
            // btnRecorrer
            // 
            this.btnRecorrer.Enabled = false;
            this.btnRecorrer.Location = new System.Drawing.Point(238, 62);
            this.btnRecorrer.Name = "btnRecorrer";
            this.btnRecorrer.Size = new System.Drawing.Size(75, 23);
            this.btnRecorrer.TabIndex = 8;
            this.btnRecorrer.Text = "Recorrer";
            this.btnRecorrer.UseVisualStyleBackColor = true;
            this.btnRecorrer.Click += new System.EventHandler(this.btnRecorrer_Click);
            // 
            // btnListar
            // 
            this.btnListar.Location = new System.Drawing.Point(141, 62);
            this.btnListar.Name = "btnListar";
            this.btnListar.Size = new System.Drawing.Size(75, 23);
            this.btnListar.TabIndex = 7;
            this.btnListar.Text = "Listar";
            this.btnListar.UseVisualStyleBackColor = true;
            // 
            // txtColores
            // 
            this.txtColores.Location = new System.Drawing.Point(94, 28);
            this.txtColores.Name = "txtColores";
            this.txtColores.Size = new System.Drawing.Size(219, 20);
            this.txtColores.TabIndex = 6;
            this.txtColores.TextChanged += new System.EventHandler(this.txtNombre_TextChanged);
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.lblNombre.Location = new System.Drawing.Point(26, 28);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(62, 17);
            this.lblNombre.TabIndex = 5;
            this.lblNombre.Text = "Nombre:";
            // 
            // frmColores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(326, 396);
            this.Controls.Add(this.lstColores);
            this.Controls.Add(this.btnRecorrer);
            this.Controls.Add(this.btnListar);
            this.Controls.Add(this.txtColores);
            this.Controls.Add(this.lblNombre);
            this.Name = "frmColores";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Colores";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstColores;
        private System.Windows.Forms.Button btnRecorrer;
        private System.Windows.Forms.Button btnListar;
        private System.Windows.Forms.TextBox txtColores;
        private System.Windows.Forms.Label lblNombre;
    }
}