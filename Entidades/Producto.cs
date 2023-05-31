using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Examen_TacticaSoft.Entidades
{
    public class Producto
    {
        public int Id {get;set;}
        public string Nombre {get;set;}
        public int Precio {get;set;}
        public string Categoria {get;set;}
        public List<Venta> Ventas { get; set; }
        
    }

}