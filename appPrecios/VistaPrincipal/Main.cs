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
    public partial class Main : Form
    {
        //lista donde se van a mostrar los articulos en pantalla
        private List<Articulo> listaArticulos;
        //flag para saber si esta aplicado un filtro
        bool filtrado = false;
        public Main()
        {
            InitializeComponent();
        }

        private void Main_Load(object sender, EventArgs e)
        {

        }

        private void cargar()
        {
            ArticuloNegocio negocio = new ArticuloNegocio();

            try
            {
                if (!filtrado)   //solamente entra cuando no esta aplicado filtro
                {
                    listaArticulos = negocio.listar();
                }
                dgvArticulos.DataSource = listaArticulos;
                formatearColumnas();
            }
            catch
            {
                MessageBox.Show("Error al conectar a la Base de Datos");
            }
        }

        //formato de data grid
        private void formatearColumnas()
        {
            //oculta columnas que trae de DDBB pero no quiero visualizar
            dgvArticulos.Columns["Id"].Visible = false;

            //cambio el formato de precio para que muestre dos decimales
            dgvArticulos.Columns["Precio"].DefaultCellStyle.Format = "0.00";

        }

        //carga de combo box de tipo y sucursal
        private void cargarComboBox()
        {
            CategoriaNegocio categoriaNegocio = new CategoriaNegocio();

            try
            {
                cbxCategoria.DataSource = categoriaNegocio.listar();
                cbxCategoria.ValueMember = "Id";
                cbxCategoria.DisplayMember = "Descripcion";

                //para sucursal cargo los valores agregando el valor 'todas'
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
                MessageBox.Show("Error al conectar a la base de datos!");
            }

        }
    }
}
