using FBUsuarios.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FBUsuarios
{
    public class AplicationDBContext: DbContext
    {
        public DbSet<Usuarios> Usuarios { get; set; }

        public AplicationDBContext(DbContextOptions<AplicationDBContext> options): base(options)
        {

        }
    }
}
