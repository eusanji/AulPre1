using System.ComponentModel.DataAnnotations;

namespace Models
{
    public class Aluno
    {
        [Key]

        public int AlunoID { get; set; }
        private string nome;
        public string Nome { get; set; }

        [Required]
        public int Matricula { get; set; }

        

    }
}
