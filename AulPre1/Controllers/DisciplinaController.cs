using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controllers
{
    public class DisciplinaController
    {
        List<Disciplina> tabelaDisciplinas = new List<Disciplina>();

        public void Inserird(Disciplina d)
        {
            tabelaDisciplinas.Add(d);
        }
        public List<Disciplina> ListarDisciplinas()
        {
            return tabelaDisciplinas;
        }
        public void Delete(Disciplina d)
        {
            tabelaDisciplinas.Remove(d);
        }

    }
}
