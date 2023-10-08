using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Articulo
    {
        public int Id {  get; set; }
        public string Nombre { get; set; }
        public Sucursal Sucursal {  get; set; }
        [DisplayName("Categoría")]
        public Categoria Categoria {  get; set; }
        public decimal Precio {  get; set; }
        public string Observaciones { get; set; }
        public string Fecha { get; set; }
    }
}
