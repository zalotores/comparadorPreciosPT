using Dominio;
using Negocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VistaPrincipal
{
    public partial class frmAdd : Form
    {
        //creo atributos privados null
        private Articulo articulo = null;
        //constructor para articulo nuevo
        public frmAdd()
        {
            InitializeComponent();
        }
        //cargar datos iniciales
        private void frmAdd_Load(object sender, EventArgs e)
        {
            //cargo desplegables de categoria
            CategoriaNegocio categoriaNegocio = new CategoriaNegocio();
            cbxCategoriaAdd.DataSource = categoriaNegocio.listar();
            cbxCategoriaAdd.ValueMember = "Id";
            cbxCategoriaAdd.DisplayMember = "Descripcion";
            cbxCategoriaAdd.SelectedIndex = -1;     //dejo campo en blanco

            //cargo desplegables de sucursal
            SucursalNegocio sucursalNegocio = new SucursalNegocio();
            cbxSucursalAdd.DataSource = sucursalNegocio.listar();
            cbxSucursalAdd.ValueMember = "Id";
            cbxSucursalAdd.DisplayMember = "Descripcion";
            cbxSucursalAdd.SelectedIndex = -1;
        }

        //cancelar carga
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            ArticuloNegocio articuloNegocio = new ArticuloNegocio();
            //inicializo articulo nuevo
            articulo = new Articulo();
            //intento cargar parametros
            try
            {
                articulo.Nombre = txtNombreAdd.Text.Trim();
                articulo.Categoria = (Categoria) cbxCategoriaAdd.SelectedItem;
                articulo.Precio = decimal.Parse(txtPrecioAdd.Text.Trim());
                //genero un error si el precio tiene punto en lugar de coma
                if (txtPrecioAdd.Text.Contains('.'))
                    throw new FormatException();
                articulo.Sucursal = (Sucursal) cbxSucursalAdd.SelectedItem;
                articulo.Observaciones = txtObservacionesAdd.Text.Trim();
                DateTime fecha = calendarioAdd.SelectionRange.Start;
                articulo.Fecha = fecha;

                //ejecuto query
                articuloNegocio.agregar(articulo);
                MessageBox.Show("Articulo agregado");
                Close();
            }
            catch (FormatException)
            {
                MessageBox.Show("El precio sólo admite numeros");
            }
            catch(Exception ex) 
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
