using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace snaksEntidades
{
    public class Producto
    {
        public int ID { get; set; }
        public string descripcion { get; set; }
        public double precioVenta { get; set; }
        public bool promocion { set; get; }
        public string imagenUrl { set; get; }
        
        public string textoMostrar { set; get; }
    }
}