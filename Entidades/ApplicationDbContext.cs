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
        public DbSet<VentaProducto> VentasProductos {get;set;}


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.Entity <Venta>()
                .HasMany(v => v.Productos)
                .WithMany(p => p.Ventas)
                .UsingEntity<VentaProducto>(
                    vp => vp.HasOne(prop => prop.Producto) 
                    .WithMany()
                    .HasForeignKey(prop => prop.ProductoId),
                    vp => vp.HasOne(prop => prop.Venta)
                    .WithMany()
                    .HasForeignKey(prop => prop.VentaId)   
                );

            base.OnModelCreating(modelBuilder);
        }
    }
}