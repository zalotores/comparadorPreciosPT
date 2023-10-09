using DataBase;
using Dominio;
using Negocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tests
{
    public partial class formTest : Form
    {
        public formTest()
        {
            InitializeComponent();
        }
        //Test de acceso a datos
        private void btnTestDDBB_Click(object sender, EventArgs e)
        {
            AccesoDatos con = new AccesoDatos();
            try
            {
                lblConectadoResultado.Text = "NO";
                lblDesconectadoResultado.Text = "NO";
                con.setConsulta("SELECT * FROM CATEGORIAS;");
                con.ejecutarQuery();
                lblConectadoResultado.Text = "SI";
                con.cerrarConexion();
                lblDesconectadoResultado.Text = "SI";

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        //Test de conexion a Categoria negocio
        private void btnTestTablaCategoria_Click(object sender, EventArgs e)
        {
            try
            {
                CategoriaNegocio catNegocio = new CategoriaNegocio();
                dgvTestTablasAux.DataSource = catNegocio.listar();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        //Test de conexion a Marca negocio
        private void btnTestTablaMarcas_Click(object sender, EventArgs e)
        {
            try
            {
                SucursalNegocio sucursalNegocio = new SucursalNegocio();
                dgvTestTablasAux.DataSource = sucursalNegocio.listar();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btnTestMarcaGenerado_Click(object sender, EventArgs e)
        {
            Sucursal sucursal = new Sucursal();
            MessageBox.Show("Marca | " + "id: " + sucursal.Id.ToString() + 
                " | descripcion: " + sucursal.Descripcion);
        }

        private void btnTestCategoriaGenerado_Click(object sender, EventArgs e)
        {
            Categoria categoria = new Categoria();
            MessageBox.Show("Categoria | " + "id: " + categoria.Id.ToString() + 
                " | descripcion: " +categoria.Descripcion);
        }

        private void btnTestArticuloGenerado_Click(object sender, EventArgs e)
        {
            Articulo articulo = new Articulo();
            MessageBox.Show("Nombre: " + articulo.Nombre +
                " | observaciones: " + articulo.Observaciones +
                " | precio: " + articulo.Precio.ToString());
            if (articulo.Fecha is null)
                MessageBox.Show("Fecha generada en articulo es Null");
            else
                MessageBox.Show(" | fecha: " + articulo.Fecha.ToString());
            if (articulo.Sucursal is null)
                MessageBox.Show("Sucursal generada en articulo es Null");
            else
                MessageBox.Show("Sucursal generada | id: " + articulo.Sucursal.Id.ToString() +
                " | descripcion: " + articulo.Sucursal.Descripcion);
            if (articulo.Categoria is null)
                MessageBox.Show("Categoria generada en articulo es Null");
            else
                MessageBox.Show("Categoria generada | id: " + articulo.Categoria.Id.ToString() +
                " | descripcion: " + articulo.Categoria.Descripcion);
        }

        private void linkLabelTest_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                System.Diagnostics.Process.Start("https://www.youtube.com/watch?v=dQw4w9WgXcQ&autoplay=1");
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}
