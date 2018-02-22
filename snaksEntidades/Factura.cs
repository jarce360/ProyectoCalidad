using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace snaksEntidades
{
    public class Factura
    {
        public int ID { get; set; }
        public DateTime fecha { get; set; }
        public Usuario IDUsuario { get; set; }
        public string nombreUsuario { get; set; }
        public double subTotal { get; set; }
        public double totalVenta { get; set; }
        public double impuesto { get; set; }
        public detalleFactura detalleFactura { get; set; }
    }
}