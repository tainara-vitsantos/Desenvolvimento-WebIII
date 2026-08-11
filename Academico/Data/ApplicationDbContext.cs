using Academico.Models;
using Microsoft.EntityFrameworkCore;

namespace Academico.Data
{
    public class ApplicationDbContext : DbContext 
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options ) : base(options) { }

        // Mapeamento da models para nossa tabela 

        public DbSet<Usuario>  Usuarios { get; set; }

        public DbSet<Aluno> Alunos { get; set; }

        public DbSet<Curso> Curso { get; set; }

        public DbSet<Disciplina> Disciplinas { get; set; }

        public DbSet<Matricula> Matriculas { get; set; }


    }
}
