using DataBase;
using Dominio;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{   
    public class ArticuloNegocio
    {
        //habilito la conexion con DDBB para todo el negocio
        AccesoDatos con = new AccesoDatos();
        //variable para ejecutar las query, inicializo con la que se usa para listar()

        string query = "SELECT A.Id, Nombre, C.Descripcion AS Categoría, Precio, S.Descripcion" +
            "AS Sucursal, Observaciones, Fecha FROM ARTICULOS A, CATEGORIAS C, SUCURSALES S " +
            "WHERE A.IdSucursal = S.Id AND A.IdCategoria = C.Id";

        public List<Articulo> listar()
        {
            List<Articulo> lista = new List<Articulo>();

            try
            {
                con.setConsulta(query);
                con.ejecutarQuery();

                while (con.Reader.Read())
                {
                    Articulo articulo = new Articulo();
                    articulo.Id = (int) con.Reader["Id"];
                    articulo.Nombre = con.Reader.GetString(1);
                    articulo.Sucursal = new Sucursal((int)con.Reader["IdSucursal"], con.Reader.GetString(4));
                    articulo.Categoria = new Categoria((int)con.Reader["IdCategoria"], con.Reader.GetString(2));
                    articulo.Observaciones = con.Reader.GetString(5);
                    articulo.Precio = (decimal)con.Reader["Precio"];
                    articulo.Fecha = con.Reader.GetString(6);

                    lista.Add(articulo);
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

        //TODO cambiar la query
        public void agregar(Articulo articulo)
        {
            try
            {
                //query para agregar datos con proteccion de injeccion de codigo
                query = "INSERT INTO ARTICULOS (Codigo, Nombre, Descripcion, IdMarca, IdCategoria" +
                    ", ImagenUrl, Precio ) VALUES (@codigo, @nombre, @descripcion, @idMarca, " +
                    "@idCategoria, @imagen, @precio);";
                //setear consulta
                con.setConsulta(query);
                //setear parametros
                con.setParametro("@codigo", articulo.CodigoArticulo);
                con.setParametro("@nombre", articulo.Nombre);
                con.setParametro("@descripcion", articulo.Descripcion);
                con.setParametro("@idMarca", articulo.Marca.Id);
                con.setParametro("@idCategoria", articulo.Categoria.Id);
                con.setParametro("@imagen", articulo.Imagen);
                con.setParametro("@precio", articulo.Precio);
                //ejecutar consulta
                con.ejecutarQuery();
            }
            catch(Exception ex)
            {
                throw(ex);
            }
            finally
            {
                con.cerrarConexion();
            }
        }

        public void modificar(Articulo articulo)
        {
            //query para hacer update en DDBB
            query = "UPDATE ARTICULOS SET Codigo = @codigo, Nombre = @nombre, " +
                "Descripcion = @descripcion, IdMarca = @idMarca, IdCategoria = @idCategoria" +
                ", ImagenUrl = @imagen, Precio = @precio WHERE Id = @id; ";
            try
            {
                //setear consulta
                con.setConsulta(query);
                //setear parametros
                con.setParametro("@codigo", articulo.CodigoArticulo);
                con.setParametro("@nombre", articulo.Nombre);
                con.setParametro("@descripcion", articulo.Descripcion);
                con.setParametro("@idMarca", articulo.Marca.Id);
                con.setParametro("@idCategoria", articulo.Categoria.Id);
                con.setParametro("@imagen", articulo.Imagen);
                con.setParametro("@precio", articulo.Precio);
                con.setParametro("@id", articulo.Id);
                //ejecutar consulta
                con.ejecutarQuery();
            }
            catch (Exception ex)
            {
                throw (ex);
            }
            finally
            {
                con.cerrarConexion();
            }
        }

        public void eliminar(int id)
        {
            //query para delete en DDBB
            query = "DELETE FROM ARTICULOS WHERE Id = @id;";
            try
            {
                //setear consulta
                con.setConsulta(query);
                //setear paramero
                con.setParametro("@id", id);
                //ejecutar query
                con.ejecutarAccion();
            }
            catch
            {
                throw new Exception();
            }
            finally
            {
                //cierro conexion a DDBB
                con.cerrarConexion();

            }

        }
        /*query para filtrar articulos
         * Parametros:
         * Marca y Categoria: se genera desde constructor y se copia valor, en caso de no 
         * filtrar por este criterio, el id desde contructor es 0.
         * Codigo, Nombre, Descripcion: el filtro hace un strip de espacios en blanco al 
         * principio y al final del string, y filtra si el campo contiene el string
         * precioMin y precioMax: si los dos estan en cero, no filtra. No debe tener '.'.
         */
        public List<Articulo> filtrar(Sucursal marca, Categoria categoria, string codigo, 
            string nombre, string descripcion, decimal precioMin, decimal precioMax)
        {
            List<Articulo> listaFiltrada = new List<Articulo> ();
            //string para agregar a la query de listar()
            string filtro = "";

            if (marca.Id != 0)
                filtro = filtro + " AND M.Id = " + marca.Id;
            if(categoria.Id != 0)
                filtro = filtro + " AND C.Id = " + categoria.Id;
            if (codigo.Length > 0)
                filtro = filtro + " AND Codigo LIKE '%"+ codigo + "%'";
            if (nombre.Length > 0)
                filtro = filtro + " AND Nombre LIKE '%" + nombre + "%'";
            if (descripcion.Length > 0)
                filtro = filtro + " AND A.Descripcion LIKE '%" + descripcion + "%'";
            if (precioMin > 0)
                filtro = filtro + " AND Precio > " + precioMin;
            if (precioMax < decimal.MaxValue)
                filtro = filtro + " And Precio < " + precioMax;

            //completado el string de filtro mando la nueva query
            query += filtro;
            listaFiltrada = listar();
            return listaFiltrada;
        }

    }
}
