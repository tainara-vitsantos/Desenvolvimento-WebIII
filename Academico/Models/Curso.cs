namespace Academico.Models
{
    public class Curso
    {
        public int CursoId { get; set; }

        public string Nome  { get; set; }

        public int Vagas { get; set; }

        //Mapeando o relacionamento com Disciplina

        public ICollection<Disciplina> Disciplinas { get; set; }

    }
}
