using Controllers.DAL;
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
        Contexto contextoD = new Contexto();

        public void InserirDisci(Disciplina nd)
        {
            contextoD.Disciplinas.Add(nd);
            contextoD.SaveChanges();  
        }
        public List<Disciplina> ListarDisciplinas()
        {
            return contextoD.Disciplinas.ToList();
        }
        public Disciplina BuscarDiscID(int iddisciplina)
        {
            return contextoD.Disciplinas.Find(iddisciplina);
        }
        public void AtualizarD(Disciplina disciplina)
        {
            contextoD.Entry(disciplina).State = System.Data.Entity.EntityState.Modified;
            contextoD.SaveChanges();
        }
            public void ExcluirD(int iddisciplina)
        {
            Disciplina disciplina = BuscarDiscID(iddisciplina);
            contextoD.Disciplinas.Remove(disciplina);
            contextoD.SaveChanges();
        }

    }
}
