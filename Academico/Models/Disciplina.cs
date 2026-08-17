namespace Academico.Models
{
    public class Disciplina
    {
        public int DisciplinaId { get; set; }

        public string Nome { get; set; } = string.Empty;

        public int Semestre { get; set; }

        // Mapeando o relacionamento com Curso
        public int CursoId { get; set; }

        public Curso Curso { get; set; } = null!;
    }
}