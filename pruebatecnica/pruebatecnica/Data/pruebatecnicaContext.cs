using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using pruebatecnica.Models;

namespace pruebatecnica.Data
{
    public class pruebatecnicaContext : DbContext
    {
        public pruebatecnicaContext (DbContextOptions<pruebatecnicaContext> options)
            : base(options)
        {
        }

        public DbSet<pruebatecnica.Models.Producto> Producto { get; set; }
    }
}
