using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Examen_TacticaSoft.Entidades;

namespace Examen_TacticaSoft.Servicios
{
    public interface IProductoServicio
    {
        List<Producto> MostrarProductos();
    }

    public class ProductoServicio : IProductoServicio
    {
        private readonly ApplicationDbContext _context;

        public ProductoServicio(ApplicationDbContext context)
        {
            _context = context;
        }

        public List<Producto> MostrarProductos()
        {
            return _context.Productos.ToList();
        }
    }
}