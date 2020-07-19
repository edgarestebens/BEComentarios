using BEComentarios.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BEComentarios
{
    public class DbAplicationDbContext:DbContext
    {

        
        public DbAplicationDbContext(DbContextOptions options): base(options)
        {

        }
        
        public DbSet<Comentario> Comentario { get; set; }

    }
}
