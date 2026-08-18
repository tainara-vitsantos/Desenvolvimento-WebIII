using System.ComponentModel.DataAnnotations;


namespace Academico.Models
{
    public class Usuario
    {
        public int UsuarioId { get; set; }

        public string Nome { get; set; } = string.Empty;

        [Required(ErrorMessage = "O campo Email é obrigatório.")]
        public string Email { get; set; } = string.Empty;

        public string Senha { get; set; } = string.Empty;
    }
}