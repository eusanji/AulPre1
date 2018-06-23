using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controllers
{
             public class ProfessoresController
    {
        List<Professor> tabelaProfessores = new List<Professor>();

        public void InserirProf(Professor p)
        {
            tabelaProfessores.Add(p);
        }
        public List<Professor> ListarTodosProfessor()
        {
            return tabelaProfessores;
        }

       
    }
}
