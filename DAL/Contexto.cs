using Microsoft.EntityFrameworkCore;
using RegistroPersona.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RegistroPersona.DAL
{
    public class Contexto : DbContext
    {
        public DbSet<Personas> Personas { get; set; }

        public Contexto(DbContextOptions<Contexto> options) : base(options)
        {

        }
    }

    
}
