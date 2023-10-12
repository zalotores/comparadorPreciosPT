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
    public partial class frmMain : Form
    {
        //lista donde se van a mostrar los articulos en pantalla
        private List<Articulo> listaArticulos;
        //flag para saber si esta aplicado un filtro
        bool filtrado = false;
        public frmMain()
        {
            InitializeComponent();
        }

        private void Main_Load(object sender, EventArgs e)
        {
            cargar();
        }

        private void cargar()
        {
            ArticuloNegocio negocio = new ArticuloNegocio();

            decimal montoMaximo = numPrecioMaximo.Value;
            decimal montoMinimo = numPrecioMinimo.Value;

            try
            {
                if (!filtrado)   //solamente entra cuando no esta aplicado filtro
                {
                    listaArticulos = negocio.listar(montoMinimo, montoMaximo);
                }
                dgvArticulos.DataSource = listaArticulos;
                formatearColumnas();
                cargarComboBox();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
                MessageBox.Show("Error al conectar a la Base de Datos");
            }
        }

        //formato de data grid
        private void formatearColumnas()
        {
            //oculta columnas que trae de DDBB pero no quiero visualizar
            dgvArticulos.Columns["Id"].Visible = false;
            dgvArticulos.Columns["Precio"].Visible = false;
            dgvArticulos.Columns["Observaciones"].Visible = false;
            //dgvArticulos.Columns["Fecha"].Visible = false;
            dgvArticulos.Columns["Categoria"].Visible = false;

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
                List<Sucursal> listaSucursal = new List<Sucursal>();
                SucursalNegocio sucursalNeg = new SucursalNegocio();
                listaSucursal = sucursalNeg.listar();
                Sucursal ceroS = new Sucursal();  //cargo el primer item vacio con id = 0
                ceroS.Descripcion = "Todas";
                cbxSucursal.Items.Add(ceroS);
                foreach (Sucursal i in listaSucursal)
                {
                    cbxSucursal.Items.Add(i);
                }

                cbxSucursal.ValueMember = "Id";
                cbxSucursal.DisplayMember = "Descripcion";
                cbxSucursal.SelectedIndex = 0;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
                MessageBox.Show("Error al conectar a la base de datos!");
            }

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            frmAdd frmAdd = new frmAdd();
            frmAdd.ShowDialog();
            cargar();
        }
    }
}
