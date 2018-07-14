using System.ComponentModel.DataAnnotations;

namespace Models
{
    public class Disciplina
    {
       [Key]
        public int DisciplinaID { get; set; }
        private string nomed;
        public string NomeD { get; set; }

        public int CargaHoraria { get; set; }
    }
}
