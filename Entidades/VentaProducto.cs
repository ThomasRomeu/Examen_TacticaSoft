using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Examen_TacticaSoft.Entidades
{
    public class VentaProducto
    {
        public int ProductoId { get; set; }
        public int VentaId { get; set; }
        public Producto Producto { get; set; }
        public Venta Venta { get; set; }

        public int PrecioUnitario { get; set; }
        public int Cantidad { get; set; }
        public int PrecioTotal { get; set; }
    }
}