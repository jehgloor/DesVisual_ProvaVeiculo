using Microsoft.EntityFrameworkCore;
using prova.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace prova.Data
{
    public class Context:DbContext

    {
        public Context(DbContextOptions<Context> opt):base(opt)
        {

        }
        public DbSet<Veiculo> Veiculos { get; set; }
    }
}
