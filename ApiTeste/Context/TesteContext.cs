using ApiTeste.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiTeste.Context
{
    public class TesteContext: DbContext
    {
        public DbSet<Empresa> Empresas { get; set; }
        public TesteContext(DbContextOptions<TesteContext> options) :base(options)
        {
    
        }
    }
}
