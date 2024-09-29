using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _2024_PC2.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) 
            : base(options)
        {
        }

        // Aquí defines las tablas de la base de datos
        public DbSet<CuentaBancaria> CuentasBancarias { get; set; }
    }
}