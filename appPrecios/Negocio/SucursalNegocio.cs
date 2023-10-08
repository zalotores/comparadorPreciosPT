using DataBase;
using Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class SucursalNegocio
    {
        public List<Sucursal> listar()
        {
            List<Sucursal> lista = new List<Sucursal>();
            AccesoDatos con = new AccesoDatos();

            try
            {
                con.setConsulta("SELECT Id, Descripcion FROM SUCURSALES;");
                con.ejecutarQuery();

                while (con.Reader.Read())
                {
                    Sucursal marca = new Sucursal();
                    marca.Id = (int)con.Reader["Id"];
                    marca.Descripcion = (string)con.Reader["Descripcion"];
                    lista.Add(marca);
                }
                return lista;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                con.cerrarConexion();
            }
        }
    }
}
