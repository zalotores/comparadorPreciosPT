namespace VistaPrincipal
{
    partial class frmAdd
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
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblCategoria = new System.Windows.Forms.Label();
            this.lblPrecio = new System.Windows.Forms.Label();
            this.lblSucursal = new System.Windows.Forms.Label();
            this.lblObservaciones = new System.Windows.Forms.Label();
            this.lblFecha = new System.Windows.Forms.Label();
            this.txtNombreAdd = new System.Windows.Forms.TextBox();
            this.txtPrecioAdd = new System.Windows.Forms.TextBox();
            this.txtObservacionesAdd = new System.Windows.Forms.TextBox();
            this.cbxCategoriaAdd = new System.Windows.Forms.ComboBox();
            this.cbxSucursalAdd = new System.Windows.Forms.ComboBox();
            this.calendarioAdd = new System.Windows.Forms.MonthCalendar();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(43, 16);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(47, 13);
            this.lblNombre.TabIndex = 0;
            this.lblNombre.Text = "Nombre:";
            // 
            // lblCategoria
            // 
            this.lblCategoria.AutoSize = true;
            this.lblCategoria.Location = new System.Drawing.Point(33, 46);
            this.lblCategoria.Name = "lblCategoria";
            this.lblCategoria.Size = new System.Drawing.Size(57, 13);
            this.lblCategoria.TabIndex = 1;
            this.lblCategoria.Text = "Categoría:";
            // 
            // lblPrecio
            // 
            this.lblPrecio.AutoSize = true;
            this.lblPrecio.Location = new System.Drawing.Point(50, 76);
            this.lblPrecio.Name = "lblPrecio";
            this.lblPrecio.Size = new System.Drawing.Size(40, 13);
            this.lblPrecio.TabIndex = 2;
            this.lblPrecio.Text = "Precio:";
            // 
            // lblSucursal
            // 
            this.lblSucursal.AutoSize = true;
            this.lblSucursal.Location = new System.Drawing.Point(39, 105);
            this.lblSucursal.Name = "lblSucursal";
            this.lblSucursal.Size = new System.Drawing.Size(51, 13);
            this.lblSucursal.TabIndex = 3;
            this.lblSucursal.Text = "Sucursal:";
            // 
            // lblObservaciones
            // 
            this.lblObservaciones.AutoSize = true;
            this.lblObservaciones.Location = new System.Drawing.Point(12, 133);
            this.lblObservaciones.Name = "lblObservaciones";
            this.lblObservaciones.Size = new System.Drawing.Size(78, 13);
            this.lblObservaciones.TabIndex = 4;
            this.lblObservaciones.Text = "Obsevaciones:";
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Location = new System.Drawing.Point(297, 19);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(40, 13);
            this.lblFecha.TabIndex = 5;
            this.lblFecha.Text = "Fecha:";
            // 
            // txtNombreAdd
            // 
            this.txtNombreAdd.Location = new System.Drawing.Point(96, 12);
            this.txtNombreAdd.Name = "txtNombreAdd";
            this.txtNombreAdd.Size = new System.Drawing.Size(121, 20);
            this.txtNombreAdd.TabIndex = 6;
            // 
            // txtPrecioAdd
            // 
            this.txtPrecioAdd.Location = new System.Drawing.Point(96, 76);
            this.txtPrecioAdd.Name = "txtPrecioAdd";
            this.txtPrecioAdd.Size = new System.Drawing.Size(121, 20);
            this.txtPrecioAdd.TabIndex = 7;
            // 
            // txtObservacionesAdd
            // 
            this.txtObservacionesAdd.Location = new System.Drawing.Point(96, 133);
            this.txtObservacionesAdd.Multiline = true;
            this.txtObservacionesAdd.Name = "txtObservacionesAdd";
            this.txtObservacionesAdd.Size = new System.Drawing.Size(201, 106);
            this.txtObservacionesAdd.TabIndex = 8;
            // 
            // cbxCategoriaAdd
            // 
            this.cbxCategoriaAdd.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxCategoriaAdd.FormattingEnabled = true;
            this.cbxCategoriaAdd.Location = new System.Drawing.Point(96, 46);
            this.cbxCategoriaAdd.Name = "cbxCategoriaAdd";
            this.cbxCategoriaAdd.Size = new System.Drawing.Size(121, 21);
            this.cbxCategoriaAdd.TabIndex = 9;
            // 
            // cbxSucursalAdd
            // 
            this.cbxSucursalAdd.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxSucursalAdd.FormattingEnabled = true;
            this.cbxSucursalAdd.Location = new System.Drawing.Point(96, 102);
            this.cbxSucursalAdd.Name = "cbxSucursalAdd";
            this.cbxSucursalAdd.Size = new System.Drawing.Size(121, 21);
            this.cbxSucursalAdd.TabIndex = 10;
            // 
            // calendarioAdd
            // 
            this.calendarioAdd.Location = new System.Drawing.Point(349, 12);
            this.calendarioAdd.MaxSelectionCount = 1;
            this.calendarioAdd.MinDate = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            this.calendarioAdd.Name = "calendarioAdd";
            this.calendarioAdd.TabIndex = 11;
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(349, 216);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(75, 23);
            this.btnAceptar.TabIndex = 12;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(522, 216);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 13;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // frmAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(614, 261);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.calendarioAdd);
            this.Controls.Add(this.cbxSucursalAdd);
            this.Controls.Add(this.cbxCategoriaAdd);
            this.Controls.Add(this.txtObservacionesAdd);
            this.Controls.Add(this.txtPrecioAdd);
            this.Controls.Add(this.txtNombreAdd);
            this.Controls.Add(this.lblFecha);
            this.Controls.Add(this.lblObservaciones);
            this.Controls.Add(this.lblSucursal);
            this.Controls.Add(this.lblPrecio);
            this.Controls.Add(this.lblCategoria);
            this.Controls.Add(this.lblNombre);
            this.MaximumSize = new System.Drawing.Size(630, 300);
            this.MinimumSize = new System.Drawing.Size(630, 300);
            this.Name = "frmAdd";
            this.Text = "Agregar Item";
            this.Load += new System.EventHandler(this.frmAdd_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblCategoria;
        private System.Windows.Forms.Label lblPrecio;
        private System.Windows.Forms.Label lblSucursal;
        private System.Windows.Forms.Label lblObservaciones;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.TextBox txtNombreAdd;
        private System.Windows.Forms.TextBox txtPrecioAdd;
        private System.Windows.Forms.TextBox txtObservacionesAdd;
        private System.Windows.Forms.ComboBox cbxCategoriaAdd;
        private System.Windows.Forms.ComboBox cbxSucursalAdd;
        private System.Windows.Forms.MonthCalendar calendarioAdd;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Button btnCancelar;
    }
}