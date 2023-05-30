using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Examen_TacticaSoft.Entidades
{
    public class Cliente
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public int Telefono { get; set; }
        public string Correo { get; set; }

        public List<Venta> VentasDeCliente {get;set;}

        public Cliente()
        {

        }

        public Cliente(string nombre, int telefono, string correo)
        {
            this.Nombre = nombre;
            this.Correo = correo;
            this.Telefono = telefono;
            this.VentasDeCliente = new List<Venta>();
        }
    }
}