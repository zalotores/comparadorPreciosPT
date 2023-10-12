﻿namespace Tests
{
    partial class formTest
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnTestDDBB = new System.Windows.Forms.Button();
            this.lblConectado = new System.Windows.Forms.Label();
            this.lblConectadoResultado = new System.Windows.Forms.Label();
            this.lblDesconectado = new System.Windows.Forms.Label();
            this.lblDesconectadoResultado = new System.Windows.Forms.Label();
            this.groupBoxTestDDBB = new System.Windows.Forms.GroupBox();
            this.groupBoxTestTablasAuxiliares = new System.Windows.Forms.GroupBox();
            this.dgvTestTablasAux = new System.Windows.Forms.DataGridView();
            this.btnTestTablaCategoria = new System.Windows.Forms.Button();
            this.btnTestTablaMarcas = new System.Windows.Forms.Button();
            this.groupBoxMarcaCat = new System.Windows.Forms.GroupBox();
            this.btnTestArticuloGenerado = new System.Windows.Forms.Button();
            this.btnTestCategoriaGenerado = new System.Windows.Forms.Button();
            this.btnTestMarcaGenerado = new System.Windows.Forms.Button();
            this.groupBoxLinks = new System.Windows.Forms.GroupBox();
            this.linkLabelTest = new System.Windows.Forms.LinkLabel();
            this.lblLinkTest = new System.Windows.Forms.Label();
            this.groupBoxFecha = new System.Windows.Forms.GroupBox();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.buttonDateTime = new System.Windows.Forms.Button();
            this.groupBoxTestDDBB.SuspendLayout();
            this.groupBoxTestTablasAuxiliares.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTestTablasAux)).BeginInit();
            this.groupBoxMarcaCat.SuspendLayout();
            this.groupBoxLinks.SuspendLayout();
            this.groupBoxFecha.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnTestDDBB
            // 
            this.btnTestDDBB.Location = new System.Drawing.Point(6, 19);
            this.btnTestDDBB.Name = "btnTestDDBB";
            this.btnTestDDBB.Size = new System.Drawing.Size(75, 63);
            this.btnTestDDBB.TabIndex = 0;
            this.btnTestDDBB.Text = "Test";
            this.btnTestDDBB.UseVisualStyleBackColor = true;
            this.btnTestDDBB.Click += new System.EventHandler(this.btnTestDDBB_Click);
            // 
            // lblConectado
            // 
            this.lblConectado.AutoSize = true;
            this.lblConectado.Location = new System.Drawing.Point(87, 28);
            this.lblConectado.Name = "lblConectado";
            this.lblConectado.Size = new System.Drawing.Size(50, 13);
            this.lblConectado.TabIndex = 1;
            this.lblConectado.Text = "Conectar";
            // 
            // lblConectadoResultado
            // 
            this.lblConectadoResultado.AutoSize = true;
            this.lblConectadoResultado.Location = new System.Drawing.Point(161, 28);
            this.lblConectadoResultado.Name = "lblConectadoResultado";
            this.lblConectadoResultado.Size = new System.Drawing.Size(0, 13);
            this.lblConectadoResultado.TabIndex = 2;
            // 
            // lblDesconectado
            // 
            this.lblDesconectado.AutoSize = true;
            this.lblDesconectado.Location = new System.Drawing.Point(87, 59);
            this.lblDesconectado.Name = "lblDesconectado";
            this.lblDesconectado.Size = new System.Drawing.Size(68, 13);
            this.lblDesconectado.TabIndex = 3;
            this.lblDesconectado.Text = "Desconectar";
            // 
            // lblDesconectadoResultado
            // 
            this.lblDesconectadoResultado.AutoSize = true;
            this.lblDesconectadoResultado.Location = new System.Drawing.Point(161, 59);
            this.lblDesconectadoResultado.Name = "lblDesconectadoResultado";
            this.lblDesconectadoResultado.Size = new System.Drawing.Size(0, 13);
            this.lblDesconectadoResultado.TabIndex = 4;
            // 
            // groupBoxTestDDBB
            // 
            this.groupBoxTestDDBB.Controls.Add(this.btnTestDDBB);
            this.groupBoxTestDDBB.Controls.Add(this.lblDesconectadoResultado);
            this.groupBoxTestDDBB.Controls.Add(this.lblConectado);
            this.groupBoxTestDDBB.Controls.Add(this.lblDesconectado);
            this.groupBoxTestDDBB.Controls.Add(this.lblConectadoResultado);
            this.groupBoxTestDDBB.Location = new System.Drawing.Point(12, 12);
            this.groupBoxTestDDBB.Name = "groupBoxTestDDBB";
            this.groupBoxTestDDBB.Size = new System.Drawing.Size(200, 100);
            this.groupBoxTestDDBB.TabIndex = 5;
            this.groupBoxTestDDBB.TabStop = false;
            this.groupBoxTestDDBB.Text = "Conexion a DDBB";
            // 
            // groupBoxTestTablasAuxiliares
            // 
            this.groupBoxTestTablasAuxiliares.Controls.Add(this.dgvTestTablasAux);
            this.groupBoxTestTablasAuxiliares.Controls.Add(this.btnTestTablaCategoria);
            this.groupBoxTestTablasAuxiliares.Controls.Add(this.btnTestTablaMarcas);
            this.groupBoxTestTablasAuxiliares.Location = new System.Drawing.Point(237, 12);
            this.groupBoxTestTablasAuxiliares.Name = "groupBoxTestTablasAuxiliares";
            this.groupBoxTestTablasAuxiliares.Size = new System.Drawing.Size(280, 226);
            this.groupBoxTestTablasAuxiliares.TabIndex = 6;
            this.groupBoxTestTablasAuxiliares.TabStop = false;
            this.groupBoxTestTablasAuxiliares.Text = "Conexion a Tablas Auxiliares";
            // 
            // dgvTestTablasAux
            // 
            this.dgvTestTablasAux.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTestTablasAux.Location = new System.Drawing.Point(7, 61);
            this.dgvTestTablasAux.Name = "dgvTestTablasAux";
            this.dgvTestTablasAux.Size = new System.Drawing.Size(263, 154);
            this.dgvTestTablasAux.TabIndex = 2;
            // 
            // btnTestTablaCategoria
            // 
            this.btnTestTablaCategoria.Location = new System.Drawing.Point(101, 31);
            this.btnTestTablaCategoria.Name = "btnTestTablaCategoria";
            this.btnTestTablaCategoria.Size = new System.Drawing.Size(75, 23);
            this.btnTestTablaCategoria.TabIndex = 1;
            this.btnTestTablaCategoria.Text = "Categorias";
            this.btnTestTablaCategoria.UseVisualStyleBackColor = true;
            this.btnTestTablaCategoria.Click += new System.EventHandler(this.btnTestTablaCategoria_Click);
            // 
            // btnTestTablaMarcas
            // 
            this.btnTestTablaMarcas.Location = new System.Drawing.Point(6, 31);
            this.btnTestTablaMarcas.Name = "btnTestTablaMarcas";
            this.btnTestTablaMarcas.Size = new System.Drawing.Size(75, 23);
            this.btnTestTablaMarcas.TabIndex = 0;
            this.btnTestTablaMarcas.Text = "Marcas";
            this.btnTestTablaMarcas.UseVisualStyleBackColor = true;
            this.btnTestTablaMarcas.Click += new System.EventHandler(this.btnTestTablaMarcas_Click);
            // 
            // groupBoxMarcaCat
            // 
            this.groupBoxMarcaCat.Controls.Add(this.btnTestArticuloGenerado);
            this.groupBoxMarcaCat.Controls.Add(this.btnTestCategoriaGenerado);
            this.groupBoxMarcaCat.Controls.Add(this.btnTestMarcaGenerado);
            this.groupBoxMarcaCat.Location = new System.Drawing.Point(523, 13);
            this.groupBoxMarcaCat.Name = "groupBoxMarcaCat";
            this.groupBoxMarcaCat.Size = new System.Drawing.Size(265, 71);
            this.groupBoxMarcaCat.TabIndex = 7;
            this.groupBoxMarcaCat.TabStop = false;
            this.groupBoxMarcaCat.Text = "Generar Modelo";
            // 
            // btnTestArticuloGenerado
            // 
            this.btnTestArticuloGenerado.Location = new System.Drawing.Point(168, 30);
            this.btnTestArticuloGenerado.Name = "btnTestArticuloGenerado";
            this.btnTestArticuloGenerado.Size = new System.Drawing.Size(75, 23);
            this.btnTestArticuloGenerado.TabIndex = 2;
            this.btnTestArticuloGenerado.Text = "Artículo";
            this.btnTestArticuloGenerado.UseVisualStyleBackColor = true;
            this.btnTestArticuloGenerado.Click += new System.EventHandler(this.btnTestArticuloGenerado_Click);
            // 
            // btnTestCategoriaGenerado
            // 
            this.btnTestCategoriaGenerado.Location = new System.Drawing.Point(87, 30);
            this.btnTestCategoriaGenerado.Name = "btnTestCategoriaGenerado";
            this.btnTestCategoriaGenerado.Size = new System.Drawing.Size(75, 23);
            this.btnTestCategoriaGenerado.TabIndex = 1;
            this.btnTestCategoriaGenerado.Text = "Categoría";
            this.btnTestCategoriaGenerado.UseVisualStyleBackColor = true;
            this.btnTestCategoriaGenerado.Click += new System.EventHandler(this.btnTestCategoriaGenerado_Click);
            // 
            // btnTestMarcaGenerado
            // 
            this.btnTestMarcaGenerado.Location = new System.Drawing.Point(6, 30);
            this.btnTestMarcaGenerado.Name = "btnTestMarcaGenerado";
            this.btnTestMarcaGenerado.Size = new System.Drawing.Size(75, 23);
            this.btnTestMarcaGenerado.TabIndex = 0;
            this.btnTestMarcaGenerado.Text = "Marca";
            this.btnTestMarcaGenerado.UseVisualStyleBackColor = true;
            this.btnTestMarcaGenerado.Click += new System.EventHandler(this.btnTestMarcaGenerado_Click);
            // 
            // groupBoxLinks
            // 
            this.groupBoxLinks.Controls.Add(this.linkLabelTest);
            this.groupBoxLinks.Controls.Add(this.lblLinkTest);
            this.groupBoxLinks.Location = new System.Drawing.Point(12, 130);
            this.groupBoxLinks.Name = "groupBoxLinks";
            this.groupBoxLinks.Size = new System.Drawing.Size(200, 108);
            this.groupBoxLinks.TabIndex = 8;
            this.groupBoxLinks.TabStop = false;
            this.groupBoxLinks.Text = "Links externos";
            // 
            // linkLabelTest
            // 
            this.linkLabelTest.AutoSize = true;
            this.linkLabelTest.Location = new System.Drawing.Point(54, 33);
            this.linkLabelTest.Name = "linkLabelTest";
            this.linkLabelTest.Size = new System.Drawing.Size(69, 13);
            this.linkLabelTest.TabIndex = 1;
            this.linkLabelTest.TabStop = true;
            this.linkLabelTest.Text = "Hazme Click!";
            this.linkLabelTest.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelTest_LinkClicked);
            // 
            // lblLinkTest
            // 
            this.lblLinkTest.AutoSize = true;
            this.lblLinkTest.Location = new System.Drawing.Point(18, 33);
            this.lblLinkTest.Name = "lblLinkTest";
            this.lblLinkTest.Size = new System.Drawing.Size(30, 13);
            this.lblLinkTest.TabIndex = 0;
            this.lblLinkTest.Text = "Link:";
            // 
            // groupBoxFecha
            // 
            this.groupBoxFecha.Controls.Add(this.buttonDateTime);
            this.groupBoxFecha.Controls.Add(this.monthCalendar1);
            this.groupBoxFecha.Location = new System.Drawing.Point(523, 90);
            this.groupBoxFecha.Name = "groupBoxFecha";
            this.groupBoxFecha.Size = new System.Drawing.Size(265, 239);
            this.groupBoxFecha.TabIndex = 9;
            this.groupBoxFecha.TabStop = false;
            this.groupBoxFecha.Text = "DateTime";
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(11, 25);
            this.monthCalendar1.MaxSelectionCount = 1;
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 0;
            // 
            // buttonDateTime
            // 
            this.buttonDateTime.Location = new System.Drawing.Point(87, 199);
            this.buttonDateTime.Name = "buttonDateTime";
            this.buttonDateTime.Size = new System.Drawing.Size(75, 23);
            this.buttonDateTime.TabIndex = 1;
            this.buttonDateTime.Text = "Capturar";
            this.buttonDateTime.UseVisualStyleBackColor = true;
            this.buttonDateTime.Click += new System.EventHandler(this.buttonDateTime_Click);
            // 
            // formTest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBoxFecha);
            this.Controls.Add(this.groupBoxLinks);
            this.Controls.Add(this.groupBoxMarcaCat);
            this.Controls.Add(this.groupBoxTestTablasAuxiliares);
            this.Controls.Add(this.groupBoxTestDDBB);
            this.Name = "formTest";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pruebas";
            this.groupBoxTestDDBB.ResumeLayout(false);
            this.groupBoxTestDDBB.PerformLayout();
            this.groupBoxTestTablasAuxiliares.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTestTablasAux)).EndInit();
            this.groupBoxMarcaCat.ResumeLayout(false);
            this.groupBoxLinks.ResumeLayout(false);
            this.groupBoxLinks.PerformLayout();
            this.groupBoxFecha.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnTestDDBB;
        private System.Windows.Forms.Label lblConectado;
        private System.Windows.Forms.Label lblConectadoResultado;
        private System.Windows.Forms.Label lblDesconectado;
        private System.Windows.Forms.Label lblDesconectadoResultado;
        private System.Windows.Forms.GroupBox groupBoxTestDDBB;
        private System.Windows.Forms.GroupBox groupBoxTestTablasAuxiliares;
        private System.Windows.Forms.Button btnTestTablaCategoria;
        private System.Windows.Forms.Button btnTestTablaMarcas;
        private System.Windows.Forms.DataGridView dgvTestTablasAux;
        private System.Windows.Forms.GroupBox groupBoxMarcaCat;
        private System.Windows.Forms.Button btnTestArticuloGenerado;
        private System.Windows.Forms.Button btnTestCategoriaGenerado;
        private System.Windows.Forms.Button btnTestMarcaGenerado;
        private System.Windows.Forms.GroupBox groupBoxLinks;
        private System.Windows.Forms.LinkLabel linkLabelTest;
        private System.Windows.Forms.Label lblLinkTest;
        private System.Windows.Forms.GroupBox groupBoxFecha;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.Button buttonDateTime;
    }
}

