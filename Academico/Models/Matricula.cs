namespace Academico.Models
{
    public class Matricula
    {
        public int MatriculaId { get; set; }

        public DateTime DataMatricula { get; set; }

        //Mapeando o relacionemento com Curso e Aluno n para n

        public int CursoId { get; set; }

        public int AlunoId { get; set; }

        public  Curso Curso { get; set; }

        public Aluno Aluno { get; set; }


    }
}
