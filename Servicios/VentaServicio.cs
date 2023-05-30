using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Examen_TacticaSoft.Entidades;


namespace Examen_TacticaSoft.Servicios
{
    public interface IVentaServicio
    {
        List<Venta> MostrarVentas();
    }

    public class VentaServicio : IVentaServicio
    {
        private readonly ApplicationDbContext _context;

        public VentaServicio(ApplicationDbContext context)
        {
            _context = context;
        }

        public List<Venta> MostrarVentas()
        {
            return _context.Ventas.ToList();
        }
    }
}