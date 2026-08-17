namespace Academico.Models
{
    public class Matricula
    {
        public int MatriculaId { get; set; }

        public DateTime DataMatricula { get; set; }

        // Mapeando o relacionamento com Curso e Aluno n para n
        public int CursoId { get; set; }

        public int AlunoId { get; set; }

        public Curso Curso { get; set; } = null!;

        public Aluno Aluno { get; set; } = null!;
    }
}