using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Academico.Models;

    public class AplicationDbContext : DbContext
    {
        public AplicationDbContext (DbContextOptions<AplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Academico.Models.Usuario> Usuario { get; set; } = default!;

public DbSet<Academico.Models.Matricula> Matricula { get; set; } = default!;

public DbSet<Academico.Models.Disciplina> Disciplina { get; set; } = default!;
    }
