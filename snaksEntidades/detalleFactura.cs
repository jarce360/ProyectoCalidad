using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace snaksEntidades
{
    public class detalleFactura
    {
        public int ID { get; set; }
        public Factura IDFactura { get; set; }
        public Producto IDProducto { get; set; }
        public int cantidadProd { get; set; }
        public double precioProd { get; set; }
        public string nombreProd { get; set; }
        public string formaPago { get; set; }
        public string nombreCliente { get; set; }
    }
}