using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Examen_TacticaSoft.Entidades;
using Examen_TacticaSoft.Servicios;

namespace Examen_TacticaSoft._Pages_Clientes
{
    public class IndexModel : PageModel
    {
        private readonly Examen_TacticaSoft.Entidades.ApplicationDbContext _context;
        private IClienteServicio _clienteServicio;
        public string NombreOrden;
        public string CorreoOrden;

        [TempData]
        public string MensajeExitoso { get; set; }
        [TempData]
        public string MensajeBorrado { get; set; }
        [TempData]
        public string MensajeEditado { get; set; }

        public IndexModel(Examen_TacticaSoft.Entidades.ApplicationDbContext context, IClienteServicio clienteSrv)
        {
            _context = context;
            _clienteServicio = clienteSrv;
        }

        public IList<Cliente> Cliente { get;set; } = default!;

        public async Task OnGetAsync(string FiltroNombre, string FiltroCorreo, string CampoOrden, string LimpiarFiltros)
        {
            NombreOrden = (CampoOrden == "Nombre_Asc") ? "Nombre_Desc" : "Nombre_Asc";

            if (_context.Clientes != null)
            {
                Cliente = await _context.Clientes.ToListAsync();
            }

            // Logica para filtrar por x paramatro 

            if (LimpiarFiltros != null && LimpiarFiltros.Length > 0)
            {
                Cliente = _clienteServicio.MostrarClientes();
            }

            if (FiltroNombre != null && FiltroNombre.Length > 0)
            {
                Cliente = Cliente.Where(x => x.Nombre.ToUpper().Contains(FiltroNombre.ToUpper())).ToList();
            }

            if (FiltroCorreo != null && FiltroCorreo.Length > 0)
            {
                Cliente = Cliente.Where(x => x.Correo.ToUpper().Contains(FiltroCorreo.ToUpper())).ToList();
            }

            // Logica para ordernar por campos
            switch (CampoOrden)
            {
                case "Nombre_Asc":
                    Cliente = Cliente.OrderBy(x => x.Nombre).ToList();
                    break;
                case "Nombre_Desc":
                    Cliente = Cliente.OrderByDescending(x => x.Nombre).ToList();
                    break;
                case "Correo_Asc":
                    Cliente = Cliente.OrderBy(x => x.Correo).ToList();
                    break;
                case "Correo_Desc":
                    Cliente = Cliente.OrderByDescending(x => x.Correo).ToList();
                    break;
                default:
                    Cliente = Cliente.OrderBy(x => x.Id).ToList();
                    break;
            }
        }
    }
}
