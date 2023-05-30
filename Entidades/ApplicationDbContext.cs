using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;


namespace Examen_TacticaSoft.Entidades
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options ) : base(options)
        {

        }

        public DbSet<Cliente> Clientes {get;set;}
        public DbSet<Producto> Productos {get;set;}
        public DbSet<Venta> Ventas {get;set;}

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

        }
    }
}