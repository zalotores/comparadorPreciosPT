namespace VistaPrincipal
{
    partial class frmMain
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
            this.groupBoxFiltros = new System.Windows.Forms.GroupBox();
            this.lblPrecioMaximo = new System.Windows.Forms.Label();
            this.lblPrecioMinimo = new System.Windows.Forms.Label();
            this.numPrecioMaximo = new System.Windows.Forms.NumericUpDown();
            this.numPrecioMinimo = new System.Windows.Forms.NumericUpDown();
            this.lblSucursal = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblCategoria = new System.Windows.Forms.Label();
            this.txtArticulo = new System.Windows.Forms.TextBox();
            this.cbxSucursal = new System.Windows.Forms.ComboBox();
            this.cbxCategoria = new System.Windows.Forms.ComboBox();
            this.dgvArticulos = new System.Windows.Forms.DataGridView();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.groupBoxCRUD = new System.Windows.Forms.GroupBox();
            this.groupBoxFiltros.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numPrecioMaximo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPrecioMinimo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvArticulos)).BeginInit();
            this.groupBoxCRUD.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxFiltros
            // 
            this.groupBoxFiltros.Controls.Add(this.lblPrecioMaximo);
            this.groupBoxFiltros.Controls.Add(this.lblPrecioMinimo);
            this.groupBoxFiltros.Controls.Add(this.numPrecioMaximo);
            this.groupBoxFiltros.Controls.Add(this.numPrecioMinimo);
            this.groupBoxFiltros.Controls.Add(this.lblSucursal);
            this.groupBoxFiltros.Controls.Add(this.lblNombre);
            this.groupBoxFiltros.Controls.Add(this.lblCategoria);
            this.groupBoxFiltros.Controls.Add(this.txtArticulo);
            this.groupBoxFiltros.Controls.Add(this.cbxSucursal);
            this.groupBoxFiltros.Controls.Add(this.cbxCategoria);
            this.groupBoxFiltros.Location = new System.Drawing.Point(13, 13);
            this.groupBoxFiltros.Name = "groupBoxFiltros";
            this.groupBoxFiltros.Size = new System.Drawing.Size(200, 280);
            this.groupBoxFiltros.TabIndex = 0;
            this.groupBoxFiltros.TabStop = false;
            this.groupBoxFiltros.Text = "Criterios";
            // 
            // lblPrecioMaximo
            // 
            this.lblPrecioMaximo.AutoSize = true;
            this.lblPrecioMaximo.Location = new System.Drawing.Point(24, 208);
            this.lblPrecioMaximo.Name = "lblPrecioMaximo";
            this.lblPrecioMaximo.Size = new System.Drawing.Size(76, 13);
            this.lblPrecioMaximo.TabIndex = 9;
            this.lblPrecioMaximo.Text = "Precio Máximo";
            // 
            // lblPrecioMinimo
            // 
            this.lblPrecioMinimo.AutoSize = true;
            this.lblPrecioMinimo.Location = new System.Drawing.Point(22, 169);
            this.lblPrecioMinimo.Name = "lblPrecioMinimo";
            this.lblPrecioMinimo.Size = new System.Drawing.Size(78, 13);
            this.lblPrecioMinimo.TabIndex = 8;
            this.lblPrecioMinimo.Text = "Precio Mínimo:";
            // 
            // numPrecioMaximo
            // 
            this.numPrecioMaximo.Location = new System.Drawing.Point(106, 206);
            this.numPrecioMaximo.Name = "numPrecioMaximo";
            this.numPrecioMaximo.Size = new System.Drawing.Size(88, 20);
            this.numPrecioMaximo.TabIndex = 7;
            // 
            // numPrecioMinimo
            // 
            this.numPrecioMinimo.Location = new System.Drawing.Point(106, 167);
            this.numPrecioMinimo.Name = "numPrecioMinimo";
            this.numPrecioMinimo.Size = new System.Drawing.Size(88, 20);
            this.numPrecioMinimo.TabIndex = 6;
            // 
            // lblSucursal
            // 
            this.lblSucursal.AutoSize = true;
            this.lblSucursal.Location = new System.Drawing.Point(16, 120);
            this.lblSucursal.Name = "lblSucursal";
            this.lblSucursal.Size = new System.Drawing.Size(51, 13);
            this.lblSucursal.TabIndex = 5;
            this.lblSucursal.Text = "Sucursal:";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(14, 82);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(53, 13);
            this.lblNombre.TabIndex = 4;
            this.lblNombre.Text = "Producto:";
            // 
            // lblCategoria
            // 
            this.lblCategoria.AutoSize = true;
            this.lblCategoria.Location = new System.Drawing.Point(10, 36);
            this.lblCategoria.Name = "lblCategoria";
            this.lblCategoria.Size = new System.Drawing.Size(57, 13);
            this.lblCategoria.TabIndex = 3;
            this.lblCategoria.Text = "Categoría:";
            // 
            // txtArticulo
            // 
            this.txtArticulo.Location = new System.Drawing.Point(73, 75);
            this.txtArticulo.Name = "txtArticulo";
            this.txtArticulo.Size = new System.Drawing.Size(121, 20);
            this.txtArticulo.TabIndex = 2;
            // 
            // cbxSucursal
            // 
            this.cbxSucursal.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxSucursal.FormattingEnabled = true;
            this.cbxSucursal.Location = new System.Drawing.Point(73, 117);
            this.cbxSucursal.Name = "cbxSucursal";
            this.cbxSucursal.Size = new System.Drawing.Size(121, 21);
            this.cbxSucursal.TabIndex = 1;
            // 
            // cbxCategoria
            // 
            this.cbxCategoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxCategoria.FormattingEnabled = true;
            this.cbxCategoria.Location = new System.Drawing.Point(73, 33);
            this.cbxCategoria.Name = "cbxCategoria";
            this.cbxCategoria.Size = new System.Drawing.Size(121, 21);
            this.cbxCategoria.TabIndex = 0;
            // 
            // dgvArticulos
            // 
            this.dgvArticulos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvArticulos.Location = new System.Drawing.Point(247, 13);
            this.dgvArticulos.Name = "dgvArticulos";
            this.dgvArticulos.Size = new System.Drawing.Size(310, 280);
            this.dgvArticulos.TabIndex = 1;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(18, 24);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(75, 23);
            this.btnAgregar.TabIndex = 2;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(18, 63);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(75, 23);
            this.btnModificar.TabIndex = 3;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(18, 110);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(75, 23);
            this.btnEliminar.TabIndex = 4;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            // 
            // groupBoxCRUD
            // 
            this.groupBoxCRUD.Controls.Add(this.btnAgregar);
            this.groupBoxCRUD.Controls.Add(this.btnEliminar);
            this.groupBoxCRUD.Controls.Add(this.btnModificar);
            this.groupBoxCRUD.Location = new System.Drawing.Point(586, 13);
            this.groupBoxCRUD.Name = "groupBoxCRUD";
            this.groupBoxCRUD.Size = new System.Drawing.Size(113, 146);
            this.groupBoxCRUD.TabIndex = 5;
            this.groupBoxCRUD.TabStop = false;
            this.groupBoxCRUD.Text = "Administrar Datos";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(734, 461);
            this.Controls.Add(this.groupBoxCRUD);
            this.Controls.Add(this.dgvArticulos);
            this.Controls.Add(this.groupBoxFiltros);
            this.MaximumSize = new System.Drawing.Size(750, 500);
            this.MinimumSize = new System.Drawing.Size(750, 500);
            this.Name = "frmMain";
            this.Text = "Main";
            this.Load += new System.EventHandler(this.Main_Load);
            this.groupBoxFiltros.ResumeLayout(false);
            this.groupBoxFiltros.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numPrecioMaximo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPrecioMinimo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvArticulos)).EndInit();
            this.groupBoxCRUD.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxFiltros;
        private System.Windows.Forms.Label lblPrecioMinimo;
        private System.Windows.Forms.NumericUpDown numPrecioMaximo;
        private System.Windows.Forms.NumericUpDown numPrecioMinimo;
        private System.Windows.Forms.Label lblSucursal;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblCategoria;
        private System.Windows.Forms.TextBox txtArticulo;
        private System.Windows.Forms.ComboBox cbxSucursal;
        private System.Windows.Forms.ComboBox cbxCategoria;
        private System.Windows.Forms.Label lblPrecioMaximo;
        private System.Windows.Forms.DataGridView dgvArticulos;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.GroupBox groupBoxCRUD;
    }
}