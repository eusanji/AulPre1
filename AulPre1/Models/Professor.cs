using System.ComponentModel.DataAnnotations;

namespace Models
{
    public class Professor
    {
        [Key]

        public int ProfessorID { get; set; }
        private string nomep;
        public string NomeP { get; set; }

        [Required]
        public int MatriculaP { get; set; }

    }
}
