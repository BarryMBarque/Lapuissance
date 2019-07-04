using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using Modelo;
using System.Data;

namespace Persistencia
{
    public class EFContext : DbContext
    {
        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Animal> Animals { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer(@"Server=LAPTOP-U3GF8FH4\BARRYSQL;Database=DB_Cliente;Trusted_Connection=True;");

        }

        
    }
}

