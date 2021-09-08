using Microsoft.EntityFrameworkCore;
using ProcessoseletivoUppetTools.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProcessoseletivoUppetTools.Context
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }

        public DbSet<Empresa> Empresas { get; set;}
        
    }
}
