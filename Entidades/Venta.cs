using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Examen_TacticaSoft.Entidades
{
    public class Venta
    {
        public int Id { get; set; }
        public DateTime Fecha { get; set; }
        public int Total { get; set; }

        public int ClienteId { get; set; }
        public Cliente Cliente { get; set; }
        public List<Producto> Productos { get; set; }

        public Venta()
        {

        }

        public Venta(DateTime fecha, int total)
        {
            this.Fecha = fecha;
            this.Total = total;
            this.Cliente = new Cliente();
        }
    }
}