using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Examen_TacticaSoft.Entidades;


namespace Examen_TacticaSoft.Servicios
{
    public interface IClienteServicio
    {
        List<Cliente> MostrarClientes();
    }

    public class ClienteServicio : IClienteServicio
    {
        private readonly ApplicationDbContext _context;

        public ClienteServicio(ApplicationDbContext context)
        {
            _context = context;
        }

        public List<Cliente> MostrarClientes()
        {
            return _context.Clientes.ToList();
        }
    }
}